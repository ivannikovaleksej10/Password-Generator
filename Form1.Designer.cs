
namespace Passwords
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenButton = new System.Windows.Forms.Button();
            this.FormName = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.BackPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(418, -1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            // 
            // BackPanel
            // 
            this.BackPanel.BackColor = System.Drawing.Color.Transparent;
            this.BackPanel.Controls.Add(this.SaveButton);
            this.BackPanel.Controls.Add(this.SettingsButton);
            this.BackPanel.Controls.Add(this.CopyButton);
            this.BackPanel.Controls.Add(this.textBox1);
            this.BackPanel.Controls.Add(this.GenButton);
            this.BackPanel.Location = new System.Drawing.Point(0, 33);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(448, 78);
            this.BackPanel.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(409, 6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(27, 26);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "💾";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Location = new System.Drawing.Point(376, 6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(27, 26);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "⚙";
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.Transparent;
            this.CopyButton.FlatAppearance.BorderSize = 0;
            this.CopyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CopyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.CopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyButton.ForeColor = System.Drawing.Color.Black;
            this.CopyButton.Location = new System.Drawing.Point(343, 6);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(27, 26);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "✄";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(12, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 26);
            this.textBox1.TabIndex = 1;
            // 
            // GenButton
            // 
            this.GenButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GenButton.FlatAppearance.BorderSize = 0;
            this.GenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenButton.ForeColor = System.Drawing.Color.Black;
            this.GenButton.Location = new System.Drawing.Point(12, 38);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(424, 31);
            this.GenButton.TabIndex = 0;
            this.GenButton.Text = "Генерировать";
            this.GenButton.UseVisualStyleBackColor = false;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.BackColor = System.Drawing.Color.Transparent;
            this.FormName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormName.ForeColor = System.Drawing.Color.Black;
            this.FormName.Location = new System.Drawing.Point(9, 8);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(75, 16);
            this.FormName.TabIndex = 2;
            this.FormName.Text = "Passwords";
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Transparent;
            this.HeaderPanel.Controls.Add(this.CloseButton);
            this.HeaderPanel.Controls.Add(this.AboutButton);
            this.HeaderPanel.Controls.Add(this.FormName);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 1);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(448, 32);
            this.HeaderPanel.TabIndex = 2;
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(67)))), ((int)(((byte)(77)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutButton.ForeColor = System.Drawing.Color.Black;
            this.AboutButton.Location = new System.Drawing.Point(389, -1);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(30, 30);
            this.AboutButton.TabIndex = 3;
            this.AboutButton.Text = "?";
            this.AboutButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 112);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.Text = "Passwords";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

