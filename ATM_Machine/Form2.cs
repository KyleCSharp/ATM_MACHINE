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
        
        private void Add_Click(object sender, EventArgs e)
        {
            if (enterAmount.Text == "")
            {
                currentAmountBox.Text = "ERROR PLEASE ENTER VAILED NUMBER";
            }
            {
                currentAmountBox.Text = (currentAmount += float.Parse(enterAmount.Text)).ToString();
                enterAmount.Clear();
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
                if(enterAmount.Text == "")
                {
                    currentAmountBox.Text = "ERROR PLEASE ENTER VAILED NUMBER";
                }
                else
                {   
                    currentAmountBox.Text = (currentAmount -= float.Parse(enterAmount.Text)).ToString();
                            enterAmount.Clear();
                } 
                    OverDrawn();
        }
        
        private void OverDrawn ()
        {
            if (currentAmount < 0)
            {

                MessageBox.Show("please deposit money or face account being closed!!!");
            }
        }
        private void LogOut (object sender, EventArgs e)
        {
            this.Hide();
            FormMain f1 = new FormMain(); //this is the change, code for redirect
            f1.ShowDialog();

        }
    }
}
