using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2C
{
    class Pergunta
    {
        string diretorioAtual = Directory.GetCurrentDirectory() + @"\Questões\";
        //string nomeQuestao;

        public string Enunciado;
        public string AltA;
        public string AltB;
        public string AltC;
        public string AltD;
        public string AltE;
        public string Resolucao;
        public string Letra;
        public string Acertos;
        public string Erros;

        public Pergunta()
        {

        }

        public Pergunta(string enun, string a, string b, string c, string d, string e, string res, string letra, string acertos, string erros)
        {
            Enunciado = enun;
            AltA = a;
            AltB = b;
            AltC = c;
            AltD = d;
            AltE = e;
            Resolucao = res;
            Letra = letra;
            Acertos = acertos;
            Erros = erros;
        }

        public int GetNumeroQuestao(string nomeQuestao)
        {
            if (!Directory.Exists(diretorioAtual + nomeQuestao + @"\"))
            {
                MessageBox.Show("Escolha uma disciplina.");
                return 0;
            }

            string[] diretorios = Directory.GetFiles(diretorioAtual + nomeQuestao + @"\");

            return diretorios.Length;
        }
    }
}
