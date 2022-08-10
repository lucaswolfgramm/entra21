using System.Text.RegularExpressions;

namespace Heranca_Pessoa_Professor_Aluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pessoa pessoa = new Pessoa();
        Professor professor = new Professor();
        Aluno aluno = new Aluno();

        private string tipoPessoa = "";

        private void radioBtnProfessor_Click(object sender, EventArgs e)
        {

            tipoPessoa = "P";

            lblMedia.Visible = false;
            txtMedia.Visible = false;
            groupBoxNotas.Visible = false;
            lblSalario.Visible = true;
            txtSalario.Visible = true;


            btnCadastrar.Text = "Cadastrar Professor";
            btnCadastrar.Enabled = true;
        }

        private void radioBtnAluno_Click(object sender, EventArgs e)
        {
            tipoPessoa = "A";

            lblMedia.Visible = true;
            txtMedia.Visible = true;
            groupBoxNotas.Visible = true;
            lblSalario.Visible = false;
            txtSalario.Visible = false;

            btnCadastrar.Text = "Cadastrar Aluno";
            btnCadastrar.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                pessoa.Matricula = txtMatricula.Text;
                pessoa.Nome = txtNome.Text;
                pessoa.Cpf = Int64.Parse(txtCPF.Text);
                if (tipoPessoa == "P")
                {
                    professor.Salario = float.Parse(txtSalario.Text);
                }
                else
                {
                    if (tipoPessoa == "A")
                    {
                        aluno.NotaUm = float.Parse(txtNotaUm.Text);
                        aluno.NotaDois = float.Parse(txtNotaDois.Text);
                        aluno.NotaTres = float.Parse(txtNotaTres.Text);
                        txtMedia.Text = Convert.ToString(aluno.calcularMedia(aluno.NotaUm, aluno.NotaDois, aluno.NotaTres));
                    }
                    else                    
                    {
                        MessageBox.Show("Não foi possível identificar o tipo de pessoa para cadastro. \n Tente novamente!", "Erro", MessageBoxButtons.OK);
                    }
                }

                MessageBox.Show(pessoa.Matricula + "\n" + pessoa.Nome + "\n" + professor.Salario + "\n" + aluno.Media, "Sucesso", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro na aplicação. \n Contate o suporte!", "Erro", MessageBoxButtons.OK);
            }
        }

        private void txtNotaUm_Leave(object sender, EventArgs e)
        {
            if(txtNotaUm.Text.Replace(",", string.Empty).Replace(" ", string.Empty) != "")
            {
                MessageBox.Show(txtNotaUm.Text);
                float numero = float.Parse(txtNotaUm.Text);
                bool status = aluno.verificaNotaInformada(numero);
                if (!status)
                {
                    txtNotaUm.Text = "";
                }
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (!pessoa.validarCPF(txtCPF.Text))
            {
                MessageBox.Show("O número é um CPF Inválido !");
            }
        }
    }
}