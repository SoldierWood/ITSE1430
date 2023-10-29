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

        private void MainForm_Load ( object sender, EventArgs e )
        {
            //    AboutBox1 a = new AboutBox1();
            //    a.Show();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox1();
            about.ShowDialog(this);
        }
    }
}