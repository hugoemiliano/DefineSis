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
    public partial class frmPeca : Form
    {
        public frmPeca()
        {
            InitializeComponent();
        }

        DataTable dtPeca;
        private void bt_novo_Click(object sender, EventArgs e)
        {
            frmCadastroPec frmCadPec = new frmCadastroPec();
            frmCadPec.ShowDialog();
            PreencherGrid();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void frmClientes_Load(object sender, EventArgs e)
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

                }
                catch (FbException febex)
                {
                    MessageBox.Show("Erro de acesso ao banco de dados " + febex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    string mSQL = "SELECT * FROM PECAS";

                    FbCommand cmd = new FbCommand(mSQL, connection);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    dtPeca = new DataTable();
                    da.Fill(dtPeca);

                    this.gdPeca.DataSource = dtPeca;
                    this.gdPeca.Columns["ID_PECA"].HeaderText = "Código";
                    this.gdPeca.Columns["ID_PECA"].Width = 70;
                    this.gdPeca.Columns["PECA"].HeaderText = "Peça";
                    this.gdPeca.Columns["PECA"].Width = 300;
                    this.gdPeca.Columns["OBS"].HeaderText = "Observaçoes";
                    this.gdPeca.Columns["OBS"].Width = 510;

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso a dados da peça : " + fbex.Message, "Erro");
                }

            }

        }

        private void gdCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtPeca);
            DV.RowFilter = string.Format("peca LIKE '%{0}%'", tbPesquisa.Text);
            gdPeca.DataSource = DV;
        }
    }
}
