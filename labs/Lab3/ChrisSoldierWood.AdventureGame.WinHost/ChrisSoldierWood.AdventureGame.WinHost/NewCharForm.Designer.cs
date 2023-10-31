namespace ChrisSoldierWood.AdventureGame.WinHost
{
    partial class NewCharForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container();
            this._txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._error = new System.Windows.Forms.ErrorProvider(this.components);
            this._txtCharName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._cbProfession = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._cbRace = new System.Windows.Forms.ComboBox();
            this._txtBiography = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Saving = new System.Windows.Forms.Button();
            this._txtStrength = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._txtIntelligence = new System.Windows.Forms.TextBox();
            this._txtAgility = new System.Windows.Forms.TextBox();
            this._txtConstitution = new System.Windows.Forms.TextBox();
            this._txtCharisma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._error)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtName
            // 
            this._txtName.Location = new System.Drawing.Point(122, 29);
            this._txtName.Name = "_txtName";
            this._txtName.Size = new System.Drawing.Size(100, 23);
            this._txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // _error
            // 
            this._error.ContainerControl = this;
            // 
            // _txtCharName
            // 
            this._txtCharName.Location = new System.Drawing.Point(139, 6);
            this._txtCharName.Name = "_txtCharName";
            this._txtCharName.Size = new System.Drawing.Size(149, 23);
            this._txtCharName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // _cbProfession
            // 
            this._cbProfession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbProfession.FormattingEnabled = true;
            this._cbProfession.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this._cbProfession.Location = new System.Drawing.Point(139, 45);
            this._cbProfession.Name = "_cbProfession";
            this._cbProfession.Size = new System.Drawing.Size(121, 23);
            this._cbProfession.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Profession";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Race";
            // 
            // _cbRace
            // 
            this._cbRace.FormattingEnabled = true;
            this._cbRace.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this._cbRace.Location = new System.Drawing.Point(139, 79);
            this._cbRace.Name = "_cbRace";
            this._cbRace.Size = new System.Drawing.Size(121, 23);
            this._cbRace.TabIndex = 5;
            // 
            // _txtBiography
            // 
            this._txtBiography.Location = new System.Drawing.Point(139, 117);
            this._txtBiography.Multiline = true;
            this._txtBiography.Name = "_txtBiography";
            this._txtBiography.Size = new System.Drawing.Size(149, 71);
            this._txtBiography.TabIndex = 6;
            this._txtBiography.TextChanged += new System.EventHandler(this._txtBiography_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Biography (optional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Strength";
            // 
            // Saving
            // 
            this.Saving.Location = new System.Drawing.Point(310, 384);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(75, 23);
            this.Saving.TabIndex = 12;
            this.Saving.Text = "Save";
            this.Saving.UseVisualStyleBackColor = true;
            // 
            // _txtStrength
            // 
            this._txtStrength.Location = new System.Drawing.Point(156, 203);
            this._txtStrength.Name = "_txtStrength";
            this._txtStrength.Size = new System.Drawing.Size(100, 23);
            this._txtStrength.TabIndex = 13;
            this._txtStrength.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateStrength);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Intelligence";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Agility";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Constitution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Charisma";
            // 
            // _txtIntelligence
            // 
            this._txtIntelligence.Location = new System.Drawing.Point(156, 249);
            this._txtIntelligence.Name = "_txtIntelligence";
            this._txtIntelligence.Size = new System.Drawing.Size(100, 23);
            this._txtIntelligence.TabIndex = 18;
            this._txtIntelligence.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateIntelligence);
            // 
            // _txtAgility
            // 
            this._txtAgility.Location = new System.Drawing.Point(156, 286);
            this._txtAgility.Name = "_txtAgility";
            this._txtAgility.Size = new System.Drawing.Size(100, 23);
            this._txtAgility.TabIndex = 19;
            this._txtAgility.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAgility);
            // 
            // _txtConstitution
            // 
            this._txtConstitution.Location = new System.Drawing.Point(156, 317);
            this._txtConstitution.Name = "_txtConstitution";
            this._txtConstitution.Size = new System.Drawing.Size(100, 23);
            this._txtConstitution.TabIndex = 20;
            this._txtConstitution.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateConstitution);
            // 
            // _txtCharisma
            // 
            this._txtCharisma.Location = new System.Drawing.Point(155, 353);
            this._txtCharisma.Name = "_txtCharisma";
            this._txtCharisma.Size = new System.Drawing.Size(100, 23);
            this._txtCharisma.TabIndex = 21;
            this._txtCharisma.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateCharisma);
            // 
            // NewCharForm
            // 
            this.ClientSize = new System.Drawing.Size(610, 432);
            this.Controls.Add(this._txtCharisma);
            this.Controls.Add(this._txtConstitution);
            this.Controls.Add(this._txtAgility);
            this.Controls.Add(this._txtIntelligence);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtStrength);
            this.Controls.Add(this.Saving);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtBiography);
            this.Controls.Add(this._cbRace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._cbProfession);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtCharName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewCharForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            ((System.ComponentModel.ISupportInitialize)(this._error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox _txtName;
        private Label label1;
        private ErrorProvider _error;
        private Label label2;
        private TextBox _txtCharName;
        private Label label3;
        private ComboBox _cbProfession;
        private ComboBox _cbRace;
        private Label label4;
        private Label label5;
        private TextBox _txtBiography;
        private Label label6;
        private Button Saving;
        private TextBox _txtStrength;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox _txtIntelligence;
        private TextBox _txtAgility;
        private TextBox _txtConstitution;
        private TextBox _txtCharisma;
    }
}