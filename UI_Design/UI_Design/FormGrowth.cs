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
            //using (BabyDbContext db = new BabyDbContext())
            //{
            //    List<Imagge> img = db.Images.ToList();

            //    for (int i = 0; i < img.Count; i++)
            //    {
            //        if (img[i].Child_Id == child.Id && img[i].Categor == nameButton)
            //        {
            //            imagges.Add(img[i]);
            //        }
            //    }
            //}

            //using (BabyDbContext db = new BabyDbContext())
            //{
            //    List<int> year = db.Growth_Weights.Add.year

            //    for (int i = 0; i < img.Count; i++)
            //    {
            //        if (img[i].Child_Id == child.Id && img[i].Categor == nameButton)
            //        {
            //            imagges.Add(img[i]);
            //        }
            //    }
            //}
            using (BabyDbContext db = new BabyDbContext())
            {
                List<Growth_Weight> gw = db.Growth_Weights.ToList();
                LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();
                ChartValues<float> weight = new ChartValues<float>();
                ChartValues<int> growth = new ChartValues<int>();
                List<int> year = new List<int>();
                List<int> month = new List<int>();

                //foreach (var g in growth)

                for (int i = 0; i < year.Count; i++)
                {
                    if (gw[i].Child_Id == child.Id)
                        year[i] = Int32.Parse(cmbBoxYear.Text);
                    growth[i] = Int32.Parse(txtBoxGr.Text);
                    weight[i] = float.Parse(txtBoxWght.Text);
                }

                //foreach (var w in weight)
                for (int i = 0; i < month.Count; i++)
                {
                    month[i] = Int32.Parse(cmbBoxMonth.Text);
                    growth[i] = Int32.Parse(txtBoxGr.Text);
                    weight[i] = float.Parse(txtBoxWght.Text);
                }

                month[0] = Int32.Parse(cmbBoxMonth.Text);


                //try
                //{
                //    using (BabyDbContext db = new BabyDbContext())
                //    {
                //        Growth_Weight g_w = new Growth_Weight()
                //        {
                //            Year = year[0],
                //            Month = month[0],
                //            Growth = growth[0],
                //            Weight = weight[0]
                //        };

                //        db.Growth_Weights.Add(g_w);
                //        db.SaveChanges();
                //    }
                //    crtsnChrtDiagramm.AxisX.Clear();
                //    crtsnChrtDiagramm.AxisX.Add(new LiveCharts.Wpf.Axis()
                //    {
                //        Title = "Возраст, лет",
                //        //Labels = year.ToString()
                //    });
                //}
                //catch (Exception)
                //{
                //    FormMessage.Show("!");
                //}
            }
        }

        private void crtsnChrtDiagramm_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
 