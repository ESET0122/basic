#include "hal/hal_gpio.h"
#include "../config/led_config.h"
#include <util/delay.h>

int main(void) {
    HAL_GPIO_Init(LED_PORT, LED_PIN, OUTPUT);
    HAL_GPIO_Init(BUTTON_PORT, BUTTON_PIN, INPUT);

    // Enable pull-up for button (idle = HIGH)
    *BUTTON_PORT |= (1 << BUTTON_PIN);

    uint8_t last_button_state = 1;
    uint8_t mode = 0;   // 0 = off, 1 = slow, 2 = fast, 3 = solid ON

    while (1) {
        uint8_t button_state = HAL_GPIO_Read(BUTTON_PORT, BUTTON_PIN);

        // Detect falling edge (button press)
        if (last_button_state == 1 && button_state == 0) {
            mode++;
            if (mode > 3) mode = 0;   // cycle 0→1→2→3→0
        }

        last_button_state = button_state;

        switch (mode) {
            case 1:
                HAL_GPIO_Toggle(LED_PORT, LED_PIN);
                _delay_ms(500);  // slow blink
                break;

            case 2:
                HAL_GPIO_Toggle(LED_PORT, LED_PIN);
                _delay_ms(100);  // fast blink
                break;

            case 3:
                HAL_GPIO_Write(LED_PORT, LED_PIN, 1);  // LED stays ON
                _delay_ms(10);  // small delay for stability
                break;

            default:
                HAL_GPIO_Write(LED_PORT, LED_PIN, 0);  // LED OFF
                _delay_ms(10);  // small delay to reduce CPU load
                break;
        }

    }
}