namespace LAB20_Lucero
{
    public partial class Form1 : Form
    {
        double firstNum, secondNum;
        string ops;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            ops = "/";
            txtDisplay.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            ops = "*";
            txtDisplay.Text = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            ops = "-";
            txtDisplay.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(txtDisplay.Text);
            ops = "+";
            txtDisplay.Text = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = Convert.ToString(-1 * a);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;

            f = Convert.ToString(firstNum);
            s = Convert.ToString(secondNum);

            f = "";
            s = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNum = double.Parse(txtDisplay.Text);

            switch (ops)
            {
                case "/":
                    txtDisplay.Text = (firstNum / secondNum).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (firstNum * secondNum).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (firstNum - secondNum).ToString();
                    break;
                case "+":
                    txtDisplay.Text = (firstNum + secondNum).ToString();
                    break;

                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}