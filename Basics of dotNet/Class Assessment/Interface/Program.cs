using System;

class Program
{
    static void Main(string[] args)
    {
        Printer eps = new Epsilon();
        Printer hp = new Hp();

        eps.Print();
        hp.Print();
    }
}
