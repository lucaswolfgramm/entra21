namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPato_Click(object sender, EventArgs e)
        {
            Pato novoPato = new Pato();  //
            novoPato.Voar();
        }
    }
}