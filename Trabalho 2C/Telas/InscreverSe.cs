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

namespace Trabalho_2C.Telas
{
    public partial class InscreverSe : Form
    {
        string diretorio = Directory.GetCurrentDirectory() + @"\Cadastro";

        public InscreverSe()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void InscreverSe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtSenha.Text == "" || txtConfirmarSenha.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtSenha.Text.Contains(" "))
            {
                MessageBox.Show("Sua senha não pode conter espaços.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtUsuario.Text.Trim().Length < 6)
            {
                MessageBox.Show("O usuário deve ter, pelo menos, 6 dígitos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtSenha.Text.Trim().Length < 6)
            {
                MessageBox.Show("A senha deve ter, pelo menos, 6 dígitos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("Senhas incompatíveis!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!txtSenha.Text.Contains("1") && !txtSenha.Text.Contains("2") && !txtSenha.Text.Contains("3")
                && !txtSenha.Text.Contains("4") && !txtSenha.Text.Contains("5") && !txtSenha.Text.Contains("6")
                && !txtSenha.Text.Contains("7") && !txtSenha.Text.Contains("8") && !txtSenha.Text.Contains("9"))
            {
                MessageBox.Show("A senha deve conter números.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VerificarSeExiste();
        }

        public void VerificarSeExiste()
        {
            string[] filesPathes = Directory.GetFiles(diretorio, "*.txt");

            string usuario = "";

            for(int i = 0; i < filesPathes.Length; i++)
            {
                StreamReader leitor = new StreamReader(filesPathes[i]);

                usuario = leitor.ReadLine();

                leitor.Close();

                if(txtUsuario.Text == usuario)
                {
                    MessageBox.Show("Esse usuário já existe, tente outro.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            CadastrarAdmin();
        }

        public void CadastrarAdmin()
        {
            StreamWriter escritor = new StreamWriter(diretorio + @"\" + txtUsuario.Text + ".txt");

            escritor.WriteLine(txtUsuario.Text.Trim());
            escritor.WriteLine(txtSenha.Text);

            escritor.Close();

            MessageBox.Show("Cadastro realizado com sucesso!");

            Admin adm = new Admin();
            Hide();
            adm.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            Hide();
            adm.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioApagar.Text == "" || txtSenhaApagar.Text == "" || txtConfirmarSenhaApagar.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSenhaApagar.Text != txtConfirmarSenhaApagar.Text)
            {
                MessageBox.Show("Senhas incompatíveis!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] filesPathes = Directory.GetFiles(diretorio, "*.txt");

            string usuario = "";
            string senha = "";

            for (int i = 0; i < filesPathes.Length; i++)
            {
                StreamReader leitor = new StreamReader(filesPathes[i]);

                usuario = leitor.ReadLine();
                senha = leitor.ReadLine();

                leitor.Close();

                if (txtUsuarioApagar.Text == usuario && txtSenhaApagar.Text == senha)
                {
                    File.Delete(filesPathes[i]);

                    MessageBox.Show("Cadastro apagado com sucesso!");

                    Admin adm = new Admin();
                    Hide();
                    adm.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Cadastro inexistente.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void cbMostrarSenhaCadastro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenhaCadastro.Checked)
            {
                txtSenha.PasswordChar = '\0';
                txtConfirmarSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
                txtConfirmarSenha.PasswordChar = '*';
            }
        }

        private void cbMostrarSenhaApagar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenhaApagar.Checked)
            {
                txtSenhaApagar.PasswordChar = '\0';
                txtConfirmarSenhaApagar.PasswordChar = '\0';
            }
            else
            {
                txtSenhaApagar.PasswordChar = '*';
                txtConfirmarSenhaApagar.PasswordChar = '*';
            }
        }

        private void btnSairApagar_Click(object sender, EventArgs e)
        {
            Admin adm = new Admin();
            Hide();
            adm.ShowDialog();
        }

        private void btn_minimiza_cadadmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_fechatudo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
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
