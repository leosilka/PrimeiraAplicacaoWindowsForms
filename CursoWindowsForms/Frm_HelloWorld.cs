namespace CursoWindowsForms
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_RevelaTexto_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModificaTexto_Click(object sender, EventArgs e)
        {
            lbl_RevelaTexto.Text = txt_ConteudoLabel.Text;
        }
    }
}