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
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.produtoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bdBigFestaDataSet);
                MessageBox.Show("Registro Salvo com Sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar o registro" + ex.Message);
            }
           

        }

        private void CadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdBigFestaDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bdBigFestaDataSet.Produto);
            // TODO: esta linha de código carrega dados na tabela 'bdBigFestaDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bdBigFestaDataSet.Produto);

        }

        private void toolStripButtonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void toolStripButtonEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            produtoBindingSource.CancelEdit();

            groupBox1.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja realmente excluir o registro?","Produto",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    produtoBindingSource.RemoveCurrent();
                    produtoTableAdapter.Fill(this.bdBigFestaDataSet.Produto);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível excluir" + ex.Message);
                this.produtoTableAdapter.Fill(this.bdBigFestaDataSet.Produto);
            }
        }

        private void produtoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdBigFestaDataSet);

        }

        private void valorProdutoMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void valorProdutoTextBox_TextChanged(object sender, EventArgs e)
        {
            //  valorProdutoTextBox.Text = string.Format("{0:C}",
            // Convert.ToDouble(valorProdutoTextBox.Text));
            valorProdutoTextBox.Text = Decimal.Parse(valorProdutoTextBox.Text).ToString("C");
        }

        private void valorProdutoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void valorProdutoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
