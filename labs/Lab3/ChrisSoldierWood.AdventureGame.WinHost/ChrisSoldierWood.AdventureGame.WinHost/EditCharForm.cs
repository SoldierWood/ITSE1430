using ChrisWood.AdventureGame;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChrisSoldierWood.AdventureGame.WinHost
{
    public partial class EditCharForm : Form
    {

        public MainForm mForm;

        public EditCharForm()
        {
            InitializeComponent();
        }

        /// <summary> Gets or sets the movie.  </summary>
        //public Character Character { get; set; }

        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_txtCharName.Text))
            {
                // Invalid
                _error.SetError(_txtCharName, "Title is required");
                e.Cancel = true;
            } else
            {
                _error.SetError(_txtCharName, "");
            }

        }

        private void OnValidateProfession ( object sender, CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_cbProfession.Text))
            {
                //Invalid
                _error.SetError(_cbProfession, "Profession is required");
                e.Cancel = true;
            } else
                _error.SetError(_cbProfession, "");
        }

        private void OnValidateRace ( object sender, CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_cbRace.Text))
            {
                //Invalid
                _error.SetError(_cbRace, "Profession is required");
                e.Cancel = true;
            } else
                _error.SetError(_cbRace, "");
        }

        private void OnValidateStrength ( object sender, CancelEventArgs e )
        {
            var value = GetInt32(_txtStrength, 50);

            if ((value < 0) || (value > 100))
            {
                //Invalid
                _error.SetError(_txtStrength, "Strength value must be between 1 - 100");
            } else
                _error.SetError(_txtStrength, "");
        }
        private void OnValidateIntelligence ( object sender, CancelEventArgs e )
        {
            var value = GetInt32(_txtIntelligence, 50);

            if ((value < 0) || (value > 100))
            {
                //Invalid
                _error.SetError(_txtIntelligence, "Strength value must be between 1 - 100");
            } else
                _error.SetError(_txtIntelligence, "");

        }

        private void OnValidateAgility ( object sender, CancelEventArgs e )
        {
            var value = GetInt32(_txtAgility, 50);

            if ((value < 0) || (value > 100))
            {
                //Invalid
                _error.SetError(_txtAgility, "Strength value must be between 1 - 100");
            } else
                _error.SetError(_txtAgility, "");
        }

        private void OnValidateConstitution ( object sender, CancelEventArgs e )
        {
            var value = GetInt32(_txtConstitution, 50);

            if ((value < 0) || (value > 100))
            {
                //Invalid
                _error.SetError(_txtConstitution, "Strength value must be between 1 - 100");
            } else
                _error.SetError(_txtConstitution, "");
        }

        private void OnValidateCharisma ( object sender, CancelEventArgs e )
        {
            var value = GetInt32(_txtCharisma, 50);

            if ((value < 0) || (value > 100))
            {
                //Invalid
                _error.SetError(_txtCharisma, "Strength value must be between 1 - 100");
            } else
                _error.SetError(_txtCharisma, "");

        }

        public void SetCharNameBox ( string chName )
        {
            _txtCharName.Text = chName;

        }

        public void SetProfessionCBox ( string chProfession )
        {
            _cbProfession.Text = chProfession;
        }
        public void SetRaceCBox ( string chRace )
        {
            _cbRace.Text = chRace;
        }

        public void SetBioBox ( string chBio )
        {
            _txtBiography.Text = chBio;
        }
        public void SetStrengthBox ( int chStrength )
        {
            _txtStrength.Text = chStrength.ToString();
        }
        public void SetIntelligenceBox ( int chIntelligence )
        {
            _txtIntelligence.Text = chIntelligence.ToString();
        }

        public void SetAgilityBox ( int chAgility )
        {
            _txtAgility.Text = chAgility.ToString();
        }

        public void SetConstitutionBox ( int chConstitution )
        {
            _txtConstitution.Text = chConstitution.ToString();
        }

        public void SetCharismaBox ( int chCharisma )
        {
            _txtCharisma.Text = chCharisma.ToString();
        }


        private int GetInt32 ( Control control, int defaultValue )
        {
            if (Int32.TryParse(control.Text, out var value))
                return value;

            return defaultValue;
        }

        private void Strength_ValueChanged ( object sender, EventArgs e )
        {

        }

        private void NewCharForm_Load ( object sender, EventArgs e )
        {

        }

        protected void OnSave ( object sender, EventArgs e )
        {
            var button = sender as Button;

            var newChar = new Character();
            

            // Populate from UI
            newChar.Name = _txtCharName.Text;
            newChar.Profession = _cbProfession.Text;
            newChar.Race = _cbRace.Text;
            newChar.Bio = _txtBiography.Text;
            newChar.Strength = Convert.ToInt32(_txtStrength.Text);
            newChar.Intelligence = Convert.ToInt32(_txtIntelligence.Text);
            newChar.Agility = Convert.ToInt32(_txtAgility.Text);
            newChar.Constitution = Convert.ToInt32(_txtConstitution.Text);
            newChar.Charisma = Convert.ToInt32(_txtCharisma.Text);

            if (!newChar.TryValidate(out var error))
            {
                MessageBox.Show(this, error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                DialogResult = DialogResult.None;
                return;
            };
            Character.CharacterRoster.Add(newChar);

            //MessageBox.Show($"Total length of character roster: {Character.CharacterRoster.Count}");



            mForm.ListRefresh();

            this.Close();



        }



        private void _txtCharName_TextChanged ( object sender, EventArgs e )
        {

        }

        private void _cbProfession_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void _cbRace_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void _txtBiography_TextChanged ( object sender, EventArgs e )
        {

        }

        private void _txtBiography_TextChanged_1 ( object sender, EventArgs e )
        {

        }

        private void label8_Click ( object sender, EventArgs e )
        {

        }

        private void OnCancel ( object sender, EventArgs e )
        {

            DialogResult = DialogResult.Cancel;
            Close();

        }
    }


}
