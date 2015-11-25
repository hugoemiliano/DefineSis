using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace DefSis
{
    class Pecas
    {
        private int idPeca;
        private string peca;
        private string obs;

        public int IdPeca { get; set; }
        public string Peca { get; set; }
        public string Obs { get; set; }

        public static void Cadastrar(Pecas peca)
        {
            using (FbConnection connection = DaoBanco.GetInstancia().getConexao())
            {
                try
                {
                    connection.Open();
                    string mSQL = "INSERT INTO Pecas Values (" + peca.IdPeca + ",'" +
                                                                 peca.Peca + "','" +
                                                                 peca.Obs + "')";
                    FbCommand cmd = new FbCommand(mSQL, connection);
                    cmd.ExecuteNonQuery();
                }
                catch (FbException fbex)
                {
                    throw fbex;
                }
                finally
                {
                    connection.Close();
                }
                }
            
        }
    }
}
