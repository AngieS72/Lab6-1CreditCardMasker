using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_1CreditCardMasker
{
    public partial class FormCreditCardMasker : Form
    {
        public FormCreditCardMasker()
        {
            InitializeComponent();
        }
        int len = 0;
       
        private void buttonMask_Click(object sender, EventArgs e)
        {
            setUpTheMask();
        }

        private void setUpTheMask()
        {
            Regex mask1 = new Regex("^\\d{16}$");
            Regex mask2 = new Regex("^\\d{4} \\d{4} \\d{4} \\d{4}$");
            int len = textBoxCreditCardNumber.Text.Length;          //Number of characters in textBox
            string str = "";                                                            //textBox characters copies into string
            string res = "";                                                        // Final resultant string that is printed in bottom masked label
            //validate correct length
            if ((len != 16) && (len != 19))
            {


                MessageBox.Show("You must enter the correct format." +
                    "1234 1234 1234 1234 Or 1234123412341234",
                    "INVALID LENGTH",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                textBoxCreditCardNumber.Text = "";
                textBoxCreditCardNumber.Focus();
                return;

            }

            else // its 16 digits or 19 digits and spaces
            {
                if ((!mask1.IsMatch(textBoxCreditCardNumber.Text) &&     //Does input match nnnnnnnnnnnnnnnn pattern?
                     (!mask2.IsMatch(textBoxCreditCardNumber.Text))))   //Does input match nnnn nnnn nnnn nnnn pattern?
                    

                {
                    MessageBox.Show("Invalid Characters Entered.  Enter " +
                        "either nnnnnnnnnnnnnnnn OR nnnn nnnn nnnn nnnn",
                        "INVALID CHARACTERS ENTERED",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    textBoxCreditCardNumber.Text = "";
                    textBoxCreditCardNumber.Focus();
                    return;
                }

                else                  //valid pattern match, i.e. 16 digits or 19 digits w/spaces.
                {
                    str = textBoxCreditCardNumber.Text;

                    if (len == 19)
                    {
                        str = str.Replace(" ", "");
                        len = 16;
                    }
                    res = new string('X', len - 4) +
                        str.Substring(len - 4);

                    labelMask.Text = res;
                }
            }
        }                 
            
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {

            textBoxCreditCardNumber.Text = "";
            labelMask.Text = "";
            textBoxCreditCardNumber.Focus();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            quitProgram();
        }
        private void quitProgram()
        {
            DialogResult dialog = MessageBox.Show(
               "Do you want to exit?",
               "EXIT NOW?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}



