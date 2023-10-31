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
    public partial class NewCharForm : Form
    {
        public NewCharForm ()
        {
            InitializeComponent();
        }


        private void OnValidateName ( object sender, CancelEventArgs e )
        {
            if (String.IsNullOrEmpty(_txtCharName.Text))
            {
                // Invalid
                _error.SetError(_txtCharName, "Title is required");
                e.Cancel = true;
            } else
                _error.SetError(_txtCharName, "");

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
        private int GetInt32( Control control, int defaultValue )
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

        private void Saving_Click ( object sender, EventArgs e )
        {
            string nam = _txtCharName.Text;
            string prof = _cbProfession.Text;
            string race = _cbRace.Text;
            string bio = _txtBiography.Text;
            int stren = Convert.ToInt32(_txtStrength.Text);
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

        
    }


}
