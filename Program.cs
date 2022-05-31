using System;

namespace test1
{
    class Class1
    {
        [STAThread]
        public static void Main(string[] args)
        {
            string nev;
            Console.WriteLine("Kérlek, add meg a nevedet: ");
            nev = Console.ReadLine();
            Console.WriteLine("Helló {0}", nev);
        }
    }
}
