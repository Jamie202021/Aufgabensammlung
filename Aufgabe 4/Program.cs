namespace Aufgabe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib iene Zahle ein zwischen 1 bis 12");
            int I = Convert.ToInt32(Console.ReadLine());

            if (I == 1) { Console.WriteLine("Januar"); }
            else if (I == 2) { Console.WriteLine("Februar"); }
            else if (I == 3) { Console.WriteLine("März"); }
            else if (I == 4) { Console.WriteLine("April"); }
            else if (I == 5) { Console.WriteLine("Mai"); }
            else if (I == 6) { Console.WriteLine("Juni"); }
            else if (I == 7) { Console.WriteLine("Juli"); }
            else if (I == 8) { Console.WriteLine("August"); }
            else if (I == 9) { Console.WriteLine("September"); }
            else if (I == 10) { Console.WriteLine("Oktober"); }
            else if (I == 11) { Console.WriteLine("November"); }
            else if (I == 12) { Console.WriteLine("Dezember"); }
            else { Console.WriteLine("Fehler: Zahl zwischen 1 und 12 erwartet"); }

        }
    }
}
