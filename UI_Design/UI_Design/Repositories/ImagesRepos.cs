using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Design
{
    class ImagesRepos
    {
        public static void AddImg(string TitleImg, byte[] Img, Child inputChild, string CategorImg)//добавление img в базу
        {          
            using (BabyDbContext db = new BabyDbContext())
            {
                Imagge newImg = new Imagge()
                {
                    Title = TitleImg,
                    ImageView = Img,
                    Categor= CategorImg
                };
                var childd = db.Childs.FirstOrDefault(c => c.Id == inputChild.Id);
                childd.Images.Add(newImg);
                db.SaveChanges();               
            }
        }

        public static void ViewImgCateg (string NameBtnCateg, List<Imagge> imagges, Child child, byte[] byteImg, PictureBox pictureBox1)
        {            
            imagges.Clear();
            using (BabyDbContext db = new BabyDbContext())
            {
                List<Imagge> img = db.Images.ToList();

                for (int i = 0; i < img.Count; i++)
                {
                    if (img[i].Child_Id == child.Id && img[i].Categor == NameBtnCateg)
                    {
                        imagges.Add(img[i]);
                    }
                }
            }
            try
            {
                byteImg = imagges[0].ImageView;
                using (MemoryStream ms = new MemoryStream(byteImg, 0, byteImg.Length))
                {                   
                   pictureBox1.BackgroundImage = Image.FromStream(ms);
                }
            }
            catch
            {
                pictureBox1.BackgroundImage = Properties.Resources.noImg;
            }

        }
    }
}
