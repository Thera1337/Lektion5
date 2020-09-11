using System;

namespace CodaLongMetoder
{
    class Program
    {
        private static int AntoniosFingrar(int a)
        {
            return a + 3;
        }
        static void Main(string[] args)
        {
            InfoText();
            Addera(9,11);
            int result = Subtrahera(25,13);
            Console.WriteLine(result);


            Console.WriteLine($"Belopp med moms CASH MONEY: {AmountIncludingMoms(100)}");

            Console.WriteLine($"Belopp med moms: {AmountIncludingMoms(100)}");
            Console.WriteLine("Mattias was here...");

            Console.WriteLine("And again...");

            Console.WriteLine("Sjuk idé, lägger till en rad här.");
            AntoniosAntalFingrar(10);

            Console.WriteLine($"Hur många fingrar har Antonio egentligen? Svar {AntoniosFingrar(10)} st");
            

        }
        private static int AntoniosAntalFingrar(int a)
        {
            return a + 3;
        }
        private static double AmountIncludingMoms(int v)
        {
            return v + AdderaMoms(v);
        }

        private static double AdderaMoms(int v)
        {
            return v * 0.25;
        }

        private static int Subtrahera(int v1, int v2)
        {
            int r = v1 - v2;
            return r;
        }

        private static void Addera(int v1, int v2)
        {
            Console.WriteLine(v1 + v2);
        }

        private static void InfoText()
        {
            Console.WriteLine("En text...");
        }
    }
}
