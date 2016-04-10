using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationDesk
{
    public partial class Success : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["webReservation"] != null)
            {
                Reservation webReservation = (Reservation)Session["webReservation"];
                TextBox1.Text = webReservation.ToString();
            }
            else
            {
                successLabel.Text = "Go back to the Reservations page and fill out a Reservation!";
            }
        }


    }
}