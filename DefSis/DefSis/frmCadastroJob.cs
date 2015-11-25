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

namespace DefSis
{
    public partial class frmCadastroJob : Form
    {
        public frmCadastroJob()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastroJob_Load(object sender, EventArgs e)
        {
            using (FbConnection conn = DaoBanco.GetInstancia().getConexao())
            { 
               //Combobox clientes
                string SqlCli = "SELECT nome_fant FROM clientes order by nome_fant";

                FbCommand cmdCli = new FbCommand(SqlCli, conn);
                FbDataAdapter dacli = new FbDataAdapter(cmdCli);

                DataTable dtCli = new DataTable();
                dacli.Fill(dtCli);

                cbCliente.DisplayMember = "nome_fant";
                cbCliente.DataSource = dtCli;
                cbCliente.SelectedIndex = -1; //Primeira linha em branco no combobox

                //Combobox Atendimento
                string SqlUsrA = "SELECT nome FROM usuarios order by nome ";

                FbCommand cmdUsrA = new FbCommand(SqlUsrA, conn);
                FbDataAdapter dausra = new FbDataAdapter(cmdUsrA);

                DataTable dtUsrA = new DataTable();
                dausra.Fill(dtUsrA);
                cbAtendimento.DisplayMember = "nome";
                cbAtendimento.DataSource = dtUsrA;
                cbAtendimento.SelectedIndex = -1;

                //Combobox Criacao
                string SqlUsrC = "SELECT nome FROM usuarios order by nome";

                FbCommand cmdUsrC = new FbCommand(SqlUsrC, conn);
                FbDataAdapter dausrc = new FbDataAdapter(cmdUsrC);

                DataTable dtUsrC = new DataTable();
                dausrc.Fill(dtUsrC);
                cbCriacao.DisplayMember = "nome";
                cbCriacao.DataSource = dtUsrC;
                cbCriacao.SelectedIndex = -1;

                //Combobox Peça1
                string SqlUsrP1 = "SELECT peca FROM pecas order by peca";

                FbCommand cmdUsrP1 = new FbCommand(SqlUsrP1, conn);
                FbDataAdapter dausrp1 = new FbDataAdapter(cmdUsrP1);

                DataTable dtUsrP1 = new DataTable();
                dausrp1.Fill(dtUsrP1);
                cbPeca1.DisplayMember = "peca";
                cbPeca1.DataSource = dtUsrP1;
                cbPeca1.SelectedIndex = -1;

                //Combobox Peça2
                string SqlUsrP2 = "SELECT peca FROM pecas order by peca";

                FbCommand cmdUsrP2 = new FbCommand(SqlUsrP2, conn);
                FbDataAdapter dausrp2 = new FbDataAdapter(cmdUsrP2);

                DataTable dtUsrP2 = new DataTable();
                dausrp2.Fill(dtUsrP2);
                cbPeca2.DisplayMember = "peca";
                cbPeca2.DataSource = dtUsrP1;
                cbPeca2.SelectedIndex = -1;

                //Combobox Peça3
                string SqlUsrP3 = "SELECT peca FROM pecas order by peca";

                FbCommand cmdUsrP3 = new FbCommand(SqlUsrP3, conn);
                FbDataAdapter dausrp3 = new FbDataAdapter(cmdUsrP3);

                DataTable dtUsrP3 = new DataTable();
                dausrp3.Fill(dtUsrP3);
                cbPeca3.DisplayMember = "peca";
                cbPeca3.DataSource = dtUsrP1;
                cbPeca3.SelectedIndex = -1;
                
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
