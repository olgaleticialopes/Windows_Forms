using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboPara_SelectedIndexChanged(object sender, EventArgs e)
        {
            //calcular
            
            if (cboDe.SelectedIndex != -1 && cboPara.SelectedIndex != -1)
            {
                try {
                    double valor, total;
                    valor = float.Parse(txtValor.Text);
                    if (cboDe.SelectedIndex == 0 && cboPara.SelectedIndex == 1)
                    {
                        //dolar Para euro
                        total = valor / 1.06;
                        txtConvertido.Text = $"€ {total}";

                    }
                    else if (cboDe.SelectedIndex == 0 && cboPara.SelectedIndex == 2)
                    {
                        //dolar Para peso
                        total = valor * 198.26;
                        txtConvertido.Text = $"$ {total}";

                    }
                    else if (cboDe.SelectedIndex == 0 && cboPara.SelectedIndex == 3)
                    {
                        //dolar Para real
                        total = valor * 5.20;
                        txtConvertido.Text = $"R$ {total}";

                    }
                    else if (cboDe.SelectedIndex == 1 && cboPara.SelectedIndex == 0)
                    {
                        //Euro Para dolar
                        total = valor * 1.06;
                        txtConvertido.Text = $"$ {total}";

                    }
                    else if (cboDe.SelectedIndex == 1 && cboPara.SelectedIndex == 2)
                    {
                        //Euro Para Peso
                        total = valor * 198.26;
                        txtConvertido.Text = $"$ {total}";

                    }
                    else if (cboDe.SelectedIndex == 1 && cboPara.SelectedIndex == 3)
                    {
                        //Euro Para Real
                        total = valor * 5.51;
                        txtConvertido.Text = $"R$ {total}";

                    }
                    else if (cboDe.SelectedIndex == 2 && cboPara.SelectedIndex == 0)
                    {
                        //peso Para dolar
                        total = valor / 198.26;
                        txtConvertido.Text = $"$ {total}";

                    }
                    else if (cboDe.SelectedIndex == 2 && cboPara.SelectedIndex == 1)
                    {
                        //peso Para Euro
                        total = valor / 1.06;
                        txtConvertido.Text = $"€ {total}";

                    }
                    else if (cboDe.SelectedIndex == 2 && cboPara.SelectedIndex == 3)
                    {
                        //PESO PARA REAL
                        total = valor / 38.1;
                        txtConvertido.Text = $"R$ {total}";
                    }
                    //valores iguais 
                    else if (cboDe.SelectedIndex == 0 && cboPara.SelectedIndex == 0)
                    {
                        if (MessageBox.Show("As moedas são iguais", "Sair", MessageBoxButtons.OK,
                           MessageBoxIcon.Error) != DialogResult.OK)
                        {

                            txtValor.Clear();
                            txtConvertido.Clear();
                            cboDe.SelectedIndex = -1;
                            cboPara.SelectedIndex = -1;
                        }
                       
                    }
                    else if (cboDe.SelectedIndex == 1 && cboPara.SelectedIndex == 1)
                    {
                        if (MessageBox.Show("As moedas são iguais", "Sair", MessageBoxButtons.OK,
                          MessageBoxIcon.Error) != DialogResult.OK)
                        {

                            txtValor.Clear();
                            txtConvertido.Clear();
                            cboDe.SelectedIndex = -1;
                            cboPara.SelectedIndex = -1;
                        }
                    }
                    else if (cboDe.SelectedIndex == 2 && cboPara.SelectedIndex == 2)
                    {
                        if (MessageBox.Show("As moedas são iguais", "Sair", MessageBoxButtons.OK,
                          MessageBoxIcon.Error) != DialogResult.OK)
                        {

                            txtValor.Clear();
                            txtConvertido.Clear();
                            cboDe.SelectedIndex = -1;
                            cboPara.SelectedIndex = -1;
                        }
                    }
                    else if (cboDe.SelectedIndex == 3 && cboPara.SelectedIndex == 3)
                    {
                        if (MessageBox.Show("As moedas são iguais", "Sair", MessageBoxButtons.OK,
                             MessageBoxIcon.Error) != DialogResult.OK)
                        {

                            txtValor.Clear();
                            txtConvertido.Clear();
                            cboDe.SelectedIndex = -1;
                            cboPara.SelectedIndex = -1;
                        }

                    }
                }
                catch (Exception)
                {
                    if (MessageBox.Show("Informe os dados corretamente", "Sair", MessageBoxButtons.OK,
                         MessageBoxIcon.Error) != DialogResult.OK)
                    {
                        
                        
                        cboDe.SelectedIndex = -1;
                        cboPara.SelectedIndex = -1;
                    }

                }
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //limpar a aplicação
                txtValor.Clear();
                txtConvertido.Clear();
            cboDe.SelectedIndex = -1;
            cboPara.SelectedIndex = -1;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //fechar a aplicação
            if (MessageBox.Show("Desejar encerrar o programa?", "Sair", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Error) == DialogResult.Yes)
            {
                // aplicacao é encerrada
                Application.Exit();
            }
        }
    }
}
