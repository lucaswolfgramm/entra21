namespace Tupla
{
    public partial class Form1 : Form
    {

        (double Soma, int Contar) d = (6.5, 44);
       
       


        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarTupla_Click(object sender, EventArgs e)
        {
            
            lblTupla.Text +="\n Primeiro Exemplo: "+ d.Soma.ToString()+"   "+d.Contar.ToString();
        }

        private void btnAlterarTupla_Click(object sender, EventArgs e)
        {
            lblTupla.Text = "";
            label2.Visible = true;
            label3.Visible = true;
            txtNum1.Visible = true;
            txtNum2.Visible = true;
            btnMostrar2.Visible = true;
            

        }

        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            d.Soma = double.Parse(txtNum1.Text);
            d.Contar = Convert.ToInt32(txtNum2.Text);
            lblTupla.Text += "\n Primeiro Exemplo: " + d.Soma.ToString() + "   " + d.Contar.ToString();
        }
    }
}