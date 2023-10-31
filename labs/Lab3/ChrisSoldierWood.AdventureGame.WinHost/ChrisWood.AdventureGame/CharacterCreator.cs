// ITSE 1430 Fall 2023
// Addition of Lab 2 Character Creator Class
// Written by Chris "Soldier" Wood
// 09 30 23

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrisWood.AdventureGame
{
    //internal class CharacterCreator
    //{
    //}

    /// <summary> Represents game character. </summary>
    public class Character
    {

        public static List<Character> CharacterRoster = new List<Character>();
        
        /// <summary> Result for if character exists. </summary>
        /// <param name="characterExists">Indicator for if character exists. </param>
        public bool characterExists = false;

        private string _name;
        /// <summary> Name of character. </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        private string _profession;

        /// <summary> Professsion for character. </summary>
        public string Profession
        {
            get { return _profession; }
            set { _profession = value; }
        }

        private string _race;

        /// <summary> Race of character </summary>
        /// <param> Character race </param>
        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        private string _bio;

        /// <summary> User defined character biography. </summary>
        public string Bio
        {
            get { return _bio; }
            set { _bio = value; }
        }

        private int _strength;

        /// <summary> Physical power. </summary>
        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        private int _intelligence;

        /// <summary> Level of intelligence, which is a combination of book and street smarts. </summary>
        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }


        private int _agility;

        /// <summary> Ability to "roll with the punches". </summary>
        public int Agility
        {
            get { return _agility; }
            set { _agility = value; }
        }

        private int _constitution;
        /// <summary> Person's psychological makeup, both inherited and life taught. </summary>
        public int Constitution
        {
            get { return _constitution; }
            set { _constitution = value; }
        }

        private int _charisma;

        /// <summary> Ability to make 'em smile, even when they don't want to. </summary>
        public int Charisma
        {
            get { return _charisma; }
            set { _charisma = value; }
        }
        /// <summary> Validates the character instance.
        public bool TryValidate (out string message )
        {
            //Name is required
            if (String.IsNullOrEmpty(_name))
            {
                message = "Name is required. Please enter at least one character.";
                return false;
            }

            //Profession is required
            if (String.IsNullOrEmpty(_profession))
            {
                message = "Profession is required. Please select a profession.";
                return false;
            }

            //Race is required
            if (String.IsNullOrEmpty(_race))
            {
                message = "Race is required. Please select a race.";
                return false;
            }

            // Strength attribute must be integer between 1 - 100
            if ((_strength < 1) || (_strength > 100))
            {
                message = "Strength attribute must be a number between 1 and 100. Please enter number between 1 - 100.";
                return false;
            }

            // Intelligence attribute must be integer between 1 - 100
            if ((_intelligence < 1) || (_intelligence > 100))
            {
                message = "Intelligence attribute must be a number between 1 and 100. Please enter number between 1 - 100.";
                return false;
            }

            // Agility attribute must be integer between 1 - 100
            if ((_agility < 1) || (_agility > 100))
            {
                message = "Agility attribute must be a number between 1 and 100. Please enter number between 1 - 100.";
                return false;
            }

            // Constitution attribute must be integer between 1 - 100
            if ((_constitution < 1) || (_constitution > 100))
            {
                message = "Constitution attribute must be a number between 1 and 100. Please enter number between 1 - 100.";
                return false;
            }

            // Charisma attribute must be integer between 1 - 100
            if ((_charisma < 1) || (_charisma > 100))
            {
                message = "Charisma attribute must be a number between 1 and 100. Please enter number between 1 - 100.";
                return false;
            }

            message = "Character is ready for adventure";
            return true;
        }
        //TODO: return public variables not private
        public override string ToString ()
        {
            return $"{_name} {_profession} {_race}";
        }

        //public bool TryValidate(out string message) /* Character this */
        //{
        //    message = "";
        //    return true;
        //}

    }


}
