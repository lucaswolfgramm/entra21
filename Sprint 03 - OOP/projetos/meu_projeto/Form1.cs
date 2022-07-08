namespace meu_projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonForm2_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.Show();
        }

        private void buttonForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}