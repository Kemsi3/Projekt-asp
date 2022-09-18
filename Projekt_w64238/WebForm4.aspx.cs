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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetRentList();
        }

        public void GetRentList()
        {
            DataContext db = new DataContext();
            List<Rent> rents = new List<Rent>();

            foreach (Rent rent in db.Rents)
            {
                rents.Add(rent);
            }

            foreach (Rent r in rents)
            {   
                HtmlGenericControl rentcontainer = new HtmlGenericControl();
                rentcontainer.TagName = "div";
                rentcontainer.Attributes["class"] = "rentcontainer";
                var rentedCar = db.Cars.Find(r.CarID);
                rentcontainer.InnerText = "Brand: " + rentedCar.Brand + " Model:" + rentedCar.Model + " Out Date: " + r.OutDate + " In Date: " + r.OutDate + " Prize: " + r.Prize + "$";
                form1.Controls.Add(rentcontainer);
            }
        }
    }
}