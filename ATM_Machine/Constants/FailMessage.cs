using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Machine.Constants
{
    public class FailMessage
    {
        public const string inValid = "ERROR PLEASE ENTER VALID NUMBER";
       

        public static void OverDrawn()
        {
          MessageBox.Show("please deposit money or face account being closed!!!");
        }
    }
    
}
