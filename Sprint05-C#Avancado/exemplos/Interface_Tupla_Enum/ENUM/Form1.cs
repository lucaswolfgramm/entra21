namespace Enum
{
    public partial class Form1 : Form
    {
        enum DiasSemana
        {
            Segunda,
            Terça,
            Quarta,
            Quinta,
            Sexta,
            Sabado,
            Domingo
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarEnum_Click(object sender, EventArgs e)
        {
            foreach (var item in DiasSemana.GetValues(typeof(DiasSemana)))
            {
                lblMostarEnum.Text += item + "   ";
                //lblMostarEnum.Text += "\n";
            }
            
        }
    }
}