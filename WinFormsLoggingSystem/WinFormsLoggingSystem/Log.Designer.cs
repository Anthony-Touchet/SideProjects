namespace WinFormsLoggingSystem
{
    partial class Log
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
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveContact = new System.Windows.Forms.Button();
            this.contactName = new System.Windows.Forms.RichTextBox();
            this.contactNumber = new System.Windows.Forms.RichTextBox();
            this.addNumber = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.Black;
            this.LogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.ForeColor = System.Drawing.Color.Red;
            this.LogBox.Location = new System.Drawing.Point(16, 50);
            this.LogBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(825, 457);
            this.LogBox.TabIndex = 0;
            this.LogBox.Text = "";
            this.LogBox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(16, 561);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 28);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Log";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveLog);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(668, 561);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(175, 28);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Log";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadLog);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.contactsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(864, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.Open_Log);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.contactsToolStripMenuItem.Text = "Contacts";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.Open_Contacts);
            // 
            // saveContact
            // 
            this.saveContact.Location = new System.Drawing.Point(335, 217);
            this.saveContact.Margin = new System.Windows.Forms.Padding(4);
            this.saveContact.Name = "saveContact";
            this.saveContact.Size = new System.Drawing.Size(175, 28);
            this.saveContact.TabIndex = 4;
            this.saveContact.Text = "Save Contact";
            this.saveContact.UseVisualStyleBackColor = true;
            this.saveContact.Click += new System.EventHandler(this.Save_Contact);
            // 
            // contactName
            // 
            this.contactName.Location = new System.Drawing.Point(111, 164);
            this.contactName.Margin = new System.Windows.Forms.Padding(4);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(223, 45);
            this.contactName.TabIndex = 5;
            this.contactName.Tag = "";
            this.contactName.Text = "";
            // 
            // contactNumber
            // 
            this.contactNumber.Location = new System.Drawing.Point(509, 164);
            this.contactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(223, 45);
            this.contactNumber.TabIndex = 6;
            this.contactNumber.Text = "";
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(335, 252);
            this.addNumber.Margin = new System.Windows.Forms.Padding(4);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(175, 28);
            this.addNumber.TabIndex = 7;
            this.addNumber.Text = "Add Number";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.Add_Number);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(509, 140);
            this.numberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(58, 17);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(107, 140);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 604);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.addNumber);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.saveContact);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Log";
            this.Text = "Log";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.Button saveContact;
        private System.Windows.Forms.RichTextBox contactName;
        private System.Windows.Forms.RichTextBox contactNumber;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}

