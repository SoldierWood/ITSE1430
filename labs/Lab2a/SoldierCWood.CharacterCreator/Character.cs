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
        public string Race
        { get; set; }
        /// <summary> Gets or sets character biography. </summary>
        public string Bio
        { get; set; }

       /// <summary>
       ///  Physical power.
       /// </summary>
       public int Strength
        { get; set; }
       
       /// <summary> Combination of book and street smarts. </summary>
       public int Intelligence
            
        { get; set; }
        
        /// <summary> Ability to "roll with the punches". </summary>
        public int Agility
        { get; set; }

        /// <summary> Person's psychological makeup, both inherited and life taught. </summary>
        public int Constitution

        { get; set; }

        /// <summary> Ability to make 'em smile, even when they don't want to. </summary>
        public int Charisma
        { get; set; }
    }

}
