using Projekt_w64238.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Projekt_w64238
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetCarList();
        }

        public void GetCarList()
        {
            DataContext db = new DataContext();

            foreach (Car car in db.Cars)
            {
                //głowny div ogłoszenia
                HtmlGenericControl element = new HtmlGenericControl();
                element.TagName = "div";
                element.Attributes["class"] = "container1";

                //div zawierający informacje o aucie
                HtmlGenericControl info = new HtmlGenericControl();
                info.TagName = "div";
                info.Attributes["class"] = "infocar";

                //div zawierajacy marke, model, cenę oraz przycisk rozpoczynający wypozyczenie
                HtmlGenericControl upperInfo = new HtmlGenericControl();
                upperInfo.TagName = "div";
                upperInfo.Attributes["class"] = "upperinfo";
                upperInfo.InnerText = car.Brand + " " + car.Model + " " + car.Prize + "$/day ";

                //przycisk rozpoczynajacy wypozyczenie
                Button btn = new Button();
                btn.Width = 60;
                btn.Click += btn_Click;
                btn.Height = 30;
                btn.Text = "Rent";
                btn.CommandName = car.CarID.ToString();
                btn.BackColor = System.Drawing.Color.Black;
                btn.ForeColor = System.Drawing.Color.White;
                upperInfo.Controls.Add(btn);

                //div zawierajacy hp,rok produkcji i pojemnosc
                HtmlGenericControl lowerInfo = new HtmlGenericControl();
                lowerInfo.TagName = "div";
                lowerInfo.Attributes["class"] = "lowerinfo";
                lowerInfo.InnerText = car.HorsePower + "HP " + car.ProductionYear + " " + car.Capacity + " dm3";


                //zdjecia auta
                Image img = new Image();
                img.ImageUrl = car.Image.ToString();
                img.Height = 160;
                img.Width = 160;

                //umiejscowianie divów
                info.Controls.Add(upperInfo);
                info.Controls.Add(lowerInfo);
                element.Controls.Add(img);
                element.Controls.Add(info);
                form1.Controls.Add(element);
            }
        }

        //funkcja klikniecia przycisku przenoszaca na formularz gdzie doknywane jest wypozyczenie
        private void btn_Click(object sender, EventArgs e)
        {
            
            DataContext db = new DataContext();
            Button btn = sender as Button;
            Session["Car"] = db.Cars.Find(Guid.Parse(btn.CommandName));
            Response.Redirect("~/WebForm3.aspx");

        }
    }
}