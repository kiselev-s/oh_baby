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
            ChartValues<float> weight=new ChartValues<float>() ;
            ChartValues<int> growth = new ChartValues<int>();
            List<int> year = new List<int>();
            List<int> month = new List<int>();

            year[0] = Int32.Parse(cmbBoxYear.Text);
            month[0] = Int32.Parse(cmbBoxMonth.Text);            
            growth[0] = Int32.Parse(txtBoxGr.Text);
            weight[0] = float.Parse(txtBoxWght.Text);
            try
            {
                using (BabyDbContext db = new BabyDbContext())
                {
                    Growth_Weight gw = new Growth_Weight()
                    {
                        Year = year[0],
                        Month = month[0],
                        Growth = growth[0],
                        Weight = weight[0]                        
                    };

                    db.Growth_Weights.Add(gw);
                    db.SaveChanges();
                }
                crtsnChrtDiagramm.AxisX.Clear();
                crtsnChrtDiagramm.AxisX.Add(new LiveCharts.Wpf.Axis()
                {
                    Title = "Возраст, лет",
                    //Labels = year.ToString()
                }) ;
            }
            catch (Exception)
            {
                FormMessage.Show("!");
            }
        }
    }
}
 