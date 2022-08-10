using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Pessoa_Professor_Aluno
{
    internal class Pessoa
    {
        private String matricula;
        private String nome;
        private Int64 cpf;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public Int64 Cpf { get => cpf; set => cpf = value; }
    }
}
