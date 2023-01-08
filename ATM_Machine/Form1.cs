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
                if (pinTextBox.Text == "1234" )
                {
                    this.Hide();
                    Form2 f2 = new (); //this is the change, code for redirect  
                    f2.ShowDialog();
                }
           
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            pinTextBox.Text += button.Text;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
                pinTextBox.Text = "";
        }

        
        
    }
}