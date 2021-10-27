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
using System.Runtime.InteropServices;

namespace Trabalho_2C
{
    public partial class Cadastro : Form
    {
        string diretorioAtual;
        string caminho;

        Menu menu;

        public Cadastro()
        {
            InitializeComponent();

            diretorioAtual = Directory.GetCurrentDirectory();

            diretorioAtual += @"\Questões\";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtEnunciadoCad.Text == "" || txtACad.Text == "" || txtBCad.Text == "" || txtCCad.Text == "" || txtDCad.Text == "" || txtECad.Text == "" || txtResolucaoCad.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(cbDisciplinaCad.SelectedIndex == 0)
            {
                caminho = diretorioAtual + @"Banco de Dados\" + numQuestao.Value + ".txt";
            }

            else if(cbDisciplinaCad.SelectedIndex == 1)
            {
                caminho = diretorioAtual + @"Biologia\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 2)
            {
                caminho = diretorioAtual + @"Desenho\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 3)
            {
                caminho = diretorioAtual + @"Ed. Física\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 4)
            {
                caminho = diretorioAtual + @"Filosofia\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 5)
            {
                caminho = diretorioAtual + @"Física\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 6)
            {
                caminho = diretorioAtual + @"Geografia\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 7)
            {
                caminho = diretorioAtual + @"História\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 8)
            {
                caminho = diretorioAtual + @"Linguagem de Programação 2\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 9)
            {
                caminho = diretorioAtual + @"Literatura\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 10)
            {
                caminho = diretorioAtual + @"Matemática\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 11)
            {
                caminho = diretorioAtual + @"Português\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 12)
            {
                caminho = diretorioAtual + @"Química\" + numQuestao.Value + ".txt";
            }

            else if (cbDisciplinaCad.SelectedIndex == 13)
            {
                caminho = diretorioAtual + @"Sociologia\" + numQuestao.Value + ".txt";
            }

            if(File.Exists(caminho))
            {
                MessageBox.Show("Esse número já existe, tente outro.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StreamWriter escritor = new StreamWriter(caminho);

            escritor.WriteLine(txtEnunciadoCad.Text);
            escritor.WriteLine(txtACad.Text);
            escritor.WriteLine(txtBCad.Text);
            escritor.WriteLine(txtCCad.Text);
            escritor.WriteLine(txtDCad.Text);
            escritor.WriteLine(txtECad.Text);
            escritor.WriteLine(txtResolucaoCad.Text);

            if (rbACad.Checked) escritor.WriteLine("A");
            else if (rbBCad.Checked) escritor.WriteLine("B");
            else if (rbCCad.Checked) escritor.WriteLine("C");
            else if (rbDCad.Checked) escritor.WriteLine("D");
            else if (rbECad.Checked) escritor.WriteLine("E");

            escritor.WriteLine("0");
            escritor.WriteLine("0");

            escritor.Close();

            MessageBox.Show("Questão cadastrada com sucesso!");
            txtEnunciadoCad.Text = "";
            txtACad.Text = "";
            txtBCad.Text = "";
            txtCCad.Text = "";
            txtDCad.Text = "";
            txtECad.Text = "";
            txtResolucaoCad.Text = "";
            numQuestao.Value = 1;
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            Hide();
            menu.ShowDialog();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Cadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_fechatudocad_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizacad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
