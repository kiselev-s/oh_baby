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
using LiveCharts.Defaults;

namespace UI_Design
{
    public partial class FormGrowth : Form
    {
        private static Child child;
        private static Parent parent;
        private static ChartValues<float> weight = new ChartValues<float>();
        private static ChartValues<int> growth = new ChartValues<int>();

        private static List<string> ageMonth = new List<string>();
        private static string x = null;
        public FormGrowth(Parent _parent, Child _child)
        {
            InitializeComponent();
            child = _child;
            parent = _parent;
        }        
        private void btnBild_Click(object sender, EventArgs e)
        {
            LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
                try
                { 
                        using (BabyDbContext db = new BabyDbContext())
                        {
                            List<Growth_Weight> gw = db.Growth_Weights.ToList();

                            if (rdBtnYr.Checked == true)
                                x = (Int32.Parse(cmbBoxYear.Text) * 12).ToString();
                            if (rdBtnMnth.Checked == true)
                                x = cmbBoxMonth.Text;

                            Growth_Weight new_gw = new Growth_Weight()
                            {
                                AgeMonth = Int32.Parse(x),
                                Growth = Int32.Parse(txtBoxGr.Text),
                                Weight = float.Parse(txtBoxWght.Text)
                            };
                            Child ch = db.Childs.FirstOrDefault(c => c.Id == child.Id);
                            ch.Growth_Weights.Add(new_gw);
                            db.SaveChanges();

                            ageMonth.Clear();

                            growth.Clear();
                            weight.Clear();
                            foreach (var i in gw)
                            {
                                if (i.Child_Id == child.Id)
                                {
                                    growth.Add(i.Growth);
                                    weight.Add(i.Weight);
                                    ageMonth.Add(i.AgeMonth.ToString());
                                }
                            }

                            crtsnChrtDiagramm.AxisX.Clear();
                            if (cmbBoxYear.Enabled == true)
                            {
                                crtsnChrtDiagramm.AxisX.Add(new LiveCharts.Wpf.Axis()
                                {
                                    Title = "Возраст, лет",
                                    Labels = ageMonth
                                });

                                LineSeries line1 = new LineSeries();
                                //line1.Title = $"{x}";
                                line1.Values = weight;
                                series.Add(line1);
                                crtsnChrtDiagramm.Series = series;

                                LineSeries line2 = new LineSeries();
                                //line2.Title = $"{x}";
                                line2.Values = growth;
                                series.Add(line2);
                                crtsnChrtDiagramm.Series = series;
                            }
                            else
                            {
                                crtsnChrtDiagramm.AxisX.Add(new LiveCharts.Wpf.Axis()
                                {
                                    Title = "Возраст, мес",
                                    Labels = ageMonth
                                });

                                LineSeries line1 = new LineSeries();
                                //line1.Title = $"{x}";
                                line1.Values = weight;
                                series.Add(line1);
                                crtsnChrtDiagramm.Series = series;

                                LineSeries line2 = new LineSeries();
                                //line2.Title = $"{x}";
                                line2.Values = growth;
                                series.Add(line2);
                                crtsnChrtDiagramm.Series = series;                                
                            }
                        }                
                }
            catch { }
        }

        private void rdBtnMnth_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxMonth.Enabled = true;
            cmbBoxYear.Enabled = false;
            cmbBoxYear.Text = "0";
        }

        private void rdBtnYr_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxYear.Enabled = true;
            cmbBoxMonth.Enabled = false;
            cmbBoxMonth.Text = "0";
        }
    }
}