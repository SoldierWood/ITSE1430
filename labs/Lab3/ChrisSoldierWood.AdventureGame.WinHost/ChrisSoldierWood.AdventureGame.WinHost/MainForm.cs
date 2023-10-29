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

        //public class Character 
        //{
        //    public string CharacterName {  get; set; }
        //}

        private void MainForm_Load ( object sender, EventArgs e )
        {
            
            
            List<Character> CharacterList = new List<Character>();  
            Character curChar = new Character();
            charListBox1.DataSource = null;
            charListBox1.DataSource = CharacterList;

            CharacterList.Add(new Character() {
                Name = "Adam"
            });
            //curChar.Name = charListBox1.SelectedItem.ToString();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog(this);
        }
    }
}