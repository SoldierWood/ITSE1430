
// ITSE 1430 Fall 2023
// Lab 2 Character Creator
// Written by Chris "Soldier" Wood
// 09 30 23

using SoldierCWood.CharacterCreator;

partial class Program
{
    static void Main ( string[] args )
    {

       DisplayIntro();

       var done = false;

       Character myCharacter = new Character();
        
        do
        {
            switch (GetUserSelection())
            {
                case 1:
                createCharacter.AddCharacterName(myCharacter);
                createCharacter.AddCharacterProfession(myCharacter);
                createCharacter.AddCharacterRace(myCharacter);
                createCharacter.AddCharacterBio(myCharacter);
                createCharacter.AssignStrength(myCharacter);
                createCharacter.AssignIntelligence(myCharacter);
                createCharacter.AssignAgility(myCharacter);
                createCharacter.AssignConstitution(myCharacter);
                createCharacter.AssignCharisma(myCharacter);
                break;
                case 2:
                createCharacter.ViewCharacter(myCharacter);
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
            Console.WriteLine("V) View character");
            Console.WriteLine("D) Delete Character");
            Console.WriteLine("Q) Quit\n");

            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A: return 1;
                    case ConsoleKey.V: return 2;
                    case ConsoleKey.D: return 3;
                    case ConsoleKey.Q: return 0;

                    default: Console.WriteLine("Unknown option"); return 5;
                };
            } while (true);
        }

        Console.WriteLine(myCharacter.Name);
        Console.WriteLine(myCharacter.Profession);
        Console.WriteLine(myCharacter.Race);
        Console.WriteLine(myCharacter.Bio);


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

   
    class createCharacter
    {
        public static void AddCharacterName ( Character newChar )
        {
            Console.WriteLine("Enter character name: ");
            string value = Console.ReadLine();
            while (String.IsNullOrEmpty(value))
            {
                Console.WriteLine("Must input at least one character");
                Console.WriteLine("Enter character name: ");
                value = Console.ReadLine();
            }
            newChar.Name = value;
            Console.WriteLine();
        }


        public static void AddCharacterProfession ( Character newChar )
        {
            DisplayProfessionChoices();
            
            var finish = false;

            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.F:
                    newChar.Profession = "Fighter";
                    finish = true;
                    break;
                    case ConsoleKey.H:
                    newChar.Profession = "Hunter";
                    finish = true;
                    break;
                    case ConsoleKey.P:
                    newChar.Profession = "Priest";
                    finish = true;
                    break;
                    case ConsoleKey.R:
                    newChar.Profession = "Rogue";
                    finish = true;
                    break;
                    case ConsoleKey.W:
                    newChar.Profession = "Wizard";
                    finish = true;
                    break;
                    default:
                    Console.WriteLine("Unknown option");
                    DisplayProfessionChoices();
                    break;
                };
            } while (!finish);

            Console.WriteLine();
        }

        public static void DisplayProfessionChoices()
        {
            Console.WriteLine("Enter character profession");
            Console.WriteLine("Available choices: ");
            Console.WriteLine("F) Fighter");
            Console.WriteLine("H) Hunter");
            Console.WriteLine("P) Priest");
            Console.WriteLine("R) Rogue");
            Console.WriteLine("W) Wizard");
        }
        public static void AddCharacterRace ( Character newChar )
        {
            DisplayRaceChoices();

            var complete = false;

            do
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D:
                    newChar.Race = "Dwarf";
                    complete = true;
                    break;
                    case ConsoleKey.E:
                    newChar.Race = "Elf";
                    complete = true;
                    break;
                    case ConsoleKey.G:
                    newChar.Race = "Gnome";
                    complete = true;
                    break;
                    case ConsoleKey.H:
                    newChar.Race = "Half Elf";
                    complete = true;
                    break;
                    case ConsoleKey.U:
                    newChar.Race = "Human";
                    complete = true;
                    break;
                    default:
                    Console.WriteLine("Unknown option");
                    DisplayRaceChoices();
                    break;
                };
            } while (!complete);

            Console.WriteLine();
        }

        public static void DisplayRaceChoices ()
        {
            Console.WriteLine("Enter character race");
            Console.WriteLine("Available choices: ");
            Console.WriteLine("D) Dwarf");
            Console.WriteLine("E) Elf");
            Console.WriteLine("G) Gnome");
            Console.WriteLine("H) Half Elf");
            Console.WriteLine("U) Human");
        }
            public static void AddCharacterBio ( Character newChar )
        {
            Console.WriteLine("Enter brief character biography, which is optional: ");
            string value = Console.ReadLine();
            
            newChar.Bio = value;

            Console.WriteLine();
            Console.WriteLine("Your character has been created.");
        }

        public static void AssignStrength ( Character newChar )
        {
            newChar.Strength = GeneratePercentage();
           
            Console.WriteLine("Your character's strength level: " + newChar.Strength);
            
        }
        public static void AssignIntelligence ( Character newChar )
        {
            newChar.Intelligence = GeneratePercentage();

            Console.WriteLine("Your character's level of intelligence: " + newChar.Intelligence);

        }
        public static void AssignAgility ( Character newChar )
        {
            newChar.Agility = GeneratePercentage();

            Console.WriteLine("Your character's agility: " + newChar.Agility);

        }
        public static void AssignConstitution ( Character newChar )
        {
            newChar.Constitution = GeneratePercentage();

            Console.WriteLine("Your character's constitution: " + newChar.Constitution);

        }

        public static void AssignCharisma ( Character newChar )
        {
            newChar.Charisma = GeneratePercentage();

            Console.WriteLine("Your character's charisma: " + newChar.Charisma);

            Console.WriteLine();

        }
        public static int GeneratePercentage()
        {
            return Random.Shared.Next(1, 101);
        }

        public static void ViewCharacter ( Character newChar)
        {
            if (String.IsNullOrEmpty(newChar.Name))
            {
                Console.WriteLine("Character has not yet been created. Please make appropriate selection to create a character.");
                Console.WriteLine();
                return;
            }
            else
            {
                DisplayCharacter(newChar);
            }
        }
        public static void DisplayCharacter ( Character newChar)
        {
            Console.WriteLine("Character name:" + "\t\t" + newChar.Name);
            Console.WriteLine("Character profession:" + "\t" + newChar.Profession);
            Console.WriteLine("Character race:" + "\t\t" + newChar.Race);
            Console.WriteLine("Character biography: " + "\t" + newChar.Bio);
            Console.WriteLine();
            Console.WriteLine("Character strength: " + "\t\t" + newChar.Strength);
            Console.WriteLine("Character intelligence: " + "\t" + newChar.Intelligence);
            Console.WriteLine("Character agility: " + "\t\t" + newChar.Agility);
            Console.WriteLine("Character constitution: " + "\t" + newChar.Constitution);
            Console.WriteLine("Character charisma: " + "\t\t" + newChar.Charisma);
            Console.WriteLine();

        }

    }
   
}