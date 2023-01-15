using ATM_Machine.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine
{
    public partial class transactionForm : Form
    {
        public transactionForm()
        {
            InitializeComponent();
            currentAmountBox.Text = CurrentAmount.userAmount.ToString(); // get current amount everytime it opens form
        }

        public void Add_Click(object sender, EventArgs e)
        {
           try
           {
                
                currentAmountBox.Text = (CurrentAmount.userAmount += float.Parse(enterAmount.Text)).ToString();//the math for deposit button takes current amount + the the amount the user entered = currentAmount.text
                enterAmount.Clear();//clears the entered amount
           }
           catch (Exception ex)
           {

                MessageBox.Show(ex.Message);//error messasge box for incorrect vaule entered
           }
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            try
            {
                currentAmountBox.Text = (CurrentAmount.userAmount -= float.Parse(enterAmount.Text)).ToString();
                enterAmount.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            if (CurrentAmount.userAmount < 0)// if account goes below 0 runs the fail messsage. listed in the fail message class
            {
                FailMessage.OverDrawn();
            }
            
            
               
        }
        private void LogOut (object sender, EventArgs e)//logout button takes you back to the login form
        {
            this.Hide();
            FormMain f1 = new (); //this is the change, code for redirect
            f1.ShowDialog();

        }
    }
}
