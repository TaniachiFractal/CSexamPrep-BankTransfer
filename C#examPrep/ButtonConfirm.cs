using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_examPrep
{
    // This class is made for the click confirmation
    internal class ButtonConfirm
    {
        // Pop up a message box asking to continue (the message is input when calling the function)
        // Returns true if OK was clicked
        static public bool BtCn(string MBtext)
        {
            var MBresult = MessageBox.Show(MBtext, "Подтверждение действия", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (MBresult == DialogResult.OK) 
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
