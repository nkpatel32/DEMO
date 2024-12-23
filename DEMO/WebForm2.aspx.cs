﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DEMO
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int number1 = int.Parse(TextBox1.Text);
                int number2 = int.Parse(TextBox2.Text);
                int number3 = int.Parse(TextBox3.Text);

               
                int sum = number1 + number2 + number3;

            
                ResultLabel.Text = "Result: " + sum.ToString();
            }
            catch (FormatException)
            {
              
                ResultLabel.Text = "Please enter valid numbers!";
            }
        }
    }
}