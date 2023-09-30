
// ITSE 1430 Fall 2023
// Lab 2 Character Creator
// Written by Chris "Soldier" Wood
// 09 30 23


internal class Program
{
    private static void Main ( string[] args )
    {

        DisplayIntro();

        var done = false;

        do
        {
            switch (GetUserSelection())
            {
                case 1:
                Console.WriteLine("Add\n");
                break;
                case 2:
                Console.WriteLine("Edit\n");
                break;
                case 3:
                Console.WriteLine("Delete\n");
                break;
                case 0:
                if (!Confirmation("Are you sure you want to quit the game (Y/N/)?"))
                {
                    done = true;
                }
                break;
                case 5: Console.WriteLine("\n"); break;
            };
        } while (!done);

        void DisplayIntro ()
        {

            Console.WriteLine("ITSE 1430 Character Creator");
            Console.WriteLine("Written by Chris \"Soldier\" Wood");
            Console.WriteLine("Fall 2023\n");

        }

        int GetUserSelection ()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("-----------------------");
            Console.WriteLine("A) Add character");
            Console.WriteLine("E) Edit character");
            Console.WriteLine("D) Delete Character");
            Console.WriteLine("Q) Quit\n");

            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A: return 1;
                    case ConsoleKey.E: return 2;
                    case ConsoleKey.D: return 3;
                    case ConsoleKey.Q: return 0;

                    default: Console.WriteLine("Unknown option"); return 5;
                };
            } while (true);
        }

        bool Confirmation ( string message )
        {
            return ReadBoolean(message);
        }

        bool ReadBoolean ( string message )
        {
            Console.WriteLine(message);

            while (true)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Y: return false;
                    case ConsoleKey.N: return true;
                };
            }
        }


    }
}