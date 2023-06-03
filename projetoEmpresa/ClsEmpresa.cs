using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetoEmpresa
{
    class ClsEmpresa
    {
        public int ID { get; set; }
        public string  NOMEDEP { get; set; }

        public string SIGLADEP{ get; set; }
        Dados objempresa = new Dados();


        #region Incluir
        public void Incluir()
        {
            try
            {
                if (objempresa.ConvertSqlToInt(
                    "INSERT INTO TBDEPARTAMENTO(ID, NOMEDEP, SIGLADEP)VALUES(?ID,?NOMEDEP,?SIGLADEP)",
                    new MySqlParameter("?ID", ID),
                    new MySqlParameter("?NOMEDEP", NOMEDEP),
                    new MySqlParameter("?SIGLADEP", SIGLADEP)) != 0)

                    MessageBox.Show("Inclusão realizada");       
                
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possivel incluir");
                
            }
        }

        #endregion


        #region Consultar
        public DataTable Consultar()
        {
            DataTable tblRecuperada = objempresa.ConvertSqlToDataTable("SELECT * FROM TBDEPARTAMENTO");

            return tblRecuperada;
        }

        #endregion


        #region Alterar
        public void Alterar()
        {
            try
            {

                if (objempresa.ConvertSqlToInt(
                  "UPDATE TBDEPARTAMENTO SET ID = ?ID, NOMEDEP = ?NOMEDEP, SIGLADEP = ?SIGLADEP ",
                  new MySqlParameter("?ID", ID),
                  new MySqlParameter("?NOMEDEP", NOMEDEP),
                  new MySqlParameter("?SIGLADEP", SIGLADEP)) != 0)

                MessageBox.Show("Alteração realizada com sucesso!");


            }
            catch (Exception)
            {

                MessageBox.Show("A alteração não pode ser concluida!");
            }
        }

        #endregion


        #region excluir
        public void Excluir()
        {
            try
            {
 
             if (objempresa.ConvertSqlToInt("DELETE FROM TBDEPARTAMENTO WHERE ID = ?ID",
                    new MySqlParameter("?ID", ID)) != 0)
                     MessageBox.Show("Registro Excluído!");
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possivel realizar a exclusão! :( ");
            }
        }
        #endregion


        #region pesquisar
        public DataTable Pesquisar()
        {
            DataTable tblRecuperada = objempresa.ConvertSqlToDataTable(
                "SELECT * FROM TBDEPARTAMENTO WHERE ID = ?ID",
                new MySqlParameter("?ID", ID));

            return tblRecuperada;
        }

        #endregion
    }
}
