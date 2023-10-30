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
            components=new System.ComponentModel.Container();
            _txtName=new TextBox();
            label1=new Label();
            _error=new ErrorProvider(components);
            _txtCharName=new TextBox();
            label2=new Label();
            _cbProfession=new ComboBox();
            label3=new Label();
            ((System.ComponentModel.ISupportInitialize)_error).BeginInit();
            SuspendLayout();
            // 
            // _txtName
            // 
            _txtName.Location=new Point(122, 29);
            _txtName.Name="_txtName";
            _txtName.Size=new Size(100, 23);
            _txtName.TabIndex=0;
            // 
            // label1
            // 
            label1.Location=new Point(0, 0);
            label1.Name="label1";
            label1.Size=new Size(100, 23);
            label1.TabIndex=0;
            // 
            // _error
            // 
            _error.ContainerControl=this;
            // 
            // _txtCharName
            // 
            _txtCharName.Location=new Point(118, 12);
            _txtCharName.Name="_txtCharName";
            _txtCharName.Size=new Size(100, 23);
            _txtCharName.TabIndex=0;
            _txtCharName.Validating+=OnValidateName;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(73, 15);
            label2.Name="label2";
            label2.Size=new Size(39, 15);
            label2.TabIndex=1;
            label2.Text="Name";
            // 
            // _cbProfession
            // 
            _cbProfession.DropDownStyle=ComboBoxStyle.DropDownList;
            _cbProfession.FormattingEnabled=true;
            _cbProfession.Items.AddRange(new object[] { "Fighter", "Hunter", "Priest", "Rogue", "Wizard" });
            _cbProfession.Location=new Point(118, 60);
            _cbProfession.Name="_cbProfession";
            _cbProfession.Size=new Size(121, 23);
            _cbProfession.TabIndex=2;
            _cbProfession.Validating+=OnValidateProfession;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(50, 63);
            label3.Name="label3";
            label3.Size=new Size(62, 15);
            label3.TabIndex=3;
            label3.Text="Profession";
            // 
            // NewCharForm
            // 
            ClientSize=new Size(610, 432);
            Controls.Add(label3);
            Controls.Add(_cbProfession);
            Controls.Add(label2);
            Controls.Add(_txtCharName);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            Name="NewCharForm";
            StartPosition=FormStartPosition.CenterParent;
            Text="Create New Character";
            ((System.ComponentModel.ISupportInitialize)_error).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox _txtName;
        private Label label1;
        private ErrorProvider _error;
        private Label label2;
        private TextBox _txtCharName;
        private Label label3;
        private ComboBox _cbProfession;
    }
}