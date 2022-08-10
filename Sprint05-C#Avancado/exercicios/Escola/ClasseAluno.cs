using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class ClasseAluno
    {
        private String nome;
        private String endereco;
        private DateTime dataNasc;
        private float nota1;
        private float nota2;
        private float nota3;
        private String situacao;
        private String resultado;

        public ClasseAluno()
        {
            nome = "";
            endereco = "";
            dataNasc = DateTime.Now;
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
            situacao = "";
            resultado = "";
        }

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime DataNasc { get => dataNasc; set => dataNasc = value; }
        public float Nota1 { get => nota1; set => nota1 = value; }
        public float Nota2 { get => nota2; set => nota2 = value; }
        public float Nota3 { get => nota3; set => nota3 = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public string Resultado { get => resultado; set => resultado = value; }
    }
}
