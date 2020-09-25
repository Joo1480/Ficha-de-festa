using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_Pais
{
    public partial class FrmMaquina : Form
    {
        public FrmMaquina()
        {
            InitializeComponent();
        }

        int qntCrepe = 0, qntChurros = 0, qntRefri = 0;
        float CrepePreco = 7, ChurrosPreco = 5, RefriPreco = 4;

        List<TextBox> _TextBoxs = null;
 
        private void Form1_Load(object sender, EventArgs e)
        {
            _TextBoxs = new List<TextBox>()
            {
               txtChurro,
               txtCrepe,
               txtRefri
            };

        }
        private void verificatecla(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
           
        }


        public object lblResult { get; private set; }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtCrepe.Text = "";
            txtChurro.Text = "";
            txtRefri.Text = "";
            label2.Text = "";
            lblPCrepe.Text = "";
            lblPChurros.Text = "";
            lblPRefri.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            foreach (var item in _TextBoxs)
            {

                if (item.Text == "")
                {
                    item.Text = "0";
                }
            }
            

            qntCrepe = int.Parse(txtCrepe.Text);
            qntChurros = int.Parse(txtChurro.Text);
            qntRefri = int.Parse(txtRefri.Text);
            float Total = (qntCrepe * CrepePreco) + (qntChurros * ChurrosPreco) + (qntRefri * RefriPreco);
            label2.Text = Total.ToString("C2");
        }

        private void txtCrepe_KeyPress(object sender, KeyPressEventArgs e)
        {

            txtCrepe.Focus();

        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
          
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (txtCrepe.Text!="")
            {
                int crepe = int.Parse(txtCrepe.Text);
                for (int i = 0; i < crepe; i++)
                {
                    FichaCrepe.Print();
                }
            }
            if (txtChurro.Text!="")
            {
                int churros = int.Parse(txtChurro.Text);
                for (int i = 0; i < churros; i++)
                {
                    FichaChurros.Print();
                }
            }
            if (txtRefri.Text!="")
            {
                int refri = int.Parse(txtRefri.Text);
                for (int i = 0; i < refri; i++)
                {
                    FichaRefri.Print();
                }
            }
        }

        private void FichaCrepe_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = "1 ficha de crepe!";
            
        }

        private void FichaChurros_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = "1 ficha de Churros!";

        }

        private void FichaRefri_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string texto = "1 ficha de Refrigerante!";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("dddd dd/MM/yyyy  HH:mm:ss");
            lblHora.MaximumSize = new Size(250, 0);
            lblHora.AutoSize = true;
        }

        private void txtCrepe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCrepe_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCrepe.Text!=String.Empty)
            {
                qntCrepe = int.Parse(txtCrepe.Text);
                float Total = (qntCrepe * CrepePreco);
                lblPCrepe.Text = Total.ToString("C2");
            }
            else
            {
                lblPCrepe.Text = String.Empty;
            }
            
        }

        private void txtChurro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtChurro.Text!=String.Empty)
            {
                qntChurros = int.Parse(txtChurro.Text);
                float Total = (qntChurros * ChurrosPreco);
                lblPChurros.Text = Total.ToString("C2");
            }
            else
            {
                lblPChurros.Text = String.Empty;
            }
        }

        private void txtRefri_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtRefri.Text!=String.Empty)
            {
                qntRefri = int.Parse(txtRefri.Text);
                float Total = (qntRefri * RefriPreco);
                lblPRefri.Text = Total.ToString("C2");
            }
            else
            {
                lblPRefri.Text = String.Empty;
            }
            
        }

        private void verefication(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }
    }
}
