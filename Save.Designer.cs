
namespace Passwords
{
    partial class Save
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Save));
            this.label1 = new System.Windows.Forms.Label();
            this.TbValue = new System.Windows.Forms.TextBox();
            this.TbEncrypt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TbSite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Значение:";
            // 
            // TbValue
            // 
            this.TbValue.Location = new System.Drawing.Point(166, 13);
            this.TbValue.Name = "TbValue";
            this.TbValue.Size = new System.Drawing.Size(264, 20);
            this.TbValue.TabIndex = 1;
            // 
            // TbEncrypt
            // 
            this.TbEncrypt.Location = new System.Drawing.Point(166, 39);
            this.TbEncrypt.Name = "TbEncrypt";
            this.TbEncrypt.Size = new System.Drawing.Size(264, 20);
            this.TbEncrypt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Зашифрованное значение:";
            // 
            // TbDecrypt
            // 
            this.TbDecrypt.BackColor = System.Drawing.SystemColors.Window;
            this.TbDecrypt.Location = new System.Drawing.Point(166, 65);
            this.TbDecrypt.Name = "TbDecrypt";
            this.TbDecrypt.ReadOnly = true;
            this.TbDecrypt.Size = new System.Drawing.Size(264, 20);
            this.TbDecrypt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Расшифрованное значение:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.FlatAppearance.BorderSize = 0;
            this.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecryptButton.Location = new System.Drawing.Point(337, 115);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(94, 23);
            this.DecryptButton.TabIndex = 6;
            this.DecryptButton.Text = "Расшифровать";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.FlatAppearance.BorderSize = 0;
            this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncryptButton.Location = new System.Drawing.Point(237, 115);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(94, 23);
            this.EncryptButton.TabIndex = 7;
            this.EncryptButton.Text = "Зашифровать";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Location = new System.Drawing.Point(137, 115);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(94, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TbSite);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TbValue);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TbEncrypt);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.TbDecrypt);
            this.panel1.Controls.Add(this.DecryptButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EncryptButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 150);
            this.panel1.TabIndex = 9;
            // 
            // TbSite
            // 
            this.TbSite.BackColor = System.Drawing.SystemColors.Window;
            this.TbSite.Location = new System.Drawing.Point(166, 89);
            this.TbSite.Name = "TbSite";
            this.TbSite.Size = new System.Drawing.Size(264, 20);
            this.TbSite.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Сайт\r\n";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.FormName);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(442, 32);
            this.HeaderPanel.TabIndex = 10;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(412, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.BackColor = System.Drawing.Color.Transparent;
            this.FormName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormName.ForeColor = System.Drawing.Color.White;
            this.FormName.Location = new System.Drawing.Point(3, 9);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(113, 16);
            this.FormName.TabIndex = 12;
            this.FormName.Text = "Save and encrypt";
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 181);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Save";
            this.Text = "Save";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label FormName;
        public System.Windows.Forms.TextBox TbValue;
        private System.Windows.Forms.TextBox TbSite;
        private System.Windows.Forms.Label label4;
    }
}