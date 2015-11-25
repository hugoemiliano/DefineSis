using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace DefSis
{
    //Usa padrão singleton para obter uma instância do FireBird
    public class DaoBanco
    {
        private static readonly DaoBanco InstanciaFirebird = new DaoBanco();

        private DaoBanco() { }

        public static DaoBanco GetInstancia()
        {
            return InstanciaFirebird;    
        }

        public FbConnection getConexao()
        {
            string Conn = ConfigurationManager.ConnectionStrings["connect"].ToString();  //Deve adicionar a referencia System.configuration
            return new FbConnection(Conn);
        }
    }
}
