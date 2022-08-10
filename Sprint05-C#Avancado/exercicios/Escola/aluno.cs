using System.Text.RegularExpressions;

namespace Escola
{
    public partial class aluno : Form
    {
        ClasseAluno alunoClasse = new ClasseAluno();

        public aluno()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float media = calcularMedia(float.Parse(txtNotaUm.Text), float.Parse(txtNotaDois.Text), float.Parse(txtNotaTres.Text));
            String situacao = verificaSituacao(media);

            lblSituacao.Text = situacao;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            alunoClasse.Nome = txtNome.Text;
            alunoClasse.Endereco = txtEndereco.Text;
            alunoClasse.DataNasc = DateTime.Parse(datePickerDataNasc.Text);
            alunoClasse.Nota1 = float.Parse(txtNotaUm.Text);
            alunoClasse.Nota2 = float.Parse(txtNotaDois.Text);
            alunoClasse.Nota3 = float.Parse(txtNotaTres.Text);

            float media = calcularMedia(alunoClasse.Nota1, alunoClasse.Nota2, alunoClasse.Nota3);
            String situacao = verificaSituacao(media);

            String resultado = 
            "Nome: " + alunoClasse.Nome +
            "\nEndereço: " + alunoClasse.Endereco +
            "\nSua Média: " + media +
            "\nSua situação é: " + situacao;

            lblResultado.Text = resultado;
        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNotaDois_TextChanged(object sender, EventArgs e)
        {
            float numero = float.Parse(txtNotaDois.Text);
            bool status = verificaNotaInformada(numero);
            if (status)
            {
                txtNotaDois.Text = "";
            }
        }

        private void txtNotaUm_TextChanged(object sender, EventArgs e)
        {
            float numero = float.Parse(txtNotaUm.Text);
            bool status = verificaNotaInformada(numero);
            if (status)
            {
                txtNotaUm.Text = "";
            }
        }

        private void txtNotaTres_TextChanged(object sender, EventArgs e)
        {
            float numero = float.Parse(txtNotaTres.Text);
            bool status = verificaNotaInformada(numero);
            if (status)
            {
                txtNotaTres.Text = "";
            }
        }

        private bool verificaNotaInformada(float numero)
        {
            if (numero > 10)
            {
                MessageBox.Show("Informe um valor menor ou igual à 10", "Tela de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } else
            {
                return true;
            }
        }

        private float calcularMedia(float nota1, float nota2, float nota3)
        {
            float soma = 0;
            float media = 0;

            soma = nota1 + nota2 + nota3;

            if ((soma / 3) < 0)
            {
                return media;
            }
            else
            {
                return media = float.Parse(String.Format("{0:0.00}", soma / 3));
            }
        }

        private string verificaSituacao(float media)
        {
            String situacao = "Situação: ";

            if (media >= 7)
            {
                situacao += "Aprovado!";
            }
            else
            {
                situacao += "Reprovado!";
            }

            return situacao;
        }
    }
}