using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Passwords
{
    public partial class Save : FormShadow
    {
        public Save()
        {
            InitializeComponent();

            CloseButton.Click += (s, a) => this.Close();

            FormPaint(Color.FromArgb(44, 57, 67), Color.FromArgb(35, 44, 55));

            new List<Control> { FormName, HeaderPanel }.ForEach(x =>
            {
                x.MouseDown += (s, a) =>
                {
                    x.Capture = false;
                    Capture = false;
                    Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    base.WndProc(ref m);
                };
            });

            new List<Control> { label1, label2, label3, label4 , SaveButton, EncryptButton, DecryptButton }.ForEach(x =>
            {
                x.ForeColor = Color.FromName("White");
                if (x.ToString().Contains("u"))
                {
                    x.BackColor = Color.FromArgb(44, 57, 67);
                }
            });

        }

        

        public void FormPaint(Color color1, Color color2)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(ClientRectangle, Color.Empty, Color.Empty, 90);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = new[] { 0, 0.195f, 0.195f, 1 } };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, ClientRectangle);
            }

            Paint -= OnPaintEventHandler;
            Paint += OnPaintEventHandler;

            Invalidate();
        }

        readonly string hash = "501ad03e7f7de4207cff7ba83d23330cfc0df4c6";

        void EncryptButton_Click(object sender, EventArgs e)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(TbValue.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    TbEncrypt.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        void DecryptButton_Click(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(TbEncrypt.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    TbDecrypt.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;

            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                if (TbSite.Text.Length > 0 && TbEncrypt.Text.Length > 0)
                {
                    saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
                    saveFileDialog1.Filter = "Encrypt Passwords (*.enps)|*.enps|All Files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 1;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string path = saveFileDialog1.FileName;
                        FileStream fs = new FileStream(path, FileMode.Append);
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            sw.WriteLine("Зашифрованный пароль: " + TbEncrypt.Text + " | Сайт: " + TbSite.Text + " | Дата:" + thisDay.ToString("D"));
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Зашифруйте пароль или введите значение в поле 'Сайт'.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
