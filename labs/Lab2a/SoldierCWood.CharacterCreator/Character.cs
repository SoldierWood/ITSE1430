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
            Console.WriteLine("Your character has been created.");
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
    }

}
