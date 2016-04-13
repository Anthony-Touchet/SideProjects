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
            this.LogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.Location = new System.Drawing.Point(12, 41);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(620, 372);
            this.LogBox.TabIndex = 0;
            this.LogBox.Text = "";
            this.LogBox.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 456);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(131, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Log";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveLog);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(501, 456);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(131, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load Log";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadLog);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.contactsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.Open_Log);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "Contacts";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.Open_Contacts);
            // 
            // saveContact
            // 
            this.saveContact.Location = new System.Drawing.Point(251, 176);
            this.saveContact.Name = "saveContact";
            this.saveContact.Size = new System.Drawing.Size(131, 23);
            this.saveContact.TabIndex = 4;
            this.saveContact.Text = "Save Contact";
            this.saveContact.UseVisualStyleBackColor = true;
            this.saveContact.Click += new System.EventHandler(this.Save_Contact);
            // 
            // contactName
            // 
            this.contactName.Location = new System.Drawing.Point(83, 133);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(168, 37);
            this.contactName.TabIndex = 5;
            this.contactName.Text = "";
            // 
            // contactNumber
            // 
            this.contactNumber.Location = new System.Drawing.Point(382, 133);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(168, 37);
            this.contactNumber.TabIndex = 6;
            this.contactNumber.Text = "";
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(251, 205);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(131, 23);
            this.addNumber.TabIndex = 7;
            this.addNumber.Text = "Add Number";
            this.addNumber.UseVisualStyleBackColor = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(382, 114);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(44, 13);
            this.numberLabel.TabIndex = 8;
            this.numberLabel.Text = "Number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(80, 114);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 491);
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

