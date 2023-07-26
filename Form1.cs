using System.Media;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;

namespace Cglynn_Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDateTimePicker();
        }
        public void InitializeDateTimePicker() //initlaizes so that the default is asking for both date AND time
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd H:mm";

        }
        private void delivery_CheckedChanged(object sender, EventArgs e) //when button is clicked other options dissappear
        {
            address.Visible = true;
            postalCode.Visible = true;
            codeTip.Visible = true;
            dateTimePicker1.Visible = false;
        }

        private void pickup_CheckedChanged(object sender, EventArgs e) //when button is clicked other options dissappear
        {
            address.Visible = false;
            postalCode.Visible = false;
            codeTip.Visible = false;
            dateTimePicker1.Visible = true;
        }

        private void cxName_KeyPress(object sender, KeyPressEventArgs e) //doesnt allow user to input any characters besides letters, white space, and to press backspace
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cxNumber_KeyPress(object sender, KeyPressEventArgs e)//doesnt allow user to input any characters besides numbers, and to press backspace
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void prod1_KeyPress(object sender, KeyPressEventArgs e)//doesnt allow user to input any characters besides numbers, and to press backspace
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void prod2_KeyPress(object sender, KeyPressEventArgs e)//doesnt allow user to input any characters besides numbers, and to press backspace
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private async void receiptGen_Click(object sender, EventArgs e)//button to generate receipt for cashier
        {
            receipt.Visible = true;
            receipt.Clear();
            if (!delivery.Checked && !pickup.Checked)
            {
                MessageBox.Show(
                  "Please select either pick-up or delivery, and fill in the required information.",
                  "Error!",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                  );
                for (int i = 0; i < 3; i++)
                {
                    pickup.BackColor = Color.Red;
                    delivery.BackColor = Color.Red;
                    await Task.Delay(500);
                    pickup.BackColor = Color.Transparent;
                    delivery.BackColor = Color.Transparent;
                    await Task.Delay(500);
                }

            }
            nullException(userReceipt());
            receipt.Text = userReceipt();
        }

        private string nullException(string str)//if ending string is null program won't crash unless user makes it (thanks Microsoft)
        {
            if (str == null)
            {
                MessageBox.Show(
                  "No information has been entered. Please enter customer information to generate receipt.",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Asterisk, //For Info Asterisk
                  (MessageBoxDefaultButton)MessageBoxIcon.Exclamation //For triangle Warning 
                  );
                return "User-entered information does not exist";
            }
            else
            {
                return str;
            }
        }

        private string userReceipt()//prints receipt, variations are made for whether the customer is picking up or getting it delivered
        {
            string receipt = String.Empty;
            string customerName = cxName.Text + "";
            string customerNumber = cxNumber.Text + "";
            receipt = "==================================" + Environment.NewLine
                    + "Order Summary" + Environment.NewLine
                    + "==================================" + Environment.NewLine + Environment.NewLine
                    + cxLabel.Text
                    + Environment.NewLine
                    + customerName
                    + Environment.NewLine
                    + customerNumber
                    + Environment.NewLine
                    + "Product 1 " + "(" + prod1.Text + ")" + "\t..........................\t$" + prod1Amount() + Environment.NewLine
                    + "Product 2 " + "(" + prod2.Text + ")" + "\t..........................\t$" + prod2Amount() + Environment.NewLine;
            if (delivery.Checked)
            {
                receipt += Environment.NewLine + "-------------------------------------------------------" + Environment.NewLine + Environment.NewLine
                        + "Delivery Fee\t..........................\t$15" + Environment.NewLine
                        + "Subtotal\t..........................\t$" + (prod1Amount() + prod2Amount() + 15) + Environment.NewLine
                        + "Total\t..........................\t$" + (prod1Amount() + prod2Amount() + 15) * 1.13 + Environment.NewLine
                        + Environment.NewLine + "-------------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                receipt += "Delivery address " + address.Text + ", " + postalCode.Text;
            }
            if (pickup.Checked)
            {
                receipt += Environment.NewLine + "-------------------------------------------------------" + Environment.NewLine + Environment.NewLine
                       + "Subtotal\t..........................\t$" + (prod1Amount() + prod2Amount()) + Environment.NewLine
                       + "Total\t..........................\t$" + (prod1Amount() + prod2Amount()) * 1.13 + Environment.NewLine
                       + Environment.NewLine + "-------------------------------------------------------" + Environment.NewLine + Environment.NewLine;
                receipt += "Pick-Up to occur on " + dateTimePicker1.Text;
            }
            return receipt;
        }

        private int prod1Amount() //runs calculation for product 1 total
        {
            int prod1Total = 0;
            int prod1Int = Convert.ToInt32(prod1.Text);
            prod1Total = prod1Int * 5;
            return prod1Total;
        }
        private int prod2Amount()//runs calculation for product 2 total
        {
            int prod2Total = 0;
            int prod2Int = Convert.ToInt32(prod2.Text);
            prod2Total = prod2Int * 10;
            return prod2Total;
        }

        private void clrForm_Click(object sender, EventArgs e) //clears form and initalizes everything again
        {
            this.Controls.Clear();
            this.InitializeComponent();
            InitializeDateTimePicker();
        }

        private void textBox1_MouseMove(object sender, EventArgs e) //sets tooltip to help user for name
        {
            toolTip1.SetToolTip(tipName, "Name can consist of letters and spaces");
        }

        private void textBox2_MouseMove(object sender, EventArgs e)//sets tooltip to help user for phone number
        {
            toolTip1.SetToolTip(tipPhone, "Phone number can consist of digits, maximum 10");
        }

        private void codeTip_TextChanged(object sender, EventArgs e)//sets tooltip to help user for postal code
        {
            toolTip1.SetToolTip(tipPhone, "Postal Code can only be entered in the following format: A1A1A1");
        }

        public static bool PostCodeVerify(string posCode) //postal code verification of syntax
        {
            Regex regex = new Regex(@"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]+$");
            return regex.IsMatch(posCode);
        }


        private async void postalCode_KeyPress(object sender, KeyPressEventArgs e) //checks for postal code input 
        {
            while (postalCode.TextLength < postalCode.MaxLength)
            {
                await Task.Delay(1);
                if (postalCode.TextLength == postalCode.MaxLength)
                {
                    PostCodeVerify(postalCode.Text);
                    if (PostCodeVerify(postalCode.Text) == true)
                    {

                        break;
                    }
                    else
                    {
                        postalCode.Clear();
                        MessageBox.Show(
                         "Invalid Postal Code entry, remember, capital letters and numbers only. Must be inputted as format A1A1A1.",
                         "Error",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error //For Info Asterisk
                        );
                        postalCode.Focus();
                    }
                }
            }

        }
    }
}