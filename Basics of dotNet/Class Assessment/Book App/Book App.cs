using System.Diagnostics;
using System.Reflection;

namespace my_project
{
    internal class Program
    {
        static string title, author, sell_title, cust_name;
        static float price;
        static int quantity, sell_quantity;
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 5) {
                Console.WriteLine("====== BOOK SHOP MENU ======");
                Console.WriteLine("1. Add Book\r\n2. Sell Book\r\n3. View Books\r\n4. View Sales Report\r\n5. Exit");
                Console.WriteLine("============================");
                Console.Write("Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (1):
                        addBook();
                        Console.WriteLine();
                        break;
                    case (2):
                        sellBook();
                        Console.WriteLine();
                        break;
                    case (3):
                        printReport(true,title,author,price.ToString(),quantity.ToString());
                        Console.WriteLine();
                        break;
                    case (4):
                        printReport(false,cust_name,sell_title,sell_quantity.ToString(),(price*sell_quantity).ToString());
                        Console.WriteLine();
                        break;
                    case (5):
                        Console.WriteLine("Thanks for using Book Shop Management!");
                        break;
                    default:
                        Console.WriteLine("Please enter correct choice!");
                        break;

                }

            }
            
        }
        static void addBook() {
            Console.Write("Enter book title: ");
            title = Console.ReadLine();
            Console.Write("Enter author:");
            author = Console.ReadLine();
            Console.Write("Enter price: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Book added successfully.");
        }
        static void sellBook()
        {
            Console.Write("Enter book title to sell: ");
            sell_title = Console.ReadLine();
            Console.Write("Enter quantity to sell: ");
            sell_quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name: ");
            cust_name = Console.ReadLine();
            if (sell_title != title)
            {
                Console.WriteLine("Book is not in library");
            }
            else
            {
                if (sell_quantity <= quantity)
                {
                    Console.WriteLine($"Sold {sell_quantity} copies of {sell_title} to {cust_name}.");
                    quantity -= sell_quantity;
                }
                else
                {
                    Console.WriteLine($"Cannot sell as only {quantity} books are available.");
                }
            }
        }
        static void printReport(bool book_report, string first_r1, string second_r1, string third_r1, string fourth_r1)
        {
            if (book_report)
            {
                Console.WriteLine("--- Book Inventory ---");
                Console.WriteLine($"Title \t\t\t Author \t\t\t Price \t\t\t Quantity");
                Console.WriteLine($"{first_r1} \t\t\t {second_r1} \t\t\t ${third_r1} \t\t\t {fourth_r1}");
            }
            else {
                Console.WriteLine("--- Sale Report ---");
                Console.WriteLine($"Customer Name \t\t\t Book \t\t\t Quantity Purchased \t\t\t Amount");
                Console.WriteLine($"{first_r1} \t\t\t {second_r1} \t\t\t {third_r1} \t\t\t ${fourth_r1}");
                Console.WriteLine($"Total Amount Spent: ${fourth_r1}");
            }
        }
    }
}
