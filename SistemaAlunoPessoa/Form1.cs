using System.Windows.Forms.VisualStyles;

namespace SistemaAlunoPessoa
{
    public partial class form : Form
    {

        public form()
        {
            InitializeComponent();

        }
        public string arquivo(string nomeArquivo)
        {
            String arquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, (@"..\..\..\" + nomeArquivo));
            String caminhoArquivo = Path.GetFullPath(arquivo);

            return caminhoArquivo;
        }



        private void button_procurarArquivo_Click(object sender, EventArgs e)
        {
            StreamReader leitor = new StreamReader(arquivo(textBox_nomeArquivo.Text));
            String linha;
            String[] vetorDados;
            String[] vetorSalvaDados = { "" };
            int contadorPessoa = 0;
            int contadorAluno = 0;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split("-");
                if (vetorDados[0] == "Z")
                {
                    vetorSalvaDados = vetorDados;
                    contadorPessoa++;
                    textBox_listaPessoa.AppendText("Nome: " + vetorDados[1] + "-" + "CPF: " +
                                                        vetorDados[5] + Environment.NewLine);

                    textBox_numeroPessoas.Text = contadorPessoa.ToString();
                }
                
                if (vetorDados[0] == "Y")
                {
                    contadorAluno++;
                    textBox_listaPessoa.AppendText("Curso: " + vetorDados[3] + Environment.NewLine);
                    textBox_numeroAlunos.Text = contadorAluno.ToString();
                }
                

            } while (!leitor.EndOfStream);
            leitor.Close();


        }
    }
}