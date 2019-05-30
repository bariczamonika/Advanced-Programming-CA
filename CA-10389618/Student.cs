using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CA_10389618
{
    public partial class Student : CA_10389618.Menu
    {


        public Student()
        {
            InitializeComponent();
        }




        //method to check if everything is filled in
        protected void MustFillUp()
        {
            Regex regex = new Regex("^[a-zA-Z]+$");
            Regex regex2 = new Regex("^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$");
            Regex regex3 = new Regex("^.+@[^\\.].*\\.[a-z]{2,}$");
            if (string.IsNullOrEmpty(txtFirstName.Text)|| !regex.IsMatch(txtFirstName.Text))
            {
                throw new FormatException("First name must be filled in and cannot contain numbers");
            }
            else if (string.IsNullOrEmpty(txtLastName.Text) || !regex.IsMatch(txtLastName.Text))
            {
                throw new FormatException("Last name must be filled in and cannot contain numbers");
            }
            else if (string.IsNullOrEmpty(txtCountry.Text) || !regex.IsMatch(txtCountry.Text))
            {
                throw new FormatException("Country must be filled in and cannot contain numbers");
            }
            else if (string.IsNullOrEmpty(txtCity.Text) || !regex.IsMatch(txtCity.Text))
            {
                throw new FormatException("City must be filled in and cannot contain numbers");
            }
            else if (string.IsNullOrEmpty(txtAd1.Text))
            {
                throw new FormatException("Address line 1 must be filled in");
            }
            else if (string.IsNullOrEmpty(txtPhoneNumber.Text) || !regex2.IsMatch(txtPhoneNumber.Text))
            {
                throw new FormatException("Phone number must be filled in and cannot contain letters");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || !regex3.IsMatch(txtEmail.Text))
            {
                throw new FormatException("Email number must be filled in and has to contain '@' ");
            }
        }
        
    }
}
