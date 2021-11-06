using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords
{
    public partial class MainForm : FormShadow
    {
        readonly Settings settings = new Settings();
        public MainForm()
        {
            InitializeComponent();

            async void Exit() { for (Opacity = 1; Opacity > .0; Opacity -= .2) await Task.Delay(7); Close(); }
            CloseButton.Click += (s, a) => Exit();

            CloseButton.Click += (s, a) => Close();

            AboutButton.Click += (s, a) =>
            {
                AboutBox About = new AboutBox();
                About.ShowDialog();
            };

            SaveButton.Click += (s, a) =>
            {
                Save save = new Save();
                save.TbValue.Text = (textBox1.Text);
                save.ShowDialog();
            };

            SettingsButton.Click += (s, a) => settings.ShowDialog();

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

            new List<Control> { FormName, AboutButton, CloseButton, GenButton }.ForEach(x =>
            {
                x.ForeColor = Color.FromName("White");

                if (x.ToString().Contains("Button"))
                {
                    x.BackColor = Color.FromArgb(44, 57, 67);    
                }
            
            });

            textBox1.ForeColor = Color.FromName("White"); textBox1.BackColor = Color.FromArgb(54, 67, 77);

            new List<Control> { SaveButton, CopyButton, SettingsButton }.ForEach(x =>
            {
                x.ForeColor = Color.FromName("White");
                x.BackColor = Color.FromName("Transparent");
            });

            ToolTip t = new ToolTip();
            t.SetToolTip(CopyButton, "Копировать");
            t.SetToolTip(SettingsButton, "Настройки");
            t.SetToolTip(CloseButton, "Закрыть");
            t.SetToolTip(AboutButton, "О программе...");
            t.SetToolTip(SaveButton, "Сохранить и зашифровать");

        }

        async void MainForm_Load(object sender, EventArgs e)
        {
            for (Opacity = 0; Opacity < .97; Opacity += 0.2) await Task.Delay(10);
        }

        public void FormPaint(Color color1, Color color2)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(ClientRectangle, Color.Empty, Color.Empty, 90);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = new[] { 0, 0.27f, 0.27f, 1 } };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, ClientRectangle);
            }

            Paint -= OnPaintEventHandler;
            Paint += OnPaintEventHandler;

            Invalidate();
        }

        void GenButton_Click(object sender, EventArgs e)
        {
            string abc = "qwertyuiopasdfghjklzxcvbnm";
            if (settings.checkBox1.Checked == true)//использовать спецсимволы
            {
                abc += "!@#$%^&*()";
            }
            if (settings.checkBox2.Checked == true)//юзать цифры
            {
                abc += "123456789";
            }
            if (settings.checkBox3.Checked == true)//использовать заглавные
            {
                abc += "QWERTYUIOPASDFGHJKLZXCVBNM";
            }

            int kol = (int)settings.numericUpDown1.Value; // кол-во символов
            string result = "";

            Random rnd = new Random();
            int lng = abc.Length;
            for (int i = 0; i < kol; i++)
                result += abc[rnd.Next(lng)];
            textBox1.Text = result;
        }

        void CopyButton_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength == 0)
            {
                // MessageBox.Show("Вы пытаетесь скопировать пустую строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Clipboard.SetText(textBox1.Text);
            }
        }
    }
}
