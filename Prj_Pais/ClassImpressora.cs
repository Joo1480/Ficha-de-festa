using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Pais
{

    public class  ClassImpressora

    {
        public void Classimpressora(int quant, string texto, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font letra = new Font("Ariel", 14, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point ponto = new Point(100, 100);
            e.Graphics.DrawString(texto, letra, cor, ponto);
        }
    }
}
