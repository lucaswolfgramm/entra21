using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Pato : IVoa, IAnda, INada
    {
        public void Andar()
        {
            MessageBox.Show("Anda Passarinho Anda Passarinho", "ANDANDO");
        }

        public void Nadar()
        {
            MessageBox.Show("Nada Passarinho Nada Passarinho", "Nadando");
        }

        public void Voar()
        {
            MessageBox.Show("Voa Passarinho Voa Passarinho", "VOANDO");
        }
    }
}
