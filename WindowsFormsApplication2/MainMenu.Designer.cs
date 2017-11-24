namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            this.logOffBut = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.dObLabel = new System.Windows.Forms.Label();
            this.dObRegLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.iDtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.dObtextBox = new System.Windows.Forms.TextBox();
            this.addressRegtextBox = new System.Windows.Forms.TextBox();
            this.dObRegtextBox = new System.Windows.Forms.TextBox();
            this.sNametextBox = new System.Windows.Forms.TextBox();
            this.fNametextBox = new System.Windows.Forms.TextBox();
            this.addressReglabel = new System.Windows.Forms.Label();
            this.confirmSearchbutton = new System.Windows.Forms.Button();
            this.confirmRegButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOffBut
            // 
            this.logOffBut.Location = new System.Drawing.Point(1233, 15);
            this.logOffBut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logOffBut.Name = "logOffBut";
            this.logOffBut.Size = new System.Drawing.Size(100, 28);
            this.logOffBut.TabIndex = 0;
            this.logOffBut.Text = "Log Off";
            this.logOffBut.UseVisualStyleBackColor = true;
            this.logOffBut.Click += new System.EventHandler(this.logOffBut_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(315, 156);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(53, 17);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(1007, 156);
            this.registerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(61, 17);
            this.registerLabel.TabIndex = 2;
            this.registerLabel.Text = "Register";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(541, 15);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(317, 31);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Oval Surgery Database";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(129, 242);
            this.idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 17);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(129, 292);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(129, 338);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Address";
            // 
            // dObLabel
            // 
            this.dObLabel.AutoSize = true;
            this.dObLabel.Location = new System.Drawing.Point(129, 385);
            this.dObLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dObLabel.Name = "dObLabel";
            this.dObLabel.Size = new System.Drawing.Size(90, 17);
            this.dObLabel.TabIndex = 7;
            this.dObLabel.Text = "Date Of Birth";
            // 
            // dObRegLabel
            // 
            this.dObRegLabel.AutoSize = true;
            this.dObRegLabel.Location = new System.Drawing.Point(833, 338);
            this.dObRegLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dObRegLabel.Name = "dObRegLabel";
            this.dObRegLabel.Size = new System.Drawing.Size(86, 17);
            this.dObRegLabel.TabIndex = 10;
            this.dObRegLabel.Text = "Date of brith";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(833, 292);
            this.surnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(65, 17);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Surname";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(833, 242);
            this.fnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(76, 17);
            this.fnameLabel.TabIndex = 12;
            this.fnameLabel.Text = "First Name";
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Location = new System.Drawing.Point(16, 238);
            this.radioButtonID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(17, 16);
            this.radioButtonID.TabIndex = 13;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.UseVisualStyleBackColor = true;
            this.radioButtonID.CheckedChanged += new System.EventHandler(this.radioButtonID_CheckedChanged);
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Location = new System.Drawing.Point(16, 292);
            this.radioButtonName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(17, 16);
            this.radioButtonName.TabIndex = 14;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.UseVisualStyleBackColor = true;
            // 
            // iDtextBox
            // 
            this.iDtextBox.Location = new System.Drawing.Point(319, 233);
            this.iDtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iDtextBox.Name = "iDtextBox";
            this.iDtextBox.Size = new System.Drawing.Size(132, 22);
            this.iDtextBox.TabIndex = 15;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(319, 283);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(132, 22);
            this.nametextBox.TabIndex = 16;
            // this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // addresstextBox
            // 
            this.addresstextBox.Location = new System.Drawing.Point(319, 326);
            this.addresstextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(132, 22);
            this.addresstextBox.TabIndex = 17;
            // 
            // dObtextBox
            // 
            this.dObtextBox.Location = new System.Drawing.Point(319, 375);
            this.dObtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dObtextBox.Name = "dObtextBox";
            this.dObtextBox.Size = new System.Drawing.Size(132, 22);
            this.dObtextBox.TabIndex = 18;
            // 
            // addressRegtextBox
            // 
            this.addressRegtextBox.Location = new System.Drawing.Point(979, 377);
            this.addressRegtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressRegtextBox.Name = "addressRegtextBox";
            this.addressRegtextBox.Size = new System.Drawing.Size(132, 22);
            this.addressRegtextBox.TabIndex = 22;
            // 
            // dObRegtextBox
            // 
            this.dObRegtextBox.Location = new System.Drawing.Point(979, 327);
            this.dObRegtextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dObRegtextBox.Name = "dObRegtextBox";
            this.dObRegtextBox.Size = new System.Drawing.Size(132, 22);
            this.dObRegtextBox.TabIndex = 21;
            // 
            // sNametextBox
            // 
            this.sNametextBox.Location = new System.Drawing.Point(979, 283);
            this.sNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sNametextBox.Name = "sNametextBox";
            this.sNametextBox.Size = new System.Drawing.Size(132, 22);
            this.sNametextBox.TabIndex = 20;
            // 
            // fNametextBox
            // 
            this.fNametextBox.Location = new System.Drawing.Point(979, 234);
            this.fNametextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fNametextBox.Name = "fNametextBox";
            this.fNametextBox.Size = new System.Drawing.Size(132, 22);
            this.fNametextBox.TabIndex = 19;
            // 
            // addressReglabel
            // 
            this.addressReglabel.AutoSize = true;
            this.addressReglabel.Location = new System.Drawing.Point(833, 385);
            this.addressReglabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressReglabel.Name = "addressReglabel";
            this.addressReglabel.Size = new System.Drawing.Size(60, 17);
            this.addressReglabel.TabIndex = 11;
            this.addressReglabel.Text = "Address";
            // 
            // confirmSearchbutton
            // 
            this.confirmSearchbutton.Location = new System.Drawing.Point(268, 474);
            this.confirmSearchbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmSearchbutton.Name = "confirmSearchbutton";
            this.confirmSearchbutton.Size = new System.Drawing.Size(100, 28);
            this.confirmSearchbutton.TabIndex = 23;
            this.confirmSearchbutton.Text = "Confirm";
            this.confirmSearchbutton.UseVisualStyleBackColor = true;
            this.confirmSearchbutton.Click += new System.EventHandler(this.confirmSearchbutton_Click);
            // 
            // confirmRegButton
            // 
            this.confirmRegButton.Location = new System.Drawing.Point(936, 474);
            this.confirmRegButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmRegButton.Name = "confirmRegButton";
            this.confirmRegButton.Size = new System.Drawing.Size(100, 28);
            this.confirmRegButton.TabIndex = 24;
            this.confirmRegButton.Text = "Confirm";
            this.confirmRegButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1073, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Register New User";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CalendarButton
            // 
            this.CalendarButton.Location = new System.Drawing.Point(35, 16);
            this.CalendarButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(100, 28);
            this.CalendarButton.TabIndex = 26;
            this.CalendarButton.Text = "Calendar";
            this.CalendarButton.UseVisualStyleBackColor = true;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1349, 609);
            this.Controls.Add(this.CalendarButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmRegButton);
            this.Controls.Add(this.confirmSearchbutton);
            this.Controls.Add(this.addressRegtextBox);
            this.Controls.Add(this.dObRegtextBox);
            this.Controls.Add(this.sNametextBox);
            this.Controls.Add(this.fNametextBox);
            this.Controls.Add(this.dObtextBox);
            this.Controls.Add(this.addresstextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.iDtextBox);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.addressReglabel);
            this.Controls.Add(this.dObRegLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.dObLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.logOffBut);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Over Surgery Software";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOffBut;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label dObLabel;
        private System.Windows.Forms.Label dObRegLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.RadioButton radioButtonID;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.TextBox iDtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.TextBox dObtextBox;
        private System.Windows.Forms.TextBox addressRegtextBox;
        private System.Windows.Forms.TextBox dObRegtextBox;
        private System.Windows.Forms.TextBox sNametextBox;
        private System.Windows.Forms.TextBox fNametextBox;
        private System.Windows.Forms.Label addressReglabel;
        private System.Windows.Forms.Button confirmSearchbutton;
        private System.Windows.Forms.Button confirmRegButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CalendarButton;
    }
}

