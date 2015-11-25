namespace DefSis
{
    partial class frmClientes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_butons = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_visualizar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_butons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(246, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(740, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1065, 404);
            this.dataGridView1.TabIndex = 1;
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
            this.panel_butons.Size = new System.Drawing.Size(1101, 76);
            this.panel_butons.TabIndex = 2;
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
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1101, 503);
            this.ControlBox = false;
            this.Controls.Add(this.panel_butons);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_butons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_visualizar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_butons;
        private System.Windows.Forms.Button button3;
    }
}