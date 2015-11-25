namespace DefSis
{
    partial class frmCadastroFor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_butons = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lb_Nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbRgInsc = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbObs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbRazao = new System.Windows.Forms.TextBox();
            this.mtbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.mtbFonef = new System.Windows.Forms.MaskedTextBox();
            this.mtbFonec = new System.Windows.Forms.MaskedTextBox();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cbPessoa = new System.Windows.Forms.ComboBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.mtbFonex = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.panel_butons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_butons
            // 
            this.panel_butons.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_butons.Controls.Add(this.tableLayoutPanel1);
            this.panel_butons.Controls.Add(this.pictureBox1);
            this.panel_butons.Controls.Add(this.button3);
            this.panel_butons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_butons.Location = new System.Drawing.Point(0, 337);
            this.panel_butons.Margin = new System.Windows.Forms.Padding(4);
            this.panel_butons.Name = "panel_butons";
            this.panel_butons.Size = new System.Drawing.Size(1101, 76);
            this.panel_butons.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bt_salvar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_cancelar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(260, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 49);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bt_salvar
            // 
            this.bt_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_salvar.FlatAppearance.BorderSize = 10;
            this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_salvar.Image = global::DefSis.Properties.Resources.Save;
            this.bt_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salvar.Location = new System.Drawing.Point(3, 3);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(122, 43);
            this.bt_salvar.TabIndex = 0;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseCompatibleTextRendering = true;
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_cancelar.Image = global::DefSis.Properties.Resources.No;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(131, 3);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(122, 43);
            this.bt_cancelar.TabIndex = 0;
            this.bt_cancelar.Text = "  Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DefSis.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-376, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Nome
            // 
            this.lb_Nome.AutoSize = true;
            this.lb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nome.Location = new System.Drawing.Point(19, 46);
            this.lb_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Nome.Name = "lb_Nome";
            this.lb_Nome.Size = new System.Drawing.Size(125, 20);
            this.lb_Nome.TabIndex = 1;
            this.lb_Nome.Text = "Nome / Fantasia\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nasc / FUND";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF / CNPJ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(318, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Inscrição Estadual";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Endereço";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(110, 207);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "CEP";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(532, 238);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "UF";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 270);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fone Fixo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(260, 270);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fone Celular";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(652, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Observações";
            // 
            // tbNome
            // 
            this.tbNome.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNome.ForeColor = System.Drawing.SystemColors.Info;
            this.tbNome.Location = new System.Drawing.Point(152, 45);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(462, 23);
            this.tbNome.TabIndex = 3;
            this.tbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbRgInsc
            // 
            this.tbRgInsc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbRgInsc.ForeColor = System.Drawing.SystemColors.Info;
            this.tbRgInsc.Location = new System.Drawing.Point(458, 109);
            this.tbRgInsc.Margin = new System.Windows.Forms.Padding(4);
            this.tbRgInsc.Name = "tbRgInsc";
            this.tbRgInsc.Size = new System.Drawing.Size(156, 23);
            this.tbRgInsc.TabIndex = 6;
            // 
            // tbEnd
            // 
            this.tbEnd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEnd.ForeColor = System.Drawing.SystemColors.Info;
            this.tbEnd.Location = new System.Drawing.Point(152, 173);
            this.tbEnd.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(325, 23);
            this.tbEnd.TabIndex = 9;
            this.tbEnd.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // tbCidade
            // 
            this.tbCidade.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbCidade.ForeColor = System.Drawing.SystemColors.Info;
            this.tbCidade.Location = new System.Drawing.Point(152, 237);
            this.tbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(372, 23);
            this.tbCidade.TabIndex = 13;
            // 
            // tbObs
            // 
            this.tbObs.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbObs.ForeColor = System.Drawing.SystemColors.Info;
            this.tbObs.Location = new System.Drawing.Point(656, 45);
            this.tbObs.Margin = new System.Windows.Forms.Padding(4);
            this.tbObs.Multiline = true;
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(421, 247);
            this.tbObs.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(41, 78);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "Razão Social";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tbRazao
            // 
            this.tbRazao.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbRazao.ForeColor = System.Drawing.SystemColors.Info;
            this.tbRazao.Location = new System.Drawing.Point(152, 77);
            this.tbRazao.Margin = new System.Windows.Forms.Padding(4);
            this.tbRazao.Name = "tbRazao";
            this.tbRazao.Size = new System.Drawing.Size(462, 23);
            this.tbRazao.TabIndex = 4;
            // 
            // mtbCNPJ
            // 
            this.mtbCNPJ.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbCNPJ.ForeColor = System.Drawing.SystemColors.Info;
            this.mtbCNPJ.Location = new System.Drawing.Point(152, 109);
            this.mtbCNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCNPJ.Mask = "99.999.999/9999-99";
            this.mtbCNPJ.Name = "mtbCNPJ";
            this.mtbCNPJ.Size = new System.Drawing.Size(144, 23);
            this.mtbCNPJ.TabIndex = 5;
            this.mtbCNPJ.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCNPJ_MaskInputRejected);
            // 
            // mtbCEP
            // 
            this.mtbCEP.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbCEP.ForeColor = System.Drawing.SystemColors.Info;
            this.mtbCEP.Location = new System.Drawing.Point(152, 206);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(4);
            this.mtbCEP.Mask = "99999-999";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(72, 23);
            this.mtbCEP.TabIndex = 11;
            // 
            // mtbFonef
            // 
            this.mtbFonef.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbFonef.ForeColor = System.Drawing.SystemColors.Info;
            this.mtbFonef.Location = new System.Drawing.Point(152, 269);
            this.mtbFonef.Margin = new System.Windows.Forms.Padding(4);
            this.mtbFonef.Mask = "(99)99999-9999";
            this.mtbFonef.Name = "mtbFonef";
            this.mtbFonef.Size = new System.Drawing.Size(100, 23);
            this.mtbFonef.TabIndex = 15;
            // 
            // mtbFonec
            // 
            this.mtbFonec.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbFonec.ForeColor = System.Drawing.SystemColors.Info;
            this.mtbFonec.Location = new System.Drawing.Point(363, 269);
            this.mtbFonec.Margin = new System.Windows.Forms.Padding(4);
            this.mtbFonec.Mask = "(99)99999-9999";
            this.mtbFonec.Name = "mtbFonec";
            this.mtbFonec.Size = new System.Drawing.Size(100, 23);
            this.mtbFonec.TabIndex = 16;
            // 
            // mtbData
            // 
            this.mtbData.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbData.ForeColor = System.Drawing.SystemColors.Info;
            this.mtbData.Location = new System.Drawing.Point(152, 140);
            this.mtbData.Margin = new System.Windows.Forms.Padding(4);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(74, 23);
            this.mtbData.TabIndex = 7;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(493, 174);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 20);
            this.label17.TabIndex = 9;
            this.label17.Text = "Número";
            // 
            // tbNumero
            // 
            this.tbNumero.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbNumero.ForeColor = System.Drawing.SystemColors.Info;
            this.tbNumero.Location = new System.Drawing.Point(566, 173);
            this.tbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(47, 23);
            this.tbNumero.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Yellow;
            this.label19.Location = new System.Drawing.Point(872, 14);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(215, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "(*) Preenchimento obrigatório";
            this.label19.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbUF
            // 
            this.cbUF.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbUF.ForeColor = System.Drawing.SystemColors.Info;
            this.cbUF.FormattingEnabled = true;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "GO",
            "ES",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR ",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(566, 236);
            this.cbUF.Margin = new System.Windows.Forms.Padding(4);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(48, 24);
            this.cbUF.TabIndex = 14;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Yellow;
            this.label24.Location = new System.Drawing.Point(611, 45);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 26);
            this.label24.TabIndex = 2;
            this.label24.Text = "* ";
            this.label24.Click += new System.EventHandler(this.label1_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(345, 14);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(62, 20);
            this.label29.TabIndex = 2;
            this.label29.Text = "Pessoa";
            this.label29.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbPessoa
            // 
            this.cbPessoa.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbPessoa.ForeColor = System.Drawing.SystemColors.Info;
            this.cbPessoa.FormattingEnabled = true;
            this.cbPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbPessoa.Location = new System.Drawing.Point(415, 13);
            this.cbPessoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbPessoa.Name = "cbPessoa";
            this.cbPessoa.Size = new System.Drawing.Size(118, 24);
            this.cbPessoa.TabIndex = 2;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.SystemColors.WindowText;
            this.tbCodigo.Location = new System.Drawing.Point(152, 13);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(72, 23);
            this.tbCodigo.TabIndex = 1;
            this.tbCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bairro\r\n";
            // 
            // tbBairro
            // 
            this.tbBairro.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbBairro.ForeColor = System.Drawing.SystemColors.Info;
            this.tbBairro.Location = new System.Drawing.Point(310, 206);
            this.tbBairro.Margin = new System.Windows.Forms.Padding(4);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(304, 23);
            this.tbBairro.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(611, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "* ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(296, 111);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 26);
            this.label18.TabIndex = 2;
            this.label18.Text = "* ";
            this.label18.Click += new System.EventHandler(this.label1_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Yellow;
            this.label22.Location = new System.Drawing.Point(611, 173);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(27, 26);
            this.label22.TabIndex = 2;
            this.label22.Text = "* ";
            this.label22.Click += new System.EventHandler(this.label1_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(475, 270);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 20);
            this.label21.TabIndex = 12;
            this.label21.Text = "Fax";
            this.label21.Click += new System.EventHandler(this.label13_Click);
            // 
            // mtbFonex
            // 
            this.mtbFonex.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mtbFonex.ForeColor = System.Drawing.SystemColors.Info;
            this.mtbFonex.Location = new System.Drawing.Point(513, 269);
            this.mtbFonex.Margin = new System.Windows.Forms.Padding(4);
            this.mtbFonex.Mask = "(99)99999-9999";
            this.mtbFonex.Name = "mtbFonex";
            this.mtbFonex.Size = new System.Drawing.Size(100, 23);
            this.mtbFonex.TabIndex = 17;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Yellow;
            this.label23.Location = new System.Drawing.Point(474, 173);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(27, 26);
            this.label23.TabIndex = 2;
            this.label23.Text = "* ";
            this.label23.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "E-mail";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tbEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.tbEmail.Location = new System.Drawing.Point(295, 141);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(318, 23);
            this.tbEmail.TabIndex = 8;
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // frmCadastroFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1101, 413);
            this.ControlBox = false;
            this.Controls.Add(this.mtbCNPJ);
            this.Controls.Add(this.mtbFonex);
            this.Controls.Add(this.mtbFonec);
            this.Controls.Add(this.mtbFonef);
            this.Controls.Add(this.mtbData);
            this.Controls.Add(this.mtbCEP);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.cbPessoa);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbRgInsc);
            this.Controls.Add(this.tbRazao);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Nome);
            this.Controls.Add(this.panel_butons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastroFor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.frmCadCli_Load);
            this.panel_butons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_butons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lb_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbRgInsc;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbObs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbRazao;
        private System.Windows.Forms.MaskedTextBox mtbCNPJ;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.MaskedTextBox mtbFonef;
        private System.Windows.Forms.MaskedTextBox mtbFonec;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbPessoa;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MaskedTextBox mtbFonex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
    }
}