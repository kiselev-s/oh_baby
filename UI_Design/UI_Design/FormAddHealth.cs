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
    public partial class FormAddHealth : Form
    {
        private static Child child = null;
        public FormAddHealth(Child _child)
        {
            InitializeComponent();
            child = _child;
            StylesService.SetEnabledPropDateTP(dtpMeeting, false);
            StylesService.SetEnabledPropDateTP(dtpNextMeeting, false);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnAddHealth_Click(object sender, EventArgs e)
        {
            if (Validation.VerifyAddHealth(txtProff.Text))
            {
                HealthRepos.AddData(child.FirstName, child.LastName, txtProff.Text, dtpMeeting.Value, dtpNextMeeting.Value);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
