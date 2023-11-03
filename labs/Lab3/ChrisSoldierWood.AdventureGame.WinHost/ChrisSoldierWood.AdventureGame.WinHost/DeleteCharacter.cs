using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ChrisWood.AdventureGame;

namespace ChrisSoldierWood.AdventureGame.WinHost
{
    public partial class DeleteCharacter : Form
    {
        public DeleteCharacter (Character character)
        {
            InitializeComponent();
        }

        public void yeetusDeletus(Character ch )
        {
            Character.CharacterRoster.Remove(ch);
        }

        private void button1_Click ( object sender, EventArgs e)
        {
            
        }
    }
}
