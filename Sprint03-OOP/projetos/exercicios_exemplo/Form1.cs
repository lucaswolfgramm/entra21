namespace exercicios_exemplo
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

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(txbNumero.Text);
            if (num < 0)
                MessageBox.Show("INFORMOU NEGATIVO");
            else
                MessageBox.Show("INFORMOU POSITIVO");
            label4.Visible = true;
            txbResultado.Visible = true;
            txbResultado.Text = num.ToString();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txbNome.Text;
            MessageBox.Show("Olá " + nome, "Tela de Boas-Vindas");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label4.Visible = false;
            txbResultado.Visible = false;
            txbResultado.Text = "";
            txbNome.Text = "";
            txbNumero.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}