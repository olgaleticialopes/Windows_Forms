using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudoCasoLojaInfo
{
    public partial class FLoja : Form
    {
        ClsProduto objProduto = new ClsProduto();

        public void comprar()
        {

        }
        public void recuperadados()//recupera os dados do form para economozar linhas de codigo
        {
            objProduto.Precocusto = int.Parse(txtPrecoCusto.Text);
            objProduto.Precolucro = int.Parse(txtLucro.Text);
            objProduto.Quantidade = int.Parse(txtQtdeMovimentar.Text);
            
        }

        public FLoja()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabCompra_Click(object sender, EventArgs e)
        {

        }

        private void tabMovimentacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {




        }
        private void cboMovimentacao_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            if (comboBox1.SelectedIndex == 0)//Compra
            {
                double precoCusto = double.Parse(txtPrecoCusto.Text);
                double lucro = double.Parse(txtLucro.Text);
                txtTotalCompra.Text = $"{(lucro / 100 + 1) * precoCusto:C}";

            }
            else if (comboBox1.SelectedIndex == 1)//Venda
            {
                txtPrecoCusto.Enabled = false;
                txtLucro.Enabled = false;
                txtEstoque.Enabled = false;
                
                

                txtTotalCompra.Text = $"{(lucro / 100 + 1) * precoCusto:C}";
            }
            else
            {
                
            }
        }
    }
}