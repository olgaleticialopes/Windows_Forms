using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoEmpresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClsEmpresa objempresa = new ClsEmpresa();


        //recupera todos os dados informados no formulario.
        private bool RecuperarDados()
        {
            try
            {
               objempresa.ID = int.Parse(txtCod.Text);
                objempresa.NOMEDEP = txtNome.Text;
                objempresa.SIGLADEP = txtSigla.Text;
                return true;
            }
            catch (FormatException) // erro de formato
            {
                MessageBox.Show("Preencha todos os campos corretamente!");
                return false;
            }
        }

        private void Redefinir()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtSigla.Clear();
           GridEmpresa.DataSource = null;
        }

        //recuperar
        private void button1_Click(object sender, EventArgs e)
        {
            if (RecuperarDados())
            {
                objempresa.Incluir();
                Redefinir();
                
            }
        }


        //consultar
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var DadosEmpresa = objempresa.Consultar();

            if (DadosEmpresa.Rows.Count > 0)
                GridEmpresa.DataSource = DadosEmpresa;
            else
            {
                MessageBox.Show("Não há registros no banco de dados consultado!");
                GridEmpresa.Columns.Clear();
            }
        }


        //alterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (RecuperarDados())
            {
                objempresa.Alterar();
                Redefinir();

            }
        }


        //excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                objempresa.ID = int.Parse(txtCod.Text);
                if (MessageBox.Show("Deseja excluir esse registro?",
                    "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       objempresa.Excluir();
                        Redefinir();
                    }

            }
            catch (Exception)
            {
                MessageBox.Show("Informe o número do Código para a exclusão!");
                txtCod.Clear();
            }
        }


        //pesquisar cod
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           try {
                objempresa.ID = int.Parse(txtCod.Text);

                var tblDados = objempresa.Pesquisar();
                txtCod.Text = tblDados.Rows[0]["ID"].ToString();
                txtNome.Text = tblDados.Rows[0]["NOMEDEP"].ToString();
                txtSigla.Text = tblDados.Rows[0]["SIGLADEP"].ToString();
                
            }

            catch (FormatException)
            {
                MessageBox.Show("Digite o Código antes de pesquisar");
                txtCod.Focus();
            }
        }
    }
}
