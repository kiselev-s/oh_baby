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
        private static int parentId;
        private static int childId;
        public FormAddChild(int _parentId)//приняли Id того кто залогинился
        {
            InitializeComponent();
            parentId = _parentId;
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
                    childId = GetDataDB.addChild(txtFirstName.Text, txtLastName.Text, dtpBirthday.Value, parentId).Id;//добавляем нового ребенка и получаем его Id
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

        public Child getChild()//функция возвращает обьект Child
        {
            return GetDataDB.findChildById(childId);
        }
    }
}
