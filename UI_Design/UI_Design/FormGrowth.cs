using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using LiveCharts;
using LiveCharts.Wpf;


namespace UI_Design
{
    public partial class FormGrowth : Form
    {
        private static Child child;
        private static Parent parent;
        private static ChartValues<float> weight = new ChartValues<float>();
        private static ChartValues<int> growth = new ChartValues<int>();
        private static List<string> year = new List<string>();
        private static List<int> month = new List<int>();
        public FormGrowth(Parent _parent, Child _child)
        {
            InitializeComponent();
            child = _child;
            parent = _parent;
        }

        private void FormGrowth_Load(object sender, EventArgs e)
        {

        }

        private void btnBild_Click(object sender, EventArgs e)
        {
            
        
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
            using (BabyDbContext db = new BabyDbContext())
            {
                List<Growth_Weight> gw = db.Growth_Weights.ToList();

                Growth_Weight new_gw = new Growth_Weight()
                {
                    Month = Int32.Parse(cmbBoxMonth.Text),
                    Year = Int32.Parse(cmbBoxYear.Text),
                    Growth = Int32.Parse(txtBoxGr.Text),
                    Weight = float.Parse(txtBoxWght.Text)
                };
                Child ch = db.Childs.FirstOrDefault(c => c.Id == child.Id);
                ch.Growth_Weights.Add(new_gw);
                db.SaveChanges();

                month.Clear();
                year.Clear();
                growth.Clear();
                weight.Clear();
                foreach (var i in gw)
                {
                    if (i.Child_Id == child.Id)
                    {
                        month.Add(i.Month);
                        year.Add(i.Year.ToString());
                        growth.Add(i.Growth);
                        weight.Add(i.Weight);
                    }                          
                }
                 crtsnChrtDiagramm.AxisX.Clear();
                crtsnChrtDiagramm.AxisX.Add(new LiveCharts.Wpf.Axis()
                {
                    Title = "Возраст, лет",
                    Labels = year
                }) ;

                LineSeries line = new LineSeries();
                line.Title = "1";
                line.Values = weight;

                series.Add(line);
                crtsnChrtDiagramm.Series = series;

              
            }
        }

        private void crtsnChrtDiagramm_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
 