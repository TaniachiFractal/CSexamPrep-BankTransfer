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
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }
        // Generate the receipt
        private void Output_Load(object sender, EventArgs e)
        {
            tbOutput.Text += Environment.NewLine
                           + Environment.NewLine;
            tbOutput.Text += "Номер перевода:        " + Payment.outNumber + Environment.NewLine;
            tbOutput.Text += "Дата и время перевода: " + DateTime.Now + Environment.NewLine;
            tbOutput.Text += "ФИО Плательщика:       " + Payment.outFio + Environment.NewLine;
            tbOutput.Text += "Сумма перевода:        " + Payment.outSum + " руб." + Environment.NewLine;
            tbOutput.Text += "Банк Плательщика:      " + Payment.outPayBank + Environment.NewLine;
            tbOutput.Text += "БИК:                   " + Payment.outBIK + Environment.NewLine;
            {
                tbOutput.Text += 
                             "ИНН ";
                if (Payment.outINN.Length == 10) tbOutput.Text += 
                                 "юридического лица: ";
                else tbOutput.Text += 
                                 "предпринимателя:   ";
                tbOutput.Text += Payment.outINN + Environment.NewLine;
            }
            tbOutput.Text += "Банк Получателя:       " + Payment.outReceiveBank + Environment.NewLine;
            tbOutput.Text += "Счёт Получателя:       " + Payment.outReceiver + Environment.NewLine;
        }
    }
}
