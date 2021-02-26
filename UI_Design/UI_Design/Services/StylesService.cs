using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class StylesService
    {
        public static void ViewClickButton(object sender, Panel senderPanel)
        {
            Button senderBtn = sender as Button;// приводим полученный объект к типу Button
            senderPanel.Height = senderBtn.Height;
            senderPanel.Top = senderBtn.Top;
            senderPanel.Left = senderBtn.Left;
            senderBtn.BackColor = Color.FromArgb(46, 51, 73);
        }
        public static void CreateForm(Form form, Panel senderPanel, Label senderLable, string titleForm)
        {
            senderLable.Text = titleForm;
            senderPanel.Controls.Clear();

            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            senderPanel.Controls.Add(form);
            senderPanel.BackColor = Color.FromArgb(46, 51, 73);
            form.Show();
        }

        public static void ViewBackColorButton(object sender)
        {
            Button senderBtn = sender as Button;
            senderBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        public static void ViewEyePassTrue(object senderButton, TextBox txtPass, TextBox txtPassCheck, EventHandler visiblePassTrue, EventHandler visiblePassFalse)
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '\0';
            txtPassCheck.PasswordChar = '\0';
            senderBtn.BackgroundImage = Properties.Resources.eye_60px;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassTrue);
            senderBtn.Click += new EventHandler(visiblePassFalse);
        }
        public static void ViewEyePassTrue(object senderButton, TextBox txtPass, EventHandler visiblePassTrue, EventHandler visiblePassFalse)
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '\0';
            senderBtn.BackgroundImage = Properties.Resources.eye_60px;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassTrue);
            senderBtn.Click += new EventHandler(visiblePassFalse);
        }
        public static void ViewEyePassFalse(object senderButton, TextBox txtPass, TextBox txtPassCheck, EventHandler visiblePassTrue, EventHandler visiblePassFalse)
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '*';
            txtPassCheck.PasswordChar = '*';
            senderBtn.BackgroundImage = Properties.Resources.eyelashes_3d_64px;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassFalse);
            senderBtn.Click += new EventHandler(visiblePassTrue);
        }
        public static void ViewEyePassFalse(object senderButton, TextBox txtPass, EventHandler visiblePassTrue, EventHandler visiblePassFalse)
        {
            Button senderBtn = senderButton as Button;
            txtPass.PasswordChar = '*';
            senderBtn.BackgroundImage = Properties.Resources.eyelashes_3d_64px;
            senderBtn.BackgroundImageLayout = ImageLayout.Zoom;

            senderBtn.Click -= new EventHandler(visiblePassFalse);
            senderBtn.Click += new EventHandler(visiblePassTrue);
        }
    }
}
