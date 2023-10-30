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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this._txtCharName.Location = new System.Drawing.Point(118, 12);
            this._txtCharName.Name = "_txtCharName";
            this._txtCharName.Size = new System.Drawing.Size(100, 23);
            this._txtCharName.TabIndex = 0;
            this._txtCharName.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(118, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Profession";
            // 
            // NewCharForm
            // 
            this.ClientSize = new System.Drawing.Size(610, 432);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
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
        private ComboBox comboBox1;
    }
}