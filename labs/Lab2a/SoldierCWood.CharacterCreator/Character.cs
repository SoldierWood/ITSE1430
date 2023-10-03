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
        public string Name
        { get; set; }
        /// <summary> Gets or sets character profession. </summary>
        public string Profession
        { get; set; }
        /// <summary> Gets or sets character race. </summary>
        public string Race
        { get; set; }
        /// <summary> Gets or sets character biography. </summary>
        public string Bio
        { get; set; }

       
        private int _strength = 15;
        /// <summary> Physical strength. </summary>
        public int Strength
        {   
            get => _strength;
            
            set {
                _strength = value;
            }
        }

        private int _intelligence = 85;
       /// <summary> Combination of book and street smarts. </summary>
        public int Intelligence
            
        {
            get => _intelligence;
      
            set {
                _intelligence = value;
            }
        }

        /// <summary> Ability to "roll with the punches". </summary>
        private int _agility = 90;
        public int Agility

        {
            get => _agility;

            set {
                _agility = value;
            }
        }
        private int _constitution = 99;

        /// <summary> Person's makeup, both inherited and life taught. </summary>
        public int Constitution

        {
            get => _constitution;

            set {
                _constitution = value;
            }
        }

        private int _charisma = 88;
        /// <summary> Ability to make 'em smile, even when they don't want to. </summary>
        public int Charisma
        {
            get => _charisma;
            set {
                _charisma = value;
            }
        }
    }


}
