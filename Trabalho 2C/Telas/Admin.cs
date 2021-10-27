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
using Trabalho_2C.Telas;
using System.Runtime.InteropServices;

namespace Trabalho_2C
{
    public partial class Admin : Form
    {
        string diretorio = Directory.GetCurrentDirectory() + @"\Cadastro";
        bool logou = false;

        public Admin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnLogar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                if (txtUsuario.Text == usuario && txtSenha.Text == senha)
                {
                    MessageBox.Show("Login realizado com sucesso!");
                    logou = true;

                    Cadastro cad = new Cadastro();
                    Hide();
                    cad.ShowDialog();
                    return;
                }
            }
            if(logou == false)
            {
                MessageBox.Show("Usuário inexistente.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            Hide();
            menu.ShowDialog();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            InscreverSe inscrevase = new InscreverSe();
            Hide();
            inscrevase.ShowDialog();
        }

        private void cbMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarSenha.Checked)
                txtSenha.PasswordChar = '\0';
            else
                txtSenha.PasswordChar = '*';
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
