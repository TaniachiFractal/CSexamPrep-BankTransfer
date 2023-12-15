using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C_examPrep
{
    // This class contains functions for checking if the fields are correct

    //              For all "Ch" functions here:
    //
    // If wrong, return an string containing the message with field's name
    // If correct, return empty string
    internal class FieldCheck
    {
        // List of regular expressions
        static readonly Regex regexBIK = new Regex(@"^\d{9}$");
        static readonly Regex regexINN = new Regex(@"^\d{10}$|^\d{12}$");
        static readonly Regex regexReceiverAccount = new Regex(@"^\d{20}$");

        // Check if FIO is not empty
        static public string ChFIO(string input)
        {
            if (input == string.Empty) return "• ФИО Плательщика \n";
            return string.Empty;
        }

        // Check the sum of money 
        static public string ChSum(string input)
        {
            if (!double.TryParse(input, out var sum))
            {
                return "• Сумма Перевода \n";
            }
            return string.Empty;
        }

        // Check the BIK
        static public string ChBIK(string input)
        {
            if (!regexBIK.Match(input).Success)
            {
                return "• БИК \n";
            }
            return string.Empty;
        }

        // Check the INN
        static public string ChINN(string input)
        {      
            if (!regexINN.Match(input).Success)
            {
                return "• ИНН \n";
            }
            return string.Empty;
        }

        // Check the Receiver Account
        static public string ChReceiver(string input)
        {
            if (!regexReceiverAccount.Match(input).Success)
            {
                return "• Счёт Получателя \n";
            }
            return string.Empty;
        }

        // Check if a radio button is checked in a group box
        static public string ChRadioButtons(GroupBox inputGroupBox)
        {
            bool anyRBchecked = false;
            foreach(RadioButton rb in inputGroupBox.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    anyRBchecked = !anyRBchecked;
                    break;
                }
            }
            if (anyRBchecked)
            {
                return string.Empty;
            }
            else
            {
                return "• " + inputGroupBox.Text + "\n";
            }
        }
    }
}
