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
