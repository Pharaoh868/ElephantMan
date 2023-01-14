namespace ElephantMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { name = "Lucinda", earSize = 33 };
            Elephant lloyd = new Elephant() { earSize = 40, name = "Lloyd" };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;

                if (input == '1')
                {
                    Console.WriteLine("You pressed " + input);
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                if (input == '2') {
                    Console.WriteLine("You pressed " + input);
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI(); }
                if (input == '3')
                {
                    Console.WriteLine("You pressed " + input);
                    Elephant saver;
                    saver = lucinda;
                    lucinda = lloyd;
                    lloyd = saver;
                    Console.WriteLine("References have been swapped");
                }
            }
        }
    }
}   
