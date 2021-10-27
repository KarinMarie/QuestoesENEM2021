using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Trabalho_2C.Classes
{
    public class Graficos
    {
        Chart chartUsuario;

        public Graficos(Chart chartUsuario)
        {
            this.chartUsuario = chartUsuario;
        }

        public void GraficosUsuario(int acertos, int erros, string materia)
        {
            chartUsuario.Titles["Materia"].Text = "";
            chartUsuario.Series["Usuario"].Points.Clear();

            chartUsuario.Titles["Materia"].Text = materia;

            if (acertos == 0)
            {
                chartUsuario.Series["Usuario"].Points.AddXY("Erros", erros);
                chartUsuario.Series["Usuario"].Points[0].Color = Color.MediumPurple;
            }
            else if (erros == 0)
            {
                chartUsuario.Series["Usuario"].Points.AddXY("Acertos", acertos);
                chartUsuario.Series["Usuario"].Points[0].Color = Color.MediumAquamarine;
            }
            else
            {
                chartUsuario.Series["Usuario"].Points.AddXY("Acertos", acertos);
                chartUsuario.Series["Usuario"].Points.AddXY("Erros", erros);
                chartUsuario.Series["Usuario"].Points[0].Color = Color.MediumAquamarine;
                chartUsuario.Series["Usuario"].Points[1].Color = Color.MediumPurple;
            }
        }
    }
}