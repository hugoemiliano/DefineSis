using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DefSis
{
    public partial class frmCadastroFor : Form
    {
        public frmCadastroFor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmCadCli_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário e perder todas as informações não salvas?", "Sair sem Salvar!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            //fornecedor.IdFornecedor = Convert.ToInt32(tbCodigo.Text);
            fornecedor.Pessoa = cbPessoa.Text;
            fornecedor.Nome_Fant = tbNome.Text;
            fornecedor.Razao = tbRazao.Text;
            fornecedor.Cpf_Cnpj = mtbCNPJ.Text;
            fornecedor.Rg_Insc = tbRgInsc.Text;
            fornecedor.Nasc_Funda = Convert.ToDateTime(mtbData.Text);
            fornecedor.Email = tbEmail.Text;
            fornecedor.Endereco = tbEnd.Text;
            fornecedor.Numero = tbNumero.Text;
            fornecedor.Cep = mtbCEP.Text;
            fornecedor.Bairro = tbBairro.Text;
            fornecedor.Cidade = tbCidade.Text;
            fornecedor.UF = cbUF.Text;
            fornecedor.FoneF = mtbFonef.Text;
            fornecedor.FoneC = mtbFonec.Text;
            fornecedor.FoneX = mtbFonex.Text;
            fornecedor.Obs = tbObs.Text;

            try
            {
                Fornecedor.Cadastrar(fornecedor);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar dados do cliente." + ex.Message, "Erro!");
            }
            finally
            { 
            
            }



        }
    }
}
