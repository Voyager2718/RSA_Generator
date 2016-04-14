namespace RSA_Generator
{
    partial class Form1
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
            this.privateKey = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.keySize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.publicKey = new System.Windows.Forms.RichTextBox();
            this.toEncrypt = new System.Windows.Forms.RichTextBox();
            this.encrypted = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.generateKey = new System.Windows.Forms.Button();
            this.encryptDecrypt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRSA = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSoftware = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // privateKey
            // 
            this.privateKey.Location = new System.Drawing.Point(17, 94);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(348, 163);
            this.privateKey.TabIndex = 0;
            this.privateKey.Text = "";
            // 
            // keySize
            // 
            this.keySize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keySize.FormattingEnabled = true;
            this.keySize.Items.AddRange(new object[] {
            "512 Bit (Not recommended)",
            "1024 Bit (Not recommended)",
            "2048 Bit",
            "4096 Bit",
            "8192 Bit"});
            this.keySize.Location = new System.Drawing.Point(83, 34);
            this.keySize.Name = "keySize";
            this.keySize.Size = new System.Drawing.Size(283, 24);
            this.keySize.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Key Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Public Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Text to encrypt";
            // 
            // publicKey
            // 
            this.publicKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publicKey.Location = new System.Drawing.Point(371, 94);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(350, 163);
            this.publicKey.TabIndex = 6;
            this.publicKey.Text = "";
            // 
            // toEncrypt
            // 
            this.toEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.toEncrypt.Location = new System.Drawing.Point(13, 317);
            this.toEncrypt.Name = "toEncrypt";
            this.toEncrypt.Size = new System.Drawing.Size(352, 188);
            this.toEncrypt.TabIndex = 7;
            this.toEncrypt.Text = "";
            // 
            // encrypted
            // 
            this.encrypted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encrypted.Location = new System.Drawing.Point(370, 317);
            this.encrypted.Name = "encrypted";
            this.encrypted.Size = new System.Drawing.Size(351, 188);
            this.encrypted.TabIndex = 8;
            this.encrypted.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Text encrypted";
            // 
            // generateKey
            // 
            this.generateKey.Location = new System.Drawing.Point(17, 263);
            this.generateKey.Name = "generateKey";
            this.generateKey.Size = new System.Drawing.Size(160, 30);
            this.generateKey.TabIndex = 10;
            this.generateKey.Text = "Generate Key";
            this.generateKey.UseVisualStyleBackColor = true;
            // 
            // encryptDecrypt
            // 
            this.encryptDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.encryptDecrypt.Location = new System.Drawing.Point(13, 511);
            this.encryptDecrypt.MaximumSize = new System.Drawing.Size(160, 30);
            this.encryptDecrypt.MinimumSize = new System.Drawing.Size(160, 30);
            this.encryptDecrypt.Name = "encryptDecrypt";
            this.encryptDecrypt.Size = new System.Drawing.Size(160, 30);
            this.encryptDecrypt.TabIndex = 11;
            this.encryptDecrypt.Text = "Encrypt / Decrypt";
            this.encryptDecrypt.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutRSA,
            this.aboutSecurity,
            this.aboutSoftware});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutRSA
            // 
            this.aboutRSA.Name = "aboutRSA";
            this.aboutRSA.Size = new System.Drawing.Size(181, 26);
            this.aboutRSA.Text = "About RSA";
            // 
            // aboutSecurity
            // 
            this.aboutSecurity.Name = "aboutSecurity";
            this.aboutSecurity.Size = new System.Drawing.Size(181, 26);
            this.aboutSecurity.Text = "About security";
            // 
            // aboutSoftware
            // 
            this.aboutSoftware.Name = "aboutSoftware";
            this.aboutSoftware.Size = new System.Drawing.Size(226, 26);
            this.aboutSoftware.Text = "About RSA Generator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 553);
            this.Controls.Add(this.encryptDecrypt);
            this.Controls.Add(this.generateKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.encrypted);
            this.Controls.Add(this.toEncrypt);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keySize);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "Form1";
            this.Text = "RSA Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox privateKey;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox keySize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox publicKey;
        private System.Windows.Forms.RichTextBox toEncrypt;
        private System.Windows.Forms.RichTextBox encrypted;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button generateKey;
        private System.Windows.Forms.Button encryptDecrypt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRSA;
        private System.Windows.Forms.ToolStripMenuItem aboutSecurity;
        private System.Windows.Forms.ToolStripMenuItem aboutSoftware;
    }
}

