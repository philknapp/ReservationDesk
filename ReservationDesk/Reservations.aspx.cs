using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReservationDesk
{
    public partial class Reservations : System.Web.UI.Page
    {
        public static List<Reservation> reservationList = new List<Reservation>();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["test"] = reservationList;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Boolean checkedDate = checkDate();
            Boolean checkedNumber = checkNumberNights();
            Boolean checkedFirst = checkFirstName();
            Boolean checkedLast = checkLastName();
            Boolean checkedEmail = checkEmail(); 
            if
            (
            checkedDate == true
                &&
            checkedNumber == true
                &&
            checkedFirst == true
                &&
            checkedLast == true
                &&
            checkedEmail == true
            )
            {
                Reservation webReservation = new Reservation();
                webReservation.arrivalDate = Calendar1.SelectedDate.Date;
                webReservation.numberNights = int.Parse(numberText.Text);
                webReservation.roomType = DropDownList1.Text;
                webReservation.firstName = firstText.Text;
                webReservation.lastName = lastText.Text;
                webReservation.guestEmail = emailText.Text;
                webReservation.specialNotes = notesText.Text;
                Session["webReservation"] = webReservation;
                reservationList.Add(webReservation);
                Response.Redirect(Page.ResolveClientUrl("/Success.aspx"));
            }

        }

        public Boolean checkDate()
        {
            if (Calendar1.SelectedDate.Date == DateTime.MinValue)
            {
                arrivalError.Text = "You must select an arrival date.";
                return false;
            }
            else
            {
                arrivalError.Text = "";
                return true;
            }

        }

        public Boolean checkNumberNights()
        {
            int i;
            if (!int.TryParse(numberText.Text, out i))
            {
                numberError.Text = "You must enter a valid number of nights.";
                return false;
            }
            else
            {
                numberError.Text = "";
                return true;
            }
        }

        public Boolean checkFirstName()
        {
           if (string.IsNullOrWhiteSpace(firstText.Text))
                {
                firstError.Text = "You must enter a first name.";
                return false;
                }
            else
            {
                firstError.Text = "";
                return true; 
            }
        }
        public Boolean checkLastName()
        {
            if (string.IsNullOrWhiteSpace(lastText.Text))
            {
                lastError.Text = "You must enter a last name.";
                return false;
            }
            else
            {
                lastError.Text = "";
                return true;
            }
        }

        public Boolean checkEmail()
        {
            if (!string.IsNullOrWhiteSpace(emailText.Text))
            {

                try
                {
                    var test = new MailAddress(emailText.Text);
                    emailError.Text = "";
                    return true;
                }
                catch (FormatException ex)
                {
                    emailError.Text = "You must enter a valid email address.";
                    return false;
                }
            }
            else
            {
                emailError.Text = "You must enter an email address.";
                return false;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(Page.ResolveClientUrl("/Admin.aspx"));
        }
    }
}