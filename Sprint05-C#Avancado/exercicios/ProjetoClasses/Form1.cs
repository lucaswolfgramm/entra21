using System.Numerics;

namespace ProjetoClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cliente novoCliente = new Cliente();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                novoCliente.Nome = txtNome.Text;
                novoCliente.Endereco = txtEndereco.Text;
                novoCliente.Contato = maskedTxtContato.Text;
                novoCliente.LimiteCredito = double.Parse(maskedTxtLimiteCredito.Text);
                novoCliente.NumeroCartao = BigInteger.Parse(txtNumCartao.Text);
                novoCliente.DataNascimento = datePickerNasc.Value;
                MessageBox.Show("Cliente Cadastrado com Sucesso", "Aviso");
                novoCliente.verificaLimite();
                MessageBox.Show("Sua situação atual é: " +
                novoCliente.Status, "Aviso");
                txtNome.Text = ("Deu certo " + novoCliente.Nome);
                txtEndereco.Text = (novoCliente.Endereco);
                maskedTxtContato.Text = (novoCliente.Contato);
                maskedTxtLimiteCredito.Text = (novoCliente.LimiteCredito).ToString();
                txtNumCartao.Text = (novoCliente.NumeroCartao).ToString();
                datePickerNasc.Text = (novoCliente.DataNascimento).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de Conversão", "Falha no Cadastro");
                //MessageBox.Show(FormatException);
            }

        }

        private void datePickerNasc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNumCartao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumCartao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}