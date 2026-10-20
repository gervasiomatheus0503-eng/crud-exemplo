namespace CrudExemplo
{
    public partial class btsalvar : Form
    {
        String nome, sobrenome, curso, RM;

        int ano, idade;
        public btsalvar()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome = textBoxNome.Text;
            sobrenome = textBoxSobre.Text;
            curso = textBoxCurso.Text;
            RM = textBoxRM.Text;

            ano = Convert.ToInt32(textBoxAno.Text);
            idade = Convert.ToInt32(textBoxIdade.Text);
        }
    }
}
