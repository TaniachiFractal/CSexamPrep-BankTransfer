using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_examPrep
{
    public partial class Payment : Form
    {
        // Receipt form
        Output receipt = new Output();

        // Information strings for the Receipt Form
        static public string outNumber;
        static public string outFio;
        static public string outSum;
        static public string outPayBank;
        static public string outBIK;
        static public string outINN;
        static public string outReceiveBank;
        static public string outReceiver;

        public Payment()
        {
            InitializeComponent();
        }

        // Generate number 
        private void Payment_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            tbNum.Text = rnd.Next(100000000,999999999).ToString();
        }

        // Ask to continue
        // Check all fields
        // Output the data
        private void btSend_Click(object sender, EventArgs e)
        {
            if(ButtonConfirm.BtCn("Вы собираетесь отправить перевод. Реквизиты нельзя будет изменить. Продолжить?"))
            {
                // Each failed check adds more error report text to this string => if it's empty, everything is correct
                string errorTxt = string.Empty;

                errorTxt += FieldCheck.ChFIO(tbFio.Text);
                errorTxt += FieldCheck.ChSum(tbSum.Text);
                errorTxt += FieldCheck.ChRadioButtons(gbPayBank);
                errorTxt += FieldCheck.ChBIK(tbBIK.Text); 
                errorTxt += FieldCheck.ChINN(tbINN.Text);
                errorTxt += FieldCheck.ChRadioButtons(gbReceiveBank);
                errorTxt += FieldCheck.ChReceiver(tbReceiver.Text);

                if (errorTxt != string.Empty)
                {
                    MessageBox.Show("Перевод не отправлен. Допущены ошибки в полях: \n\n" + errorTxt, "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    gbMain.Enabled = false;
                    btReset.Text = "Новый перевод";

                    outNumber = tbNum.Text;
                    outFio = tbFio.Text;
                    outSum = tbSum.Text;
                    outBIK = tbBIK.Text;
                    outINN = tbINN.Text;
                    outReceiver = tbReceiver.Text;

                    outPayBank = GetGroupBoxRadioButton(gbPayBank);
                    outReceiveBank = GetGroupBoxRadioButton(gbReceiveBank);
                    
                    receipt.Show();
                }
            }
        }

        // Clear all fields
        private void btReset_Click(object sender, EventArgs e)
        {
            // Clear form
            void ClearForm()
            {
                tbFio.Text = string.Empty;
                tbSum.Text = string.Empty;
                tbBIK.Text = string.Empty;
                tbINN.Text = string.Empty;
                tbReceiver.Text = string.Empty;

                rbPB_0.Checked = false;
                rbPB_1.Checked = false;
                rbPB_2.Checked = false;

                rbRB_0.Checked = false;
                rbRB_1.Checked = false;
                rbRB_2.Checked = false;

                receipt.Hide();
            }


            if (gbMain.Enabled)
            {
                if (ButtonConfirm.BtCn("Вы собираетесь очистить все поля и запустить создание нового перевода. Это действие нельзя будет отменить. Продолжить?"))
                {
                    Payment_Load(sender, e);
                    ClearForm();
                }
            }
            else
            {
                if (ButtonConfirm.BtCn("Вы собираетесь отправить ещё 1 перевод. Это удалит сведения о предыдущем переводе. Это действие нельзя будет отменить. Продолжить?"))
                {
                    btReset.Text = "Отменить";
                    gbMain.Enabled = true;
                    Payment_Load(sender, e);
                    ClearForm() ;
                }
            }


            
        }

        // Outputs the value of selected radio button in a group
        static private string GetGroupBoxRadioButton(GroupBox inputGroupBox)
        {
            foreach (RadioButton rb in inputGroupBox.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {   
                    return rb.Text;
                }
            }
            return string.Empty;
        }

        
    }
}
