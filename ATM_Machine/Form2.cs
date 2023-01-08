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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

         float currentAmount = 0;
        
        public void Add_Click(object sender, EventArgs e)
        {
           //if (enterAmount.Text == "")
           //{
           //   currentAmountBox.Text = FailMessage.inValid;
           //}
           //else
           //{
           //   currentAmountBox.Text = (currentAmount += float.Parse(enterAmount.Text)).ToString();
           //    enterAmount.Clear();
           //}
           try
           {
                currentAmountBox.Text = (currentAmount += float.Parse(enterAmount.Text)).ToString();
                enterAmount.Clear();
           }
           catch (Exception exx)
           {

                MessageBox.Show(exx.Message);
           }
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            try
            {
                currentAmountBox.Text = (currentAmount -= float.Parse(enterAmount.Text)).ToString();
                enterAmount.Clear();
            }
            catch (Exception exx)
            {

                MessageBox.Show(exx.Message);
            }
            if (currentAmount < 0)
            {
                FailMessage.OverDrawn();
            }
               
        }
        private void LogOut (object sender, EventArgs e)
        {
            this.Hide();
            FormMain f1 = new (); //this is the change, code for redirect
            f1.ShowDialog();

        }
    }
}
