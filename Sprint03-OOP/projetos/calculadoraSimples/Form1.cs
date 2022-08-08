namespace calculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd'-'MM'-'yyyy");
            //dateTimePicker1.Value = DateTime.Now;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                if (e.KeyChar == ',' || e.KeyChar == '.')
                {
                    e.KeyChar = ',';
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNum1_Leave(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                btnDividir.Enabled = true;
                btnSomar.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplicar.Enabled = true;
            }
        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                btnDividir.Enabled = true;
                btnSomar.Enabled = true;
                btnSubtrair.Enabled = true;
                btnMultiplicar.Enabled = true;
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                float num1, num2, result;
                num1 = float.Parse(txtNum1.Text);
                num2 = float.Parse(txtNum2.Text);
                result = num1 + num2;
                txtResultado.Text = result.ToString();
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                float num1, num2, result;
                num1 = float.Parse(txtNum1.Text);
                num2 = float.Parse(txtNum2.Text);
                result = num1 - num2;
                txtResultado.Text = result.ToString();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                float num1, num2, result;
                num1 = float.Parse(txtNum1.Text);
                num2 = float.Parse(txtNum2.Text);
                result = num1 * num2;
                txtResultado.Text = result.ToString();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if ((txtNum1.Text != string.Empty) && (txtNum2.Text != string.Empty))
            {
                float num1, num2, result;
                num1 = float.Parse(txtNum1.Text);
                num2 = float.Parse(txtNum2.Text);
                result = num1 / num2;
                txtResultado.Text = result.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
            btnDividir.Enabled = false;
            btnSomar.Enabled = false;
            btnSubtrair.Enabled = false;
            btnMultiplicar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}