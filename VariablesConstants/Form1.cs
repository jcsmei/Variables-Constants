using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesConstants
{
    public partial class frmVariablesContants : Form
    {
        public frmVariablesContants()
        {
            InitializeComponent();
        }
        const string descrbingOutput =
            @"User input has been saved in a vaiable of data type";
        const string describingDivideBy3Output =
            @"User input has been saved in variables of three different datatypes: float, oduble and decimal.
When the three variables are dicided by 3 and the resulting quotients are displayed below.";
private void btnCharacter_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            char Input =' ';
            try
            {
                Input = char.Parse(userInput);
                lblOutput.Text = descrbingOutput +
                    " char. The variable is displayed below:" +
                    Environment.NewLine + Input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            } 
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            lblOutput.Text = descrbingOutput + " string. he variable is deisplay below:" +
                Environment.NewLine + userInput;
        }

        private void btnBool_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            bool Input = true;
            try
            {
                Input = bool.Parse(userInput);
                lblOutput.Text = descrbingOutput + " bool. The variable is display below:" +
                    Environment.NewLine + Input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void btnByte_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            byte Input = 0;
            try
            {
                Input = byte.Parse(userInput);
                lblOutput.Text = descrbingOutput +
                    " byte. The variable is displayed below:" +
                    Environment.NewLine + Input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            short Input = 0;
            try
            {
                Input = short.Parse(userInput);
                lblOutput.Text = descrbingOutput +
                    " short. The variable is displayed below:" +
                    Environment.NewLine + Input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }

        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            int Input = 0;
            try
            {
                Input = int.Parse(userInput);
                lblOutput.Text = descrbingOutput +
                    " int. The variable is displayed below:" +
                    Environment.NewLine + Input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void btnLong_Click(object sender, EventArgs e)
        {

            lblOutput.Text = "";
            string userInput = txtInput.Text;
            long Input = 0;
            try
            {
                Input = long.Parse(userInput);
                lblOutput.Text = descrbingOutput +
                    " long. The variable is displayed below:" +
                    Environment.NewLine + Input.ToString();
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;

            }
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            
                lblOutput.Text = "";
                string userInput = txtInput.Text;
                float Input = 0;
                try
                {
                    Input = float.Parse(userInput);
                    lblOutput.Text = descrbingOutput +
                        " float. The variable is displayed below:" +
                        Environment.NewLine + Input.ToString();
                }
                catch (Exception ex)
                {
                    lblOutput.Text = ex.Message;
                }
            }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            {
                lblOutput.Text = "";
                string userInput = txtInput.Text;
                double Input = ' ';
                try
                {
                    Input = double.Parse(userInput);
                    lblOutput.Text = descrbingOutput +
                        " double. The variable is displayed below:" +
                        Environment.NewLine + Input.ToString();
                }
                catch (Exception ex)
                {
                    lblOutput.Text = ex.Message;
                }
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            {
                lblOutput.Text = "";
                string userInput = txtInput.Text;
                decimal Input = 0;
                try
                {
                    Input = decimal.Parse(userInput);
                    lblOutput.Text = descrbingOutput +
                        " decimal. The variable is displayed below:" +
                        Environment.NewLine + Input.ToString();
                }
                catch (Exception ex)
                {
                    lblOutput.Text = ex.Message;
                }
            }
        }

        private void btnDvide3_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            string userInput = txtInput.Text;
            float fInput = 0;
            double dblInput = 0;
            decimal decInput = 0;
            try
            {
                float.TryParse(userInput, out fInput);
                double.TryParse(userInput, out dblInput);
                decimal.TryParse(userInput, out decInput);
                lblOutput.Text = describingDivideBy3Output +
                    Environment.NewLine + userInput + " / 3 = " +
                    (fInput / 3).ToString() + " (using float variable;)" +
                    Environment.NewLine + userInput + " / 3 = " +
                    (dblInput / 3).ToString() + " (using double variable;)" +
                    Environment.NewLine + userInput + " / 3 = " +
                    (decInput / 3).ToString() + " (using decimal variables.)";

            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            txtInput.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
