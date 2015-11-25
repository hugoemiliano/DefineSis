using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Windows.Forms;


namespace DefSis
{
    public class Cliente
    {
        private int idCliente;
        private string pessoa;
        private string nome_fant;
        private string razao;
        private string cpf_cnpj;
        private string rg_insc;
        private DateTime nasc_funda;
        private string email;
        private string endereco;
        private string numero;
        private string cep;
        private string bairro;
        private string cidade;
        private string uf;
        private string fonef;
        private string fonec;
        private string fonex;
        private string obs;

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
       
        public string Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }
        
        public string Nome_Fant
        {
            get { return nome_fant; }
            set { nome_fant = value; }
        }
        
        public string Razao
        {
            get { return razao; }
            set { razao = value; }
        }
        
        public string Cpf_Cnpj
        {
            get { return cpf_cnpj; }
            set { cpf_cnpj = value; }
        }
        
        public string Rg_Insc
        {
            get { return rg_insc; }
            set { rg_insc = value; }
        }

        public DateTime Nasc_Funda
        {
            get { return nasc_funda; }
            set { nasc_funda = value; }
        }
        
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string UF
        {
            get { return uf; }
            set { uf = value; }
        }

        public string FoneF
        {
            get { return fonef; }
            set { fonef = value; }
        }

        public string FoneC
        {
            get { return fonec; }
            set { fonec = value; }
        }

        public string FoneX
        {
            get { return fonex; }
            set { fonex = value; }
        }

        public string Obs
        {
            get { return obs; }
            set { obs = value; }
        }

        


        // continua......




    }
}
