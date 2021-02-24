using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    public partial class FormAddChild : Form
    {
        public FormAddChild()
        {
            InitializeComponent();
            dtpBirthday.MaxDate = DateTime.Now;
            dtpBirthday.MinDate = DateTime.Now.AddYears(-20);//минимальная дата раждения ребенка - 20 лет назад
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty)
                MyMessageBox.MyShow("Введите имя!");
            else if (txtLastName.Text == string.Empty)
                MyMessageBox.MyShow("Введите фамилию!");
            else if (cbxGender.Text == string.Empty)
                MyMessageBox.MyShow("Выберите пол ребенка!");
            else
            {
                try
                {
                    GetDataDB.addChild(txtFirstName.Text, txtLastName.Text, dtpBirthday.Value);//добавляем нового ребенка
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MyMessageBox.MyShow("Ошибка чтения базы данных????");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
