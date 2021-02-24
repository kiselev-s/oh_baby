using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class SetStyleElemens
    {
        public static void viewClickButton(object sender, Panel senderPanel)
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
            senderPanel.BackColor= Color.FromArgb(46, 51, 73);
            form.Show();           
        }

        public static void viewBackColorButton(object sender)
        {
            Button senderBtn = sender as Button;
            senderBtn.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
