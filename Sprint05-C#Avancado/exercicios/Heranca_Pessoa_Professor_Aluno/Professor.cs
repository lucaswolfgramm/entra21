using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Pessoa_Professor_Aluno
{
    internal class Professor : Pessoa
    {
        private float salario;

        public float Salario { get => salario; set => salario = value; }
    }
}
