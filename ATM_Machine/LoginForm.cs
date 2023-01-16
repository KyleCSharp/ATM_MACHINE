using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace ATM_Machine
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
       

        private void PinTextBox_TextChanged(object sender, EventArgs e)
        {
           if(pinTextBox.Text == "1234")// the method above is checking for text changes everytimme it changes it run the mehtod code does not read untill user enters in pin then opens transaction form
           {
             this.Hide();//remember this.hide can be simplified to just Hide();
             transactionForm f2 = new (); //this is the change, code for redirect  
             f2.ShowDialog();
           }
           if(pinTextBox.Text == "9876")
           {
             Hide();
             transactionForm f2 = new (); //same not here as line 17
             f2.ShowDialog();
           }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;//this is for each button click takes the numbers written in the text for the button and put that into the pintextbox
            pinTextBox.Text += button.Text;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            pinTextBox.Text = "";//this is for the clear button if the appliaction was deployed on a touch screen with only a number pad to work with you would want a clear button 
        }

        
        
    }
}