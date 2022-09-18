using Projekt_w64238.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projekt_w64238
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCarInfo();
        }

        [Obsolete]
        public void AddRent()
        {
            DataContext db = new DataContext();
            var selectedCar = (Car)Session["Car"];
            Rent rent = new Rent();
            rent.RentID = new Guid();
            rent.CarID = selectedCar.CarID;
            rent.OutDate = DateTime.Parse(OutDateDP.Text);
            rent.InDate = DateTime.Parse(InDateDP.Text);
            TimeSpan? duration = DateTime.Parse(InDateDP.Text) - DateTime.Parse(OutDateDP.Text);
            rent.Duration = duration.Value.Days;
            rent.Prize = (rent.Duration + 1) * selectedCar.Prize;
            db.Rents.Add(rent);
            db.SaveChanges();
            Page.RegisterStartupScript("UserMsg", "<script>alert('You rented this car');;window. location='WebForm1.aspx'</script>");
        }

        public void LoadCarInfo()
        {
            var selectedCar = (Car)Session["Car"];
            BrandLb.Text = selectedCar.Brand;
            ModelLb.Text = selectedCar.Model;
            ImageCar.ImageUrl = (selectedCar.Image).ToString();
            ProductionYearLb.Text = selectedCar.ProductionYear.ToString() + " year ";
            CapacityLb.Text = selectedCar.Capacity.ToString() + " dm ";
            HPLb.Text = selectedCar.HorsePower.ToString() + " hp ";
        }

        protected void OutDateChange(object sender, EventArgs e)
        {
            OutDateDP.Text = Calendar1.SelectedDate.Day + "-" + Calendar1.SelectedDate.Month + "-" + Calendar1.SelectedDate.Year;
            if (InDateDP.Text != "" && OutDateDP.Text != "")
            {
                var selectedCar = (Car)Session["Car"];
                TimeSpan? duration = DateTime.Parse(InDateDP.Text) - DateTime.Parse(OutDateDP.Text);
                int dur = duration.Value.Days; if (dur > 0)
                {
                    PrizeTbx.Text = ((dur + 1) * selectedCar.Prize).ToString() + " $";
                }
            }

        }
        protected void InDateChange(object sender, EventArgs e)
        {
            InDateDP.Text = Calendar2.SelectedDate.Day + "-" + Calendar2.SelectedDate.Month + "-" + Calendar2.SelectedDate.Year;

            if (InDateDP.Text != "" && OutDateDP.Text != "")
            {
                var selectedCar = (Car)Session["Car"];
                TimeSpan? duration = DateTime.Parse(InDateDP.Text) - DateTime.Parse(OutDateDP.Text);
                int dur = duration.Value.Days;
                if (dur > 0)
                {
                    PrizeTbx.Text = ((dur + 1) * selectedCar.Prize).ToString() + " $";
                }
            }
        }

        [Obsolete]
        protected void RentBT_Click(object sender, EventArgs e)
        {
            var selectedCar = (Car)Session["Car"];

            using (DataContext db = new DataContext())
            {
                if (Calendar1.SelectedDate > Calendar2.SelectedDate || Calendar1.SelectedDate < DateTime.Now)
                {
                    Page.RegisterStartupScript("UserMsg", "<script>alert('wrong dates');</script>");
                    return;
                }
                foreach(Rent rent in db.Rents)
                {
                    if(rent.CarID == selectedCar.CarID)
                    {
                        if ((Calendar2.SelectedDate < rent.InDate && Calendar1.SelectedDate < rent.InDate) || (Calendar1.SelectedDate > rent.OutDate && Calendar2.SelectedDate > rent.OutDate))
                        {
                        }
                        else
                        {
                            Page.RegisterStartupScript("UserMsg", "<script>alert('Car isnt available in this dates');</script>");
                            return;
                        }
                    }
                }
                AddRent();
            } 
        }
    }
}