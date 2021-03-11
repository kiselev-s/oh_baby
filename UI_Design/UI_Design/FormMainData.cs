using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DateSpan = System.Data.Linq.SqlClient.SqlMethods;
using MoreLinq;

namespace UI_Design
{
    public partial class FormMainData : Form
    {
        private static Child child = null;
        private static Parent parent = null;
        private static List<Health> health = null;

        public FormMainData(Child _child, Parent _parent)
        {
            InitializeComponent();
            child = _child;
            parent = _parent;
        }

        private void FormMainData_Load(object sender, EventArgs e)
        {
            if (child != null)
                ChildShowData();                
            if(parent != null)
                lblParentName.Text = $"{parent.FirstName} {parent.LastName}";            
        }

        private void ChildShowData()//вывод данных о ребенке на главную форму
        {
            lblBirthday.Text = child.Birthday.ToShortDateString();
            lblGender.Text = GetGender(child.Gender);

            lblFeast.Text = ShowFeast(child.Birthday).ToString();

            health = HealthRepos.FindByChild(child);
            //if(health.Count > 0)
                //lblDateHealth.Text = health[0].DateMeeting.ToShortTimeString().ToString();
        }

        private string ShowFeast(DateTime feast)//показать праздник
        {
            DateTime dateNow = DateTime.Now;

            //int monthDiff = Math.Abs(DateSpan.DateDiffMonth(dateNow, birthday));
            int dayDiff = DateSpan.DateDiffDay(dateNow, feast);
            //int yearDiff = Math.Abs(DateSpan.DateDiffYear(dateNow, birthday));
            //int minDiff = Math.Abs(DateSpan.DateDiffMinute(dateNow, birthday));
            //int secDiff = Math.Abs(DateSpan.DateDiffSecond(dateNow, birthday));
            //int hrsDiff = Math.Abs(DateSpan.DateDiffHour(dateNow, birthday));
            //int msDiff = Math.Abs(DateSpan.DateDiffMillisecond(dateNow, birthday));

            return (365 + dayDiff).ToString() + " дн.";
        }

        private string GetGender(int gender)//дешифратор пола ребенка
        {
            if (gender == 0)
                return ($"дочь {child.FirstName}");
            else if (gender == 1)
                return ($"сын {child.FirstName}");
            else
                return "нафиг такой пол";
        }

        private static void date()
        {
            var dict = new Dictionary<DateTime, string>()
            {
                [new DateTime(2016, 1, 1)] = "прошедший Новый Год",
                [new DateTime(2016, 12, 31)] = "будущий Новый Год",
                [new DateTime(2014, 1, 5)] = "давным-давно"
            };
            var today = DateTime.Now;
            var closestValue = dict.MinBy(kvp => (kvp.Key - today).Duration());
        }
    }
}
