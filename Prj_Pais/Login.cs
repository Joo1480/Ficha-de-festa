using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Prj_Pais
{
    public partial class Login : Form
    {
        Thread nt;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="a" && textBox2.Text == "1")
            {
                this.Close();
                nt = new Thread(novoForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            else
            {
                MessageBox.Show("Login ou senha inválida!");
                textBox2.Text = "";
            }
        }

        private void novoForm()
        {
            Application.Run(new Central());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
