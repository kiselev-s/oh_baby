using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;


namespace UI_Design
{
    
    public partial class FormMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        readonly BabyDbContext db;

        private static Child child;
        private static Parent parent;
        private static List<Child> children = null;
        private int textLength = 0;

        public FormMain()
        {
            db = new BabyDbContext();



            db.Parents.Load();
            db.Childs.Load();
            db.Growth_Weights.Load();
            db.Images.Load();

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Opacity = 0.85;
            Show();

            FormLogin logForm = new FormLogin();

            if (logForm.ShowDialog() == DialogResult.OK)//если залогинились
            {
                Opacity = 1.0;

                parent = logForm.GetParent();//получили того кто залогинился
                lblParentName.Text = $"{parent.FirstName} {parent.LastName}";//выводим имя родителя на главную

                GetParentChild();

                //child = ChildRepos.FindByFirstName(FilterByFirstName(cmbBoxNameChild.SelectedItem.ToString()));//полчили сущность Child по умолчанию (если она уже есть), после загрузки
            }
            else
            {
                Opacity = 1.0;
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav, lblTitle, "> Главная <");
            this.pnlFormLoader.Controls.Clear();
        }

        private void BtnDocuments_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormDocuments formDoc = new FormDocuments(parent,child);
            StylesService.CreateForm(formDoc, pnlFormLoader, lblTitle, "> Документы <"); 
      
        }

        private void BtnMed_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormMedicen formMed = new FormMedicen();
            StylesService.CreateForm(formMed, pnlFormLoader, lblTitle, "> Медицина <");       
           
        }

        private void BtnGrowth_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormGrowth formGr = new FormGrowth();
            StylesService.CreateForm(formGr, pnlFormLoader, lblTitle, "> Развитие <");
        }
                        
        private void BtnExit_Click(object sender, EventArgs e)
            
        {
            StylesService.ViewClickButton(sender, pnlNav);
            Application.Exit();
        }

        private void BtnSettings_Click_1(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormSettings formSettings = new FormSettings();
            StylesService.CreateForm(formSettings, pnlFormLoader, lblTitle, "> Свойства <");

        }        

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            Opacity = 0.85;

            FormAddChild formAddChild = new FormAddChild(parent);//Parent который залогинился передан в форму FormAddChild

            if(formAddChild.ShowDialog() == DialogResult.OK)
            {
                //child = formAddChild.GetChild(); // а может не надо?

                Opacity = 1.0;

                GetParentChild();
            }
            else
            {
                Opacity = 1.0;
            }
        }
        private void BtnAll_Leave(object sender, EventArgs e)//курсор покинул пределы любой кнопки
        {
            StylesService.ViewBackColorButton(sender);
        }

        private void cmbBoxNameChild_SelectedIndexChanged(object sender, EventArgs e)//выбрали другого ребенка
        {
            if (cmbBoxNameChild.Items.Count > 0)
                child = ChildRepos.FindByFirstName(FilterByFirstName(cmbBoxNameChild.SelectedItem.ToString()));
            
            //сюда обработку данных выбраного(текущего) ребенка
        }

        private void GetParentChild()//получаем всех детей родителя и заполняем в ComboBox
        {
            children = ChildRepos.FindByParent(parent);
            cmbBoxNameChild.Items.Clear();
            string tmp=  string.Empty;

            if (children.Count > 0)
            {
                foreach (Child item in children)//заполнили ComboBox всеми детьми родителя
                {
                    tmp = item.FirstName + " " + item.LastName;
                    AutoSizeComboBox(tmp);
                    cmbBoxNameChild.Items.Add(tmp);
                    cmbBoxNameChild.SelectedIndex = 0;
                }
            }
        }

        private void AutoSizeComboBox(string txt)//подгоняем размер ComboBox под самое длинное имя ребенка
        {
            int parentWidth = cmbBoxNameChild.Parent.Width;
            float size = cmbBoxNameChild.Font.Size;
            if (textLength == 0)
            {
                textLength = txt.Length;
                lblTmp.Text = txt;
            }
            if(txt.Length > textLength)
                lblTmp.Text = txt;

            cmbBoxNameChild.Width = lblTmp.Width+15;

            if (lblTmp.Width+10 > parentWidth-2)
            {
                while(lblTmp.Width+10 > parentWidth - 2)
                {
                    lblTmp.Font = new Font(FontFamily.GenericSansSerif, size--);// было size = size -1;
                }

                cmbBoxNameChild.Font = new Font(FontFamily.GenericSansSerif, lblTmp.Font.Size);
                cmbBoxNameChild.Width = lblTmp.Width+15;
            }

            cmbBoxNameChild.Location = new Point((parentWidth - cmbBoxNameChild.Width) / 2, cmbBoxNameChild.Location.Y);
        }

        private string FilterByFirstName(string cbxSelItemFullName)//выбираем только имя ребенка, без фамилии
        {
            string[] temp;
            temp = cbxSelItemFullName.Split(' ');
            return temp[0];
        }
    }
}
