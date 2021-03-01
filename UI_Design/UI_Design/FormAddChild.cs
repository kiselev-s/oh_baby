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
        private static Parent parent;
        private static Child returnChild;

        public FormAddChild(Parent _parent)//приняли сущность Parent
        {
            InitializeComponent();
            parent = _parent;
            StylesService.SetEnabledPropDateTP(dtpBirthday);
            myDateTimePicker1.Invalidate();
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            if(Validation.VerifyAddChild(txtFirstName.Text, txtLastName.Text, cbxGender.Text))
            {
                returnChild =  ChildRepos.CreateChild(txtFirstName.Text, txtLastName.Text, dtpBirthday.Value, parent);//добавляем нового ребенка
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Child GetChild() => returnChild;
    }
}
