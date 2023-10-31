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


            //List<Character> CharacterList = new List<Character>();
            //Character curChar = new Character();
            charListBox1.DataSource = null;
            charListBox1.DataSource = Character.CharacterRoster;

            //CharacterList.Add(new Character() {
            //    Name = "Adam"
            //});
            //curChar.Name = charListBox1.SelectedItem.ToString();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog(this);
        }

        private void OnAddCharacter ( object sender, EventArgs e )
        {
            
            var form = new NewCharForm();
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
    }
}