using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationDesk
{
    public partial class Admin : System.Web.UI.Page
    {
        Reservation result;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            String emailToFind = TextBox1.Text;
      

            for (int i = 0; i < Reservations.reservationList.Count; i++)
            {

                if (Reservations.reservationList[i].guestEmail == emailToFind)
                {
                    result = Reservations.
                        reservationList[i];
                    break;
                }
            }
            if(result != null)
            {
                TextBox2.Text = "";
                TextBox2.Text += (result.ToString());
            }
            else
            {
                TextBox2.Text = "No reservation exists for that email address.";
            }
        }
    }
}