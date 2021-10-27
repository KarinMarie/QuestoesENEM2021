using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_2C.Classes;
using System.Runtime.InteropServices;

namespace Trabalho_2C
{
    public partial class Questoes : Form
    {
        List<string> Materia;
        string diretorioAtual;
        string diretorioRed;
        string diretorioEstatisticas = Directory.GetCurrentDirectory() + @"\estatisticas.txt";
        string caminho;
        string caminhoR;
        Pergunta pergunta;
        List<string> red;
        List<string> jafoi = new List<string>();

        DateTime Data;
        int acertosUsuario = 0;
        int errosUsuario = 0;

        string arquivoQuestAtual;

        Menu menu;

        int acertadas = 0;
        int erradas = 0;

        Graficos graficos;
        ToolTip msg;

        bool NaQuest = false;
        public Questoes()
        {
            InitializeComponent();

            msg = new ToolTip();
            graficos = new Graficos(chartUsuario);
            btnLimparDisciplina.Enabled = false;

            Materia = new List<string>();
            Materia.Add("Banco de Dados");
            Materia.Add("Biologia");
            Materia.Add("Desenho");
            Materia.Add("Ed. Física");
            Materia.Add("Filosofia");
            Materia.Add("Física");
            Materia.Add("Geografia");
            Materia.Add("História");
            Materia.Add("Linguagem de Programação 2");
            Materia.Add("Literatura");
            Materia.Add("Matemática");
            Materia.Add("Português");
            Materia.Add("Química");
            Materia.Add("Sociologia");

            pergunta = new Pergunta();

            // Esse método retornará o diretório de onde o programa está rodando.
            // Geralmente, o programa é um arquivo .exe armazenado na pasta bin do projeto.
            // Armazenar o diretório da pasta de questões dessa forma torna o programa independente do computador,
            // ou seja, não precisamos nos preocupar com o caminho que mudará de máquina para máquina
            diretorioAtual = Directory.GetCurrentDirectory();
            diretorioRed = Directory.GetCurrentDirectory();

            diretorioAtual += @"\Questões\";

            string[] diretorios = Directory.GetDirectories(diretorioAtual);

            foreach (string diretorio in diretorios)
            {
                string nomeDaDisciplina = diretorio.Remove(0, diretorioAtual.Length);
                cbDisciplina.Items.Add(nomeDaDisciplina);
            }

            diretorioRed += @"\Redação\";
            string[] filered = Directory.GetFiles(diretorioRed);

            foreach (string redd in filered)
            {
                string nomeRed = redd.Remove(0, diretorioRed.Length);

                nomeRed = nomeRed.Replace(".TXT", "");
                cbRedacao.Items.Add(nomeRed);
            }

           /* labelIntro.ForeColor = Color.BlueViolet;
            labelDes1.ForeColor = Color.Aqua;
            labelDes2.ForeColor = Color.Blue;
            labelConc.ForeColor = Color.DarkTurquoise;*/

            rbA.AutoCheck = false;
            rbB.AutoCheck = false;
            rbC.AutoCheck = false;
            rbD.AutoCheck = false;
            rbE.AutoCheck = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLimparDisciplina.Enabled = true;
            cbDisciplina.Enabled = false;
            progressBar.Maximum = 0;
            progressBar.Value = 0;
            lblAcertos.Text = "0% de Acertos";

            btnProximaPergunta.Enabled = false;
            btnResponder.Enabled = true;

            rbA.AutoCheck = true;
            rbB.AutoCheck = true;
            rbC.AutoCheck = true;
            rbD.AutoCheck = true;
            rbE.AutoCheck = true;

            rbA.ForeColor = Color.Black;
            rbB.ForeColor = Color.Black;
            rbC.ForeColor = Color.Black;
            rbD.ForeColor = Color.Black;
            rbE.ForeColor = Color.Black;

            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
            rbE.Checked = false;

            txtResolucao.Text = "";

            acertadas = 0;

            caminho = diretorioAtual + Materia[cbDisciplina.SelectedIndex];
            aleatorioVai();
            NaQuest = true;
        }

        private void aleatorioVai()
        {
            Random rand = new Random();

            string[] filesPathes = Directory.GetFiles(caminho, "*.txt");

            string i = filesPathes[rand.Next(filesPathes.Length)];

            for (int j = 0; j < 1; j++)
            {
                if (jafoi.Count() == filesPathes.Length)
                {
                    MessageBox.Show("As questões acabaram, vá para outra disciplina.");
                    InserirUsuario(Materia[cbDisciplina.SelectedIndex]);

                    cbDisciplina.Enabled = true;
                    txtGraficoAusente.Hide();
                    graficos.GraficosUsuario(acertosUsuario, errosUsuario, Materia[cbDisciplina.SelectedIndex]);

                    tabControl1.SelectedTab = tabPage4;

                    acertosUsuario = 0;
                    errosUsuario = 0;

                    /*progressBar.Maximum = 0;
                    progressBar.Value = 0;
                    lblAcertos.Text = "0% de Acertos";

                    rbA.ForeColor = Color.Black;
                    rbB.ForeColor = Color.Black;
                    rbC.ForeColor = Color.Black;
                    rbD.ForeColor = Color.Black;
                    rbE.ForeColor = Color.Black;

                    rbA.Text = "";
                    rbB.Text = "";
                    rbC.Text = "";
                    rbD.Text = "";
                    rbE.Text = "";

                    txtResolucao.Text = "";
                    txtEnunciado.Text = " ";*/

                    jafoi.Clear();
                    break;
                }

                else if (jafoi.Contains(i))
                {
                    i = filesPathes[rand.Next(filesPathes.Length)];
                    j--;
                }
            }

            CarregarPergunta(i);
            Acertos(i);
            jafoi.Add(i);
            arquivoQuestAtual = i;
        }
        private void cbRedacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            red = new List<string>();
            red.Add("Redação 2012");
            red.Add("Redação 2013");
            red.Add("Redação 2014");
            red.Add("Redação 2015");
            red.Add("Redação 2016");
            red.Add("Redação 2017");
            red.Add("Redação 2018");
            red.Add("Redação 2019");
            red.Add("Redação 2020");

            caminhoR = diretorioRed + red[cbRedacao.SelectedIndex] + ".txt";
            CarregarRedacao(caminhoR);
        }
        private void CarregarPergunta(string caminho)
        {
            StreamReader leitor = new StreamReader(caminho);

            pergunta.Enunciado = leitor.ReadLine();
            pergunta.AltA = leitor.ReadLine();
            pergunta.AltB = leitor.ReadLine();
            pergunta.AltC = leitor.ReadLine();
            pergunta.AltD = leitor.ReadLine();
            pergunta.AltE = leitor.ReadLine();
            pergunta.Resolucao = leitor.ReadLine();
            pergunta.Letra = leitor.ReadLine();
            pergunta.Acertos = leitor.ReadLine();
            pergunta.Erros = leitor.ReadLine();

            txtEnunciado.Text = pergunta.Enunciado;
            rbA.Text = pergunta.AltA;
            rbB.Text = pergunta.AltB;
            rbC.Text = pergunta.AltC;
            rbD.Text = pergunta.AltD;
            rbE.Text = pergunta.AltE;

            leitor.Close();
        }

        private void CarregarRedacao(string caminhoR)
        {
            StreamReader leitor = new StreamReader(caminhoR);

            textTema.Text = leitor.ReadLine();

            textIntro.Text = leitor.ReadLine();

            textDes1.Text = leitor.ReadLine();

            textDes2.Text = leitor.ReadLine();

            textConc.Text = leitor.ReadLine();

            leitor.Close();

        }

