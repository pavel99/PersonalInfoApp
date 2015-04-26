namespace PersonalInfoApp
{
    partial class PersonalInformationAppUI
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
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNamelabel = new System.Windows.Forms.Label();
            this.motherNameLabel = new System.Windows.Forms.Label();
            this.motherNameTextBox = new System.Windows.Forms.TextBox();
            this.adrressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.saveInfoButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.showNameButton = new System.Windows.Forms.Button();
            this.showParentsNameButton = new System.Windows.Forms.Button();
            this.showAddressButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(120, 47);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(48, 47);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(48, 73);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(120, 73);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(120, 99);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.fatherNameTextBox.TabIndex = 4;
            // 
            // fatherNamelabel
            // 
            this.fatherNamelabel.AutoSize = true;
            this.fatherNamelabel.Location = new System.Drawing.Point(30, 99);
            this.fatherNamelabel.Name = "fatherNamelabel";
            this.fatherNamelabel.Size = new System.Drawing.Size(75, 13);
            this.fatherNamelabel.TabIndex = 5;
            this.fatherNamelabel.Text = "Father\'s Name";
            // 
            // motherNameLabel
            // 
            this.motherNameLabel.AutoSize = true;
            this.motherNameLabel.Location = new System.Drawing.Point(33, 125);
            this.motherNameLabel.Name = "motherNameLabel";
            this.motherNameLabel.Size = new System.Drawing.Size(78, 13);
            this.motherNameLabel.TabIndex = 6;
            this.motherNameLabel.Text = "Mother\'s Name";
            // 
            // motherNameTextBox
            // 
            this.motherNameTextBox.Location = new System.Drawing.Point(120, 125);
            this.motherNameTextBox.Name = "motherNameTextBox";
            this.motherNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.motherNameTextBox.TabIndex = 7;
            // 
            // adrressTextBox
            // 
            this.adrressTextBox.Location = new System.Drawing.Point(120, 151);
            this.adrressTextBox.Multiline = true;
            this.adrressTextBox.Name = "adrressTextBox";
            this.adrressTextBox.Size = new System.Drawing.Size(146, 63);
            this.adrressTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(48, 151);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // saveInfoButton
            // 
            this.saveInfoButton.Location = new System.Drawing.Point(36, 229);
            this.saveInfoButton.Name = "saveInfoButton";
            this.saveInfoButton.Size = new System.Drawing.Size(75, 23);
            this.saveInfoButton.TabIndex = 11;
            this.saveInfoButton.Text = "Save";
            this.saveInfoButton.UseVisualStyleBackColor = true;
            this.saveInfoButton.Click += new System.EventHandler(this.saveInfoButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(120, 229);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(124, 23);
            this.showInfoButton.TabIndex = 12;
            this.showInfoButton.Text = "Show All Information";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // showNameButton
            // 
            this.showNameButton.Location = new System.Drawing.Point(36, 259);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(75, 23);
            this.showNameButton.TabIndex = 13;
            this.showNameButton.Text = "Name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // showParentsNameButton
            // 
            this.showParentsNameButton.Location = new System.Drawing.Point(120, 259);
            this.showParentsNameButton.Name = "showParentsNameButton";
            this.showParentsNameButton.Size = new System.Drawing.Size(105, 23);
            this.showParentsNameButton.TabIndex = 14;
            this.showParentsNameButton.Text = "Parent\'s Name\r\n";
            this.showParentsNameButton.UseVisualStyleBackColor = true;
            this.showParentsNameButton.Click += new System.EventHandler(this.showParentsNameButton_Click);
            // 
            // showAddressButton
            // 
            this.showAddressButton.Location = new System.Drawing.Point(231, 259);
            this.showAddressButton.Name = "showAddressButton";
            this.showAddressButton.Size = new System.Drawing.Size(75, 23);
            this.showAddressButton.TabIndex = 15;
            this.showAddressButton.Text = "Address";
            this.showAddressButton.UseVisualStyleBackColor = true;
            this.showAddressButton.Click += new System.EventHandler(this.showAddressButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Location = new System.Drawing.Point(122, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(103, 13);
            this.headerLabel.TabIndex = 16;
            this.headerLabel.Text = "Personal Information";
            // 
            // PersonalInformationAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 332);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.showAddressButton);
            this.Controls.Add(this.showParentsNameButton);
            this.Controls.Add(this.showNameButton);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.saveInfoButton);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.adrressTextBox);
            this.Controls.Add(this.motherNameTextBox);
            this.Controls.Add(this.motherNameLabel);
            this.Controls.Add(this.fatherNamelabel);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "PersonalInformationAppUI";
            this.Text = "PersonalInfoAppUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.Label fatherNamelabel;
        private System.Windows.Forms.Label motherNameLabel;
        private System.Windows.Forms.TextBox motherNameTextBox;
        private System.Windows.Forms.TextBox adrressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button saveInfoButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button showParentsNameButton;
        private System.Windows.Forms.Button showAddressButton;
        private System.Windows.Forms.Label headerLabel;
    }
}

