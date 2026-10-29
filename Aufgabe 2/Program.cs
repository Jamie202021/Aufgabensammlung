namespace Aufgabe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anzahl Tage des Monats: ");
            int tage = Convert.ToInt32(Console.ReadLine());

            if (tage >= 28 && tage <= 31)
            {
                int sekunden = tage * 24 * 60 * 60;
                Console.WriteLine("Sekunden: " + sekunden);
            }
            else
            {
                Console.WriteLine("Fehler: Zahl zwischen 28 und 31 erwartet");
            }

        }
    }
}
