using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords
{
    public partial class Settings : FormShadow
    {
        public Settings()
        {
            InitializeComponent();

            ToolTip t = new ToolTip();
            t.SetToolTip(CloseButton, "Закрыть");

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
        }

        public void FormPaint(Color color1, Color color2)
        {
            void OnPaintEventHandler(object s, PaintEventArgs a)
            {
                if (ClientRectangle == Rectangle.Empty)
                    return;

                var lgb = new LinearGradientBrush(ClientRectangle, Color.Empty, Color.Empty, 90);
                var cblend = new ColorBlend { Colors = new[] { color1, color1, color2, color2 }, Positions = new[] { 0, 0.21f, 0.21f, 1 } };

                lgb.InterpolationColors = cblend;
                a.Graphics.FillRectangle(lgb, ClientRectangle);
            }

            Paint -= OnPaintEventHandler;
            Paint += OnPaintEventHandler;

            Invalidate();
        }

        void GetSettings()
        {
            checkBox1.Checked = Properties.Settings.Default.SpecChar;
            checkBox2.Checked = Properties.Settings.Default.Numbers;
            checkBox3.Checked = Properties.Settings.Default.CapLetters;
            numericUpDown1.Value = Properties.Settings.Default.PassLength;
        }

        void SaveSettings()
        {
            Properties.Settings.Default.SpecChar = checkBox1.Checked;
            Properties.Settings.Default.Numbers = checkBox2.Checked;
            Properties.Settings.Default.CapLetters = checkBox3.Checked;
            Properties.Settings.Default.PassLength = numericUpDown1.Value;

            Properties.Settings.Default.Save();
        }

        void Settings_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
    }
}
