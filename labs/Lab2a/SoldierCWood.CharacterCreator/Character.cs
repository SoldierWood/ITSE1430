// ITSE 1430 Fall 2023
// Lab 2 Character Creator
// Written by Chris "Soldier" Wood
// 09 30 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoldierCWood.CharacterCreator
{
    /// <summary> Represents game character. </summary>
    public class Character
    {
        public Character() { }
        /// <summary> Gets or sets character name. </summary>

        private string _name;
        public bool characterExists = false;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

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
             
        }

        public static void AddCharacterProfession ( Character newChar )
        {
            Console.WriteLine();

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

        }

        public static void DisplayProfessionChoices ()
        {
            Console.WriteLine("Enter character profession");
            Console.WriteLine("Available choices: ");
            Console.WriteLine("F) Fighter");
            Console.WriteLine("H) Hunter");
            Console.WriteLine("P) Priest");
            Console.WriteLine("R) Rogue");
            Console.WriteLine("W) Wizard");
        }

        private string _profession;

        public string Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }

        //public string Name
        //{ get; set; }
        /// <summary> Gets or sets character profession. </summary>
        //public string Profession
        //{ get; set; }
        /// <summary> Gets or sets character race. </summary>
        public static void AddCharacterRace ( Character newChar )
        {
            Console.WriteLine();

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

        private string _race;

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        //public string Race
        //{ get; set; }
        /// <summary> Gets or sets character biography. </summary>

        public static void AddCharacterBio ( Character newChar )
        {
            Console.WriteLine("Enter brief character biography, which is optional: ");
            string value = Console.ReadLine();

            newChar.Bio = value;

            Console.WriteLine();
            //Console.WriteLine("Your character has been created.");
        }

        public static void ConfirmCreation ( Character newChar )
        {
            if (String.IsNullOrEmpty(newChar.Name))
            {
                Console.WriteLine("Character has not yet been created. Please make appropriate selection to create a character.");
                Console.WriteLine();
                return;
            } else
            {
                Console.WriteLine("Character has successfully been created.\n");
            }
        }

        private string _bio;

        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        //public string Bio
        //{ get; set; }

        /// <summary>
        ///  Physical power.
        /// </summary>

        public static void AssignStrength ( Character newChar )
        {
            newChar.Strength = GeneratePercentage();

            Console.WriteLine("Your character's strength level: " + newChar.Strength);

        }

        private int _strength;

        public int Strength
        {
            get { return _strength; }
            set {  _strength = value; }
        }

        //public int Strength
        //{ get; set; }

        public static int GeneratePercentage ()
        {
            return Random.Shared.Next(1, 101);
        }

        public static void AssignIntelligence ( Character newChar )
        {
            newChar.Intelligence = GeneratePercentage();

            Console.WriteLine("Your character's level of intelligence: " + newChar.Intelligence);

        }

        private int _intelligence;

        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }
        /// <summary> Combination of book and street smarts. </summary>
        //public int Intelligence

        //{ get; set; }

        public static void AssignAgility ( Character newChar )
        {
            newChar.Agility = GeneratePercentage();

            Console.WriteLine("Your character's agility: " + newChar.Agility);

        }

        private int _agility;

        /// <summary> Ability to "roll with the punches". </summary>
        public int Agility
        {
            get { return _agility; }
            set { _agility = value; }
        }

        public static void AssignConstitution ( Character newChar )
        {
            newChar.Constitution = GeneratePercentage();

            Console.WriteLine("Your character's constitution: " + newChar.Constitution);

        }

        /// <summary> Person's psychological makeup, both inherited and life taught. </summary>
        
        

        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }
            set { _constitution = value; }
        }

        /// <summary> Ability to make 'em smile, even when they don't want to. </summary>
        public static void AssignCharisma ( Character newChar )
        {
            newChar.Charisma = GeneratePercentage();

            Console.WriteLine("Your character's charisma: " + newChar.Charisma);

            Console.WriteLine();

        }

        private int _charisma;

        public int Charisma
        {
            get { return _charisma; }
            set { _charisma = value; }
        }

        public static void ViewCharacter ( Character newChar )
        {
            if (String.IsNullOrEmpty(newChar.Name))
            {
                Console.WriteLine("Character has not yet been created. Please make appropriate selection to create a character.");
                Console.WriteLine();
                return;
            } else
            {
                DisplayCharacter(newChar);
            }
        }
        public static void DisplayCharacter ( Character newChar )
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
        public static void EditCharacter ( Character newChar )
        {
            EditName(newChar);
            EditProfession(newChar);
            EditRace(newChar);
            EditBio(newChar);

            Console.WriteLine("Sorry, you cannot edit your strength, intelligence, agility, constitution, or charisma.");
            Console.WriteLine("You were born with these regardless of other character traits.");
            Console.WriteLine();
        }
        public static void EditName ( Character newChar )
        {
            Console.WriteLine($"Your current name is: {newChar.Name}");
            Console.WriteLine("Do you wish to change your name? Please enter Y or N: ");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                {
                    Console.WriteLine("Enter new name: ");
                    newChar.Name = Console.ReadLine();
                    Console.WriteLine("Your new name is: " + newChar.Name);
                    Console.WriteLine();
                }
                break;
                case ConsoleKey.N:
                {
                    Console.WriteLine("Your name remains as: " + newChar.Name);
                    Console.WriteLine();
                }
                break;
                default:
                break;
            };
        }
        public static void EditProfession ( Character newChar )
        {
            Console.WriteLine($"Your current profession is: {newChar.Profession}");
            Console.WriteLine("Do you wish to change your profession? Please enter Y or N: ");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                {
                    Character.AddCharacterProfession(newChar);
                    Console.WriteLine("Your new profession is: " + newChar.Profession);
                    Console.WriteLine();
                }
                break;
                case ConsoleKey.N:
                {
                    Console.WriteLine("Your profession remains as: " + newChar.Profession);
                    Console.WriteLine();
                }
                break;
                default:
                break;
            };
        }
        public static void EditRace ( Character newChar )
        {
            Console.WriteLine($"Your current race is: {newChar.Race}");
            Console.WriteLine("Do you wish to change your race? Please enter Y or N: ");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                {
                    Character.AddCharacterRace(newChar);
                    Console.WriteLine("Your new race is: " + newChar.Race);
                    Console.WriteLine();
                }
                break;
                case ConsoleKey.N:
                {
                    Console.WriteLine("Your race remains as: " + newChar.Race);
                    Console.WriteLine();
                }
                break;
                default:
                break;
            };
        }

        public static void EditBio (Character newChar)
        {
            Console.WriteLine($"Your current bio states: {newChar.Bio}");
            Console.WriteLine("Do you wish to modify your bio? Please enter Y or N: ");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Y:
                {
                    Character.AddCharacterBio(newChar);
                    Console.WriteLine("Your new bio states: " + newChar.Bio);
                    Console.WriteLine();
                }
                break;
                case ConsoleKey.N:
                {
                    Console.WriteLine("Your bio still says: " + newChar.Bio);
                    Console.WriteLine();
                }
                break;
                default:
                break;
            };
        }

        public static bool DeleteCharacter ( Character newChar, bool Exists)
        {
            if (String.IsNullOrEmpty(newChar.Name))
            {
                Console.WriteLine("Character has not yet been created. Please make appropriate selection to create a character.");
                Console.WriteLine();
                return Exists;
            } else
            {
                Console.WriteLine("Are you sure you want to delete your character? Please enter Y or N: ");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.Y:
                    DeleteSteps(newChar);
                    Exists = false;
                    return Exists;
                    
                    case ConsoleKey.N:
                    {
                        Console.WriteLine("Your character lives on.");
                        Console.WriteLine();
                        return Exists;
                    }
                    default:
                    return Exists;
                };
            }
        }
        public static void DeleteSteps ( Character newChar )
        {
            newChar.Name = null;
            newChar.Race = null;
            newChar.Profession = null;
            newChar.Bio = null;
            newChar.Strength = 0;
            newChar.Intelligence = 0;
            newChar.Agility = 0;
            newChar.Constitution = 0;
            newChar.Charisma = 0;
            

            Console.WriteLine("Your character has been deleted.");
            Console.WriteLine();

        }
    }

}
