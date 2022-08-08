using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoClasses
{
    internal class Cliente
    {
        private string nome;
        private string endereco;
        private string contato;
        private double limiteCredito;
        private BigInteger numeroCartao;
        private string status;
        DateTime dataNasc;

        //Método Construtor
        public Cliente()
        {
            this.nome = "";
            this.endereco = "";
            this.contato = "";
            this.limiteCredito = 0;
            this.numeroCartao = 0;
            this.status = "";
            dataNasc = DateTime.Today; //inicializa com a data de hoje
        }
 
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Contato { get => contato; set => contato = value; }
        public double LimiteCredito { get => limiteCredito; set => limiteCredito = value; }
        public BigInteger NumeroCartao { get => numeroCartao; set => numeroCartao = value; }
        public DateTime DataNascimento { get => dataNasc; set => dataNasc = value; }
        public string Status { get => status; set => status = value; }


        
        //Método para verificar limite de crédito
        public void verificaLimite()
        {
            if (this.limiteCredito < 1000)
            {
                this.status = "Bloqueado";
            }
            else
            {
                this.status = "Liberado";
            }
        }

    }
}