        private void btnProximaPergunta_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(caminho))
            {
                MessageBox.Show("Escolha uma disciplina.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnProximaPergunta.Enabled = false;
            btnResponder.Enabled = true;

            rbA.AutoCheck = true;
            rbB.AutoCheck = true;
            rbC.AutoCheck = true;
            rbD.AutoCheck = true;
            rbE.AutoCheck = true;

            aleatorioVai();

            rbA.ForeColor = Color.Black;
            rbB.ForeColor = Color.Black;
            rbC.ForeColor = Color.Black;
            rbD.ForeColor = Color.Black;
            rbE.ForeColor = Color.Black;

            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
            rbE.Checked = false;

            txtResolucao.Text = "";
        }

        private void Acertos(string path)
        {
            StreamWriter escritor = new StreamWriter(path);

            escritor.WriteLine(pergunta.Enunciado);
            escritor.WriteLine(pergunta.AltA);
            escritor.WriteLine(pergunta.AltB);
            escritor.WriteLine(pergunta.AltC);
            escritor.WriteLine(pergunta.AltD);
            escritor.WriteLine(pergunta.AltE);
            escritor.WriteLine(pergunta.Resolucao);
            escritor.WriteLine(pergunta.Letra);
            escritor.WriteLine(pergunta.Acertos);
            escritor.WriteLine(pergunta.Erros);

            escritor.Close();

            try
            {
                progressBar.Maximum = Convert.ToInt32(pergunta.Acertos) + Convert.ToInt32(pergunta.Erros);
                progressBar.Value = Convert.ToInt32(pergunta.Acertos);

                if (progressBar.Maximum == 0 && progressBar.Value == 0)
                    lblAcertos.Text = "0% de Acertos";
                else
                {
                    double porcentagem = Math.Round(Convert.ToDouble(progressBar.Value) / Convert.ToDouble(progressBar.Maximum), 2) * 100;
                    lblAcertos.Text = porcentagem + "% de acertos";
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            acertadas = Convert.ToInt32(pergunta.Acertos);
            erradas = Convert.ToInt32(pergunta.Erros);

            rbA.AutoCheck = false;
            rbB.AutoCheck = false;
            rbC.AutoCheck = false;
            rbD.AutoCheck = false;
            rbE.AutoCheck = false;

            btnResponder.Enabled = false;
            btnProximaPergunta.Enabled = true;

            if (pergunta.Letra == "A")
            {
                if (rbA.Checked)
                {
                    rbA.ForeColor = Color.Green;
                    txtResolucao.Text = pergunta.Resolucao;
                    acertadas++;
                    pergunta.Acertos = acertadas.ToString();

                    acertosUsuario++;
                }
                else
                {
                    rbA.ForeColor = Color.Green;
                    erradas++;
                    pergunta.Erros = erradas.ToString();

                    errosUsuario++;

                    if (rbB.Checked) rbB.ForeColor = Color.Red;
                    else if (rbC.Checked) rbC.ForeColor = Color.Red;
                    else if (rbD.Checked) rbD.ForeColor = Color.Red;
                    else if (rbE.Checked) rbE.ForeColor = Color.Red;

                    txtResolucao.Text = pergunta.Resolucao;
                }
            }

            if (pergunta.Letra == "B")
            {
                if (rbB.Checked)
                {
                    rbB.ForeColor = Color.Green;
                    txtResolucao.Text = pergunta.Resolucao;
                    acertadas++;
                    pergunta.Acertos = acertadas.ToString();

                    acertosUsuario++;
                }
                else
                {
                    rbB.ForeColor = Color.Green;
                    erradas++;
                    pergunta.Erros = erradas.ToString();

                    errosUsuario++;

                    if (rbA.Checked) rbA.ForeColor = Color.Red;
                    else if (rbC.Checked) rbC.ForeColor = Color.Red;
                    else if (rbD.Checked) rbD.ForeColor = Color.Red;
                    else if (rbE.Checked) rbE.ForeColor = Color.Red;

                    txtResolucao.Text = pergunta.Resolucao;
                }
            }

            if (pergunta.Letra == "C")
            {
                if (rbC.Checked)
                {
                    rbC.ForeColor = Color.Green;
                    txtResolucao.Text = pergunta.Resolucao;
                    acertadas++;
                    pergunta.Acertos = acertadas.ToString();

                    acertosUsuario++;
                }
                else
                {
                    rbC.ForeColor = Color.Green;
                    erradas++;
                    pergunta.Erros = erradas.ToString();

                    errosUsuario++;

                    if (rbB.Checked) rbB.ForeColor = Color.Red;
                    else if (rbA.Checked) rbA.ForeColor = Color.Red;
                    else if (rbD.Checked) rbD.ForeColor = Color.Red;
                    else if (rbE.Checked) rbE.ForeColor = Color.Red;

                    txtResolucao.Text = pergunta.Resolucao;
                }
            }

            if (pergunta.Letra == "D")
            {
                if (rbD.Checked)
                {
                    rbD.ForeColor = Color.Green;
                    txtResolucao.Text = pergunta.Resolucao;
                    acertadas++;
                    pergunta.Acertos = acertadas.ToString();
                    Acertos(arquivoQuestAtual);

                    acertosUsuario++;
                }
                else
                {
                    rbD.ForeColor = Color.Green;
                    erradas++;
                    pergunta.Erros = erradas.ToString();

                    errosUsuario++;

                    if (rbB.Checked) rbB.ForeColor = Color.Red;
                    else if (rbC.Checked) rbC.ForeColor = Color.Red;
                    else if (rbA.Checked) rbA.ForeColor = Color.Red;
                    else if (rbE.Checked) rbE.ForeColor = Color.Red;

                    txtResolucao.Text = pergunta.Resolucao;
                }
            }

            if (pergunta.Letra == "E")
            {
                if (rbE.Checked)
                {
                    rbE.ForeColor = Color.Green;
                    txtResolucao.Text = pergunta.Resolucao;
                    acertadas++;
                    pergunta.Acertos = acertadas.ToString();

                    acertosUsuario++;
                }
                else
                {
                    rbE.ForeColor = Color.Green;
                    erradas++;
                    pergunta.Erros = erradas.ToString();

                    errosUsuario++;

                    if (rbB.Checked) rbB.ForeColor = Color.Red;
                    else if (rbC.Checked) rbC.ForeColor = Color.Red;
                    else if (rbD.Checked) rbD.ForeColor = Color.Red;
                    else if (rbA.Checked) rbA.ForeColor = Color.Red;

                    txtResolucao.Text = pergunta.Resolucao;
                }
            }
            Acertos(arquivoQuestAtual);
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            Hide();
            menu.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            string enunciado;
            string altA;
            string altB;
            string altC;
            string altD;
            string altE;
            string resolucao;
            string letra;

            string[] filesPathes = Directory.GetFiles(caminho, "*.txt");

            for(int i = 0; i < filesPathes.Length; i++)
            {
                StreamReader leitor = new StreamReader(filesPathes[i]);

                enunciado = leitor.ReadLine();
                altA = leitor.ReadLine();
                altB = leitor.ReadLine();
                altC = leitor.ReadLine();
                altD = leitor.ReadLine();
                altE = leitor.ReadLine();
                resolucao = leitor.ReadLine();
                letra = leitor.ReadLine();

                leitor.Close();

                StreamWriter escritor = new StreamWriter(filesPathes[i]);

                escritor.WriteLine(enunciado);
                escritor.WriteLine(altA);
                escritor.WriteLine(altB);
                escritor.WriteLine(altC);
                escritor.WriteLine(altD);
                escritor.WriteLine(altE);
                escritor.WriteLine(resolucao);
                escritor.WriteLine(letra);
                escritor.WriteLine("0");
                escritor.WriteLine("0");

                escritor.Close();
            }

            progressBar.Maximum = 0;
            progressBar.Value = 0;
            lblAcertos.Text = "0% de Acertos";
        }

        public void InserirUsuario(string materia)
        {  
            string nomeUsuario;
            string materiaUsuario = materia;
            Data = DateTime.Now;
            string dataUsuario = Data.ToString();

            if (txtNome.Text == "")
                nomeUsuario = "Usuário";
            else
                nomeUsuario = txtNome.Text;

            StreamWriter escritor = new StreamWriter(diretorioEstatisticas, true);
            escritor.WriteLine(nomeUsuario + " - " + materiaUsuario + " - Acertos: " + acertosUsuario + " - Erros: " + errosUsuario + " - Data: " + dataUsuario + ".");

            escritor.Close();
        }

        public void AtualizarEstatistica()
        {
            List<string> Estatisticas = new List<string>();

            lbEstatisticas.Items.Clear();

            using (StreamReader leitor = new StreamReader(diretorioEstatisticas))
            {
                while (!leitor.EndOfStream)
                {
                    string linha_lida = leitor.ReadLine();
                    Estatisticas.Add(linha_lida);
                }
            }

            for(int i = 0; i < Estatisticas.Count; i++)
            {
                lbEstatisticas.Items.Add(Estatisticas[i]);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            AtualizarEstatistica();
        }

        private void btnApagarUsuario_Click(object sender, EventArgs e)
        {
            if(lbEstatisticas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o usuário a ser apagado!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> Estatisticas = new List<string>();

            lbEstatisticas.Items.RemoveAt(lbEstatisticas.SelectedIndex);

            for (int i = 0; i < lbEstatisticas.Items.Count; i++)
            {
                Estatisticas.Add(lbEstatisticas.Items[i].ToString());
            }

            StreamWriter escritor = new StreamWriter(diretorioEstatisticas);

            for (int i = 0; i < Estatisticas.Count; i++)
            {
                escritor.WriteLine(Estatisticas[i]);
            }

            escritor.Close();
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            lbEstatisticas.Items.Clear();

            StreamWriter escritor = new StreamWriter(diretorioEstatisticas);

            escritor.Write("");

            escritor.Close();
        }

        private void Questoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void rbA_MouseHover(object sender, EventArgs e)
        {
            if(NaQuest)
            {
                msg.Show(pergunta.AltA, rbA);
                return;
            }
        }

        private void rbB_MouseHover(object sender, EventArgs e)
        {
            if (NaQuest)
            {
                msg.Show(pergunta.AltB, rbB);
                return;
            }
        }

        private void rbC_MouseHover(object sender, EventArgs e)
        {
            if (NaQuest)
            {
                msg.Show(pergunta.AltC, rbC);
                return;
            }
        }

        private void rbD_MouseHover(object sender, EventArgs e)
        {
            if (NaQuest)
            {
                msg.Show(pergunta.AltD, rbD);
                return;
            }
        }

        private void rbE_MouseHover(object sender, EventArgs e)
        {
            if (NaQuest)
            {
                msg.Show(pergunta.AltE, rbE);
                return;
            }
        }

        private void btn_fechatudoquest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizaquest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}