using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios_exemplo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void loading()
        {
            panelBackground.BringToFront();
            progressBar1.BringToFront();

            panelBackground.Visible = true;
            progressBar1.Visible = true;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(1);
            }

            panelBackground.SendToBack();
            progressBar1.SendToBack();

            panelBackground.Visible = false;
            progressBar1.Visible = false;
        }

        private void txbIdade_TextChanged(object sender, EventArgs e)
        {
            btnVerificar.Enabled = true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            loading();

            try
            {
                if (Convert.ToInt32(txbIdade.Text) >= 18)
                {
                    txbResultado.Text = "Maior de Idade!";
                    txbResultado.ForeColor = Color.Green;
                }
                else
                {
                    txbResultado.Text = "Menor de Idade!";
                    txbResultado.ForeColor = Color.Red;
                }
            } catch { 
                MessageBox.Show("Erro de entrada de valores", "Tela de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
