using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace DefSis
{
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
        }
        DataTable dtCliente;
        private void bt_novo_Click(object sender, EventArgs e)
        {
            frmCadastroFor frmCadFor = new frmCadastroFor();
            frmCadFor.ShowDialog();
            PreencherGrid();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void frmFornecedores_Load(object sender, EventArgs e)
        {
            AcessarBanco();
            PreencherGrid();
        }
        public void AcessarBanco()
        { 
            using (FbConnection connection = DaoBanco.GetInstancia().getConexao())
            {
                try
                {
                    connection.Open();
                }
                catch (FbException fbex)
                {
                    MessageBox.Show ("Erro de acesso ao banco de dados: " + fbex.Message, "Erro" );
                }
                finally
                { 
                    connection.Close();
                }
            
            }
        }

        public void PreencherGrid()
        {
            using (FbConnection connection = DaoBanco.GetInstancia().getConexao())
            {
                try
                {
                    string mSQL = "SELECT * FROM fornecedores";

                    FbCommand cmd = new FbCommand(mSQL, connection);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    dtCliente = new DataTable();
                    da.Fill(dtCliente);

                    this.gdFornecedor.DataSource = dtCliente;
                    this.gdFornecedor.Columns["ID_FORNECEDOR"].HeaderText = "Código";
                    this.gdFornecedor.Columns["ID_FORNECEDOR"].Width = 50;
                    this.gdFornecedor.Columns["NOME_FANT"].HeaderText = "Razão Social";
                    this.gdFornecedor.Columns["NOME_FANT"].Width = 280;
                    this.gdFornecedor.Columns["RG_INSC"].HeaderText = "CPF/CNPJ";
                    this.gdFornecedor.Columns["RG_INSC"].Width = 280;
                    this.gdFornecedor.Columns["CPF_CNPJ"].HeaderText = "CPF/CNPJ";
                    this.gdFornecedor.Columns["FONEF"].HeaderText = "Telefone";
                    this.gdFornecedor.Columns["FONEC"].HeaderText = "Celular";
                    this.gdFornecedor.Columns["CIDADE"].HeaderText = "Cidade";
                    this.gdFornecedor.Columns["CIDADE"].Width = 150;
                    this.gdFornecedor.Columns["EMAIL"].HeaderText = "E-mail";
                    this.gdFornecedor.Columns["EMAIL"].Width = 150;

                    this.gdFornecedor.Columns["PESSOA"].Visible = false;
                    this.gdFornecedor.Columns["RAZAO"].Visible = false;
                    this.gdFornecedor.Columns["NASC_FUNDA"].Visible = false;
                    
                    this.gdFornecedor.Columns["ENDERECO"].Visible = false;
                    this.gdFornecedor.Columns["NUMERO"].Visible = false;
                    this.gdFornecedor.Columns["CEP"].Visible = false;
                    this.gdFornecedor.Columns["BAIRRO"].Visible = false;
                    this.gdFornecedor.Columns["UF"].Visible = false;
                    this.gdFornecedor.Columns["FONEX"].Visible = false;
                    this.gdFornecedor.Columns["OBS"].Visible = false;
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso a dados do cliente : " + fbex.Message, "Erro");
                }
                finally
                { 
                
                }

            }
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtCliente);
            DV.RowFilter = string.Format("nome_fant LIKE '%{0}%'", tbPesquisa.Text);
            gdFornecedor.DataSource = DV;
        }
    }
}
