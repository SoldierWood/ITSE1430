using ChrisWood.AdventureGame;

using System.Numerics;


namespace ChrisSoldierWood.AdventureGame.WinHost
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent();

        }

        private void charactersToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            string message = "Are you sure you want to exit the program?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Close();
            }

        }

        private void OnListBoxClick (object sender, EventArgs e)
        {
            charListBox1.DataSource = null;
            charListBox1.DataSource = Character.CharacterRoster;
        }



        private void MainForm_Load ( object sender, EventArgs e )
        {


            
            charListBox1.DataSource = null;
            charListBox1.DataSource = Character.CharacterRoster;
            charListBox1.Refresh();
           
            Refresh();

        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog(this);
        }

        private void OnAddCharacter ( object sender, EventArgs e )
        {
            
            var form = new NewCharForm();
            form.mForm = this;
            //form.ShowDialog(this);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // returns DialogResult
            }



        }

        private void fileToolStripMenuItem_Click ( object sender, EventArgs e )
        {

        }

        private void MainForm_Load_1 ( object sender, EventArgs e )
        {

            charListBox1.DataSource = null;
            charListBox1.DataSource = Character.CharacterRoster;
        }

        private void OnEditMovie ( object sender, EventArgs e )
        {
            var currentChar = GetSelectedCharacter();

           // if (currentChar == null)
           //     return;

           
            var form = new NewCharForm();
            form.Text = "Edit Character";
            form.mForm = this;

            form.SetCharNameBox(currentChar.Name);
            form.SetProfessionCBox(currentChar.Profession);
            form.SetRaceCBox(currentChar.Race);
            form.SetBioBox(currentChar.Bio);
            form.SetStrengthBox(currentChar.Strength);
            form.SetIntelligenceBox(currentChar.Intelligence);
            form.SetAgilityBox(currentChar.Agility);
            form.SetConstitutionBox(currentChar.Constitution);
            form.SetCharismaBox(currentChar.Charisma);

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                // returns DialogResult
               
            }


        }

        private Character GetSelectedCharacter()
        {
            return charListBox1.SelectedItem as Character;
        }

        public void ListRefresh()
        {
            charListBox1.DataSource = null;
            charListBox1.DataSource = Character.CharacterRoster;
        }
    }
}