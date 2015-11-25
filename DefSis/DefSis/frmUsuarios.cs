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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        DataTable dtUsuario;

        private void bt_novo_Click(object sender, EventArgs e)
        {
            frmCadastroUsu frmCadUsu = new frmCadastroUsu();
            frmCadUsu.ShowDialog();
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
                    string mSQL = "SELECT * FROM USUARIOS";

                    FbCommand cmd = new FbCommand(mSQL, connection);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    dtUsuario = new DataTable();
                    da.Fill(dtUsuario);

                    this.gdUsuarios.DataSource = dtUsuario;
                    this.gdUsuarios.Columns["ID_USUARIO"].HeaderText = "Usuário";
                    this.gdUsuarios.Columns["ID_USUARIO"].Width = 70;
                    this.gdUsuarios.Columns["NOME"].HeaderText = "Nome";
                    this.gdUsuarios.Columns["NOME"].Width = 280;
                    this.gdUsuarios.Columns["LOGIN"].HeaderText = "Login";
                   
                    this.gdUsuarios.Columns["SENHA"].Visible = false;
                    

                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso a dados do Usuário : " + fbex.Message, "Erro");
                }

            }

        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtUsuario);
            DV.RowFilter = string.Format("nome LIKE '%{0}%'", tbPesquisa.Text);
            gdUsuarios.DataSource = DV;
        }
    }
}
