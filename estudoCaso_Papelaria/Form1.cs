using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudoCaso_Papelaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saldo = 0;
        int qtdeMov = 0;

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboProduto.SelectedIndex)
            {
                case 0: saldo = 100; break;
                case 1: saldo = 300; break;
                case 2: saldo = 500; break;
                case 3: saldo = 450; break;
                case 4: saldo = 1000; break;
            }

            lblSaldoEntrada.Text = $"Saldo Atual: {saldo:N0}";
            lblSaldoEntrada.BackColor = Color.FromArgb(255, 255, 128);
        } 

        private void txtQtdeMovimentar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                tabMovimentacao.Enabled = true;
                tabMovimentacao_SelectedIndexChanged(sender, e);

            }
        }

        private void tabMovimentacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            qtdeMov = int.Parse(txtQtdeMovimentar.Text);
           
            if (tabMovimentacao.SelectedIndex == 0)
            {
                tabEntrada.BackColor = Color.LightBlue;
                txtPrecoCusto.Focus();
                txtPrecoCusto.ReadOnly = false;        
            }

            if (tabMovimentacao.SelectedIndex == 1)
            {
                if (qtdeMov > saldo)
                {
                    MessageBox.Show("Saldo insuficiente!");
                }
                else
                {
                    txtLucro.Focus();
                    tabSaida.BackColor = Color.LightGreen;
                    txtLucro.ReadOnly = false;
                }
            }
        }

        private void txtLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                double precoCusto = double.Parse(txtPrecoCusto.Text);
                double lucro = double.Parse(txtLucro.Text);

                txtVenda.Text = $"{(lucro / 100 + 1) * precoCusto:C}";
            }
        }

        private void txtPrecoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtLucro.Text != "")
            {
                txtLucro_KeyPress(sender, e);
            }           
        }

        private void btnMovimentar_Click(object sender, EventArgs e)
        {
            if (tabMovimentacao.SelectedIndex == 0) 
                 saldo += qtdeMov;
            else if(tabMovimentacao.SelectedIndex == 1)
                 saldo -= qtdeMov;

            lblSaldoEntrada.Text = $"Saldo Atual: {saldo:N0}";
            tabMovimentacao.Enabled = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cboProduto.SelectedIndex = -1;
            txtQtdeMovimentar.Clear();
            txtLucro.Clear();
            txtVenda.Clear();
            lblSaldoEntrada.Text = "";
            tabMovimentacao.Enabled = false;
            tabEntrada.BackColor = Color.Transparent;
            tabSaida.BackColor = Color.Transparent;
            cboProduto.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desejar encerrar o programa?", "Sair",
                MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboProduto.Focus();
        }
    }
}
