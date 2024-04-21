namespace VerificaRA
{
    public partial class Frm_VerificaRA : Form
    {

        private Aluno aluno1;
        private Aluno aluno2;

        public Frm_VerificaRA()
        {
            InitializeComponent();
    }

        private void btn_Verifica_Click(object sender, EventArgs e)
        {
            string numeroRegistro = txb_RA.Text;

            aluno1 = new Aluno("Matheus", "Análise e Desenvolvimento de Sistemas", "R021ED3");
            aluno2 = new Aluno("Stella", "Arquitetura e Urbanismo", "R021EC5");

            if (numeroRegistro == aluno1.NumeroRegistro)
            {
                MessageBox.Show($"Número de registro válido! \nSeja Bem vindo! \n\nNome: {aluno1.Nome} \nCurso: {aluno1.Curso} \nRA: {aluno1.NumeroRegistro}");
            }
            else if (numeroRegistro == aluno2.NumeroRegistro)
            {
                MessageBox.Show($"Número de registro válido! \nSeja Bem vindo! \n\nNome: {aluno2.Nome} \nCurso: {aluno2.Curso} \nRA: {aluno2.NumeroRegistro}");
            }
            else
            {
                MessageBox.Show("Número de registro inválido!");
            }
        }

        
    }
}
