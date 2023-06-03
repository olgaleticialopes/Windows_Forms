using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDados_exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClsAluno ObjAluno = new ClsAluno();

        private void RecuperarDados()
        {
            try
            {
                ObjAluno.Codigo = int.Parse(txtCodigo.Text);
                ObjAluno.Nome = txtNome.Text;
            }
            catch (Exception)
            {

                MessageBox.Show("Preencha todos os campos corretamente");
            }
        }



        private void btnIncluir_Click(object sender, EventArgs e)
        {
            RecuperarDados();
            ObjAluno.Incluir();
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            gridAluno.DataSource = ObjAluno.Consultar();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            ObjAluno.Codigo = int.Parse(txtCodigo.Text);
            var tbldados = ObjAluno.Pesquisar();
            txtNome.Text = tbldados.Rows[0]["NOME"].ToString();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            RecuperarDados();
            ObjAluno.Alterar();


        }
    }
}
