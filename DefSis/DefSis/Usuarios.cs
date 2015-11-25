using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace DefSis
{
    public class Usuarios
    {
       /* private int idUsuario;
        private string nome;
        private string email;
        private string login;
        private string senha; */

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public static void Cadastrar(Usuarios usuarios)
        {
            using (FbConnection connection = DaoBanco.GetInstancia().getConexao())

            try
            {
                connection.Open();
                string mSQL = "INSERT into Usuarios Values (" + usuarios.IdUsuario + ",'" +
                                                                usuarios.Nome + "','" +
                                                                usuarios.Email + "','" +
                                                                usuarios.Login + "','" +
                                                                usuarios.Senha + "')";
                FbCommand cmd = new FbCommand(mSQL, connection);
                cmd.ExecuteNonQuery();
                
            }
            catch (FbException febx)
            {
                throw febx;
            }
            finally
            {
                connection.Close();
            }
        }
    }
        
}
