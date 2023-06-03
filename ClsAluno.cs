using BancoDados_exemplo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDados_exemplo
{
    class ClsAluno
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        Dados ObjDados = new Dados();


        public void Incluir(){
            try
            {
                ObjDados.ConvertSqlToInt("INSERT INTO ALUNO(codigo, nome) VALUES(?codigo, ?nome)",
                    new MySqlParameter("?codigo", Codigo),
                    new MySqlParameter("?nome", Nome));

                    MessageBox.Show("Inclusão Realizada");
                    
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível realizar a inclusão");
               
            }

    }


        public DataTable Consultar()
        {
            DataTable tblRecuperada = ObjDados.ConvertSqlToDataTable("SELECT * FROM ALUNO");


            return tblRecuperada;
        }

        public DataTable Pesquisar()
        {
            DataTable tblRecuperada = ObjDados.ConvertSqlToDataTable(
                "SELECT * FROM ALUNO WHERE CODIGO = ?Codigo",
                new MySqlParameter("?Codigo", Codigo));

            return tblRecuperada;
        }

        public void Alterar()
        {
            try
            {
                ObjDados.ConvertSqlToInt(
                    "update aluno set nome = ?nome where codigo = ?codigo",
                    new MySqlParameter("?codigo", Codigo),
                    new MySqlParameter("?nome", Nome)
                    );

                MessageBox.Show("Alteração realizada!");
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel fazer a alteração!");
            }
        }




    }
}
