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
            set {  _strength = value; }
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

    }

}
