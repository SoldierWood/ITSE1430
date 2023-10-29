// ITSE 1430 Fall 2023
// Adventure Game - Adding WinForms
// Written by Chris "Soldier" Wood
// 10-27-23

namespace ChrisSoldierWood.AdventureGame.WinHost
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            menuStrip1=new MenuStrip();
            toolStripMenuItem1=new ToolStripMenuItem();
            fileToolStripMenuItem=new ToolStripMenuItem();
            charactersToolStripMenuItem=new ToolStripMenuItem();
            addToolStripMenuItem=new ToolStripMenuItem();
            editToolStripMenuItem=new ToolStripMenuItem();
            viewToolStripMenuItem=new ToolStripMenuItem();
            deleteToolStripMenuItem=new ToolStripMenuItem();
            helpToolStripMenuItem=new ToolStripMenuItem();
            aboutToolStripMenuItem=new ToolStripMenuItem();
            charListBox1=new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, charactersToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(784, 24);
            menuStrip1.TabIndex=0;
            menuStrip1.Text="menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            toolStripMenuItem1.Name="toolStripMenuItem1";
            toolStripMenuItem1.Size=new Size(37, 20);
            toolStripMenuItem1.Text="&File";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name="fileToolStripMenuItem";
            fileToolStripMenuItem.ShortcutKeys=Keys.Alt|Keys.F4;
            fileToolStripMenuItem.Size=new Size(135, 22);
            fileToolStripMenuItem.Text="E&xit";
            fileToolStripMenuItem.Click+=OnFileExit;
            // 
            // charactersToolStripMenuItem
            // 
            charactersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, deleteToolStripMenuItem });
            charactersToolStripMenuItem.Name="charactersToolStripMenuItem";
            charactersToolStripMenuItem.Size=new Size(70, 20);
            charactersToolStripMenuItem.Text="&Character";
            charactersToolStripMenuItem.Click+=charactersToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name="addToolStripMenuItem";
            addToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.N;
            addToolStripMenuItem.Size=new Size(180, 22);
            addToolStripMenuItem.Text="&New";
            addToolStripMenuItem.Click+=OnAddCharacter;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name="editToolStripMenuItem";
            editToolStripMenuItem.Size=new Size(180, 22);
            editToolStripMenuItem.Text="&Edit";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name="viewToolStripMenuItem";
            viewToolStripMenuItem.Size=new Size(180, 22);
            viewToolStripMenuItem.Text="&View";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name="deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size=new Size(180, 22);
            deleteToolStripMenuItem.Text="&Delete";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name="helpToolStripMenuItem";
            helpToolStripMenuItem.Size=new Size(44, 20);
            helpToolStripMenuItem.Text="&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys=Keys.F1;
            aboutToolStripMenuItem.Size=new Size(126, 22);
            aboutToolStripMenuItem.Text="&About";
            aboutToolStripMenuItem.Click+=OnHelpAbout;
            // 
            // charListBox1
            // 
            charListBox1.Dock=DockStyle.Fill;
            charListBox1.FormattingEnabled=true;
            charListBox1.ItemHeight=15;
            charListBox1.Location=new Point(0, 24);
            charListBox1.Name="charListBox1";
            charListBox1.Size=new Size(784, 537);
            charListBox1.TabIndex=1;
            // 
            // MainForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(784, 561);
            Controls.Add(charListBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            MinimumSize=new Size(300, 200);
            Name="MainForm";
            Text="Chris Wood Adventure Game";
            Load+=MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem charactersToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox charListBox1;
    }
}