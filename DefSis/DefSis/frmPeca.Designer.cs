namespace DefSis
{
    partial class frmPeca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.gdPeca = new System.Windows.Forms.DataGridView();
            this.panel_butons = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPesquisa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdPeca)).BeginInit();
            this.panel_butons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.bt_novo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_alterar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_excluir, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_visualizar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_cancelar, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_novo
            // 
            this.bt_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_novo.CausesValidation = false;
            this.bt_novo.Image = global::DefSis.Properties.Resources.Add;
            this.bt_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_novo.Location = new System.Drawing.Point(3, 3);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(142, 49);
            this.bt_novo.TabIndex = 0;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Image = global::DefSis.Properties.Resources.Modify;
            this.bt_alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_alterar.Location = new System.Drawing.Point(151, 3);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(142, 49);
            this.bt_alterar.TabIndex = 0;
            this.bt_alterar.Text = "Alterar";
            this.bt_alterar.UseVisualStyleBackColor = true;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Image = global::DefSis.Properties.Resources.Erase;
            this.bt_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_excluir.Location = new System.Drawing.Point(299, 3);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(142, 49);
            this.bt_excluir.TabIndex = 0;
            this.bt_excluir.Text = "Excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            // 
            // bt_visualizar
            // 
            this.bt_visualizar.Image = global::DefSis.Properties.Resources.View;
            this.bt_visualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_visualizar.Location = new System.Drawing.Point(447, 3);
            this.bt_visualizar.Name = "bt_visualizar";
            this.bt_visualizar.Size = new System.Drawing.Size(142, 49);
            this.bt_visualizar.TabIndex = 0;
            this.bt_visualizar.Text = "Visualizar";
            this.bt_visualizar.UseVisualStyleBackColor = true;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Image = global::DefSis.Properties.Resources.No;
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_cancelar.Location = new System.Drawing.Point(595, 3);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(142, 49);
            this.bt_cancelar.TabIndex = 0;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // gdPeca
            // 
            this.gdPeca.AllowUserToAddRows = false;
            this.gdPeca.AllowUserToDeleteRows = false;
            this.gdPeca.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdPeca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdPeca.Location = new System.Drawing.Point(0, 38);
            this.gdPeca.Name = "gdPeca";
            this.gdPeca.ReadOnly = true;
            this.gdPeca.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gdPeca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdPeca.Size = new System.Drawing.Size(920, 391);
            this.gdPeca.TabIndex = 1;
            this.gdPeca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdCliente_CellContentClick);
            // 
            // panel_butons
            // 
            this.panel_butons.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_butons.Controls.Add(this.pictureBox1);
            this.panel_butons.Controls.Add(this.button3);
            this.panel_butons.Controls.Add(this.tableLayoutPanel1);
            this.panel_butons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_butons.Location = new System.Drawing.Point(0, 427);
            this.panel_butons.Margin = new System.Windows.Forms.Padding(4);
            this.panel_butons.Name = "panel_butons";
            this.panel_butons.Size = new System.Drawing.Size(920, 76);
            this.panel_butons.TabIndex = 2;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(526, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta Cliente";
            // 
            // tbPesquisa
            // 
            this.tbPesquisa.Location = new System.Drawing.Point(654, 12);
            this.tbPesquisa.Name = "tbPesquisa";
            this.tbPesquisa.Size = new System.Drawing.Size(254, 20);
            this.tbPesquisa.TabIndex = 1;
            this.tbPesquisa.TextChanged += new System.EventHandler(this.tbPesquisa_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 42);
            this.panel1.TabIndex = 4;
            // 
            // frmPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(920, 503);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_butons);
            this.Controls.Add(this.gdPeca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPeca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peças";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdPeca)).EndInit();
            this.panel_butons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.DataGridView gdPeca;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_butons;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPesquisa;
        private System.Windows.Forms.Panel panel1;
    }
}