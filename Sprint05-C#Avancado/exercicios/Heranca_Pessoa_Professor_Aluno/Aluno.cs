using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_Pessoa_Professor_Aluno
{
    internal class Aluno : Pessoa
    {
        private float notaUm;
        private float notaDois;
        private float notaTres;
        private float media;

        public float NotaUm { get => notaUm; set => notaUm = value; }
        public float NotaDois { get => notaDois; set => notaDois = value; }
        public float NotaTres { get => notaTres; set => notaTres = value; }
        public float Media { get => media; set => media = value; }

        public float calcularMedia(float nota1, float nota2, float nota3)
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
    }
}
