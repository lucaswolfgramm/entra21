namespace calculadora
{
    public partial class calculadoraForm : Form
    {
        public calculadoraForm()
        {
            InitializeComponent();
            
        }

        List<string> caracteres = new List<string>();
        public List<string> Caracteres { get { return caracteres; } }

        private void calculadoraForm_Load(object sender, EventArgs e)
        {

        }

        public void gravarVisor(String valorTecla)
        {
            txtVisor.Text = txtVisor.Text + valorTecla;
            caracteres.Add(valorTecla);
        }

        private void um_Click(object sender, EventArgs e)
        {
            gravarVisor("1");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gravarVisor("2");
        }

        private void tres_Click(object sender, EventArgs e)
        {
            gravarVisor("3");
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            gravarVisor("4");
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            gravarVisor("5");
        }

        private void seis_Click(object sender, EventArgs e)
        {
            gravarVisor("6");
        }

        private void sete_Click(object sender, EventArgs e)
        {
            gravarVisor("7");
        }

        private void oito_Click(object sender, EventArgs e)
        {
            gravarVisor("8");
        }

        private void nove_Click(object sender, EventArgs e)
        {
            gravarVisor("9");
        }

        private void soma_Click(object sender, EventArgs e)
        {
            gravarVisor("+");
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            //txtVisor.Text = caracteres;
            //listBox
        }
    }
}