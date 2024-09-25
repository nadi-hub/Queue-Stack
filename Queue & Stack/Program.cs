namespace Queue___Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> warteschlange = new Queue<string>();

            // Kunden kommen in die Warteschlange
            warteschlange.Enqueue("Atifa");
            warteschlange.Enqueue("Mareen");
            warteschlange.Enqueue("Nadja);
    
            warteschlange.Enqueue("Jenu");

            Console.WriteLine("Der erste Kunde wird bedient: " + warteschlange.Dequeue());
            Console.WriteLine("Der nächste Kunde wird bedient: " + warteschlange.Dequeue());

            // Aktuelle Warteschlange anzeigen
            Console.WriteLine("Aktuelle Warteschlange:");
            foreach (var kunde in warteschlange)
            {
                Console.WriteLine(kunde);
            }
        }
    }
}
