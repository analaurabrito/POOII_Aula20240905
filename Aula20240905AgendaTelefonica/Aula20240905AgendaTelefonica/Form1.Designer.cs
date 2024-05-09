namespace Aula20240905AgendaTelefonica
{
    partial class AgendaTelefonica
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.chbxTermos = new System.Windows.Forms.CheckBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.txbNomeSelectionado = new System.Windows.Forms.TextBox();
            this.txbTelefoneSelecionado = new System.Windows.Forms.TextBox();
            this.txbTipoSelecionado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(207, 82);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(421, 20);
            this.txbNome.TabIndex = 3;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(207, 134);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(421, 20);
            this.txbTelefone.TabIndex = 4;
            this.txbTelefone.TextChanged += new System.EventHandler(this.txbTelefone_TextChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Comercial",
            "Pessoal",
            "WhatsApp"});
            this.cbxTipo.Location = new System.Drawing.Point(207, 187);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(421, 21);
            this.cbxTipo.TabIndex = 5;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // chbxTermos
            // 
            this.chbxTermos.AutoSize = true;
            this.chbxTermos.Location = new System.Drawing.Point(362, 244);
            this.chbxTermos.Name = "chbxTermos";
            this.chbxTermos.Size = new System.Drawing.Size(104, 17);
            this.chbxTermos.TabIndex = 6;
            this.chbxTermos.Text = "Aceito os termos";
            this.chbxTermos.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(362, 268);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(104, 30);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(207, 337);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(231, 108);
            this.lbxLista.TabIndex = 8;
            // 
            // txbNomeSelectionado
            // 
            this.txbNomeSelectionado.Location = new System.Drawing.Point(465, 337);
            this.txbNomeSelectionado.Name = "txbNomeSelectionado";
            this.txbNomeSelectionado.ReadOnly = true;
            this.txbNomeSelectionado.Size = new System.Drawing.Size(163, 20);
            this.txbNomeSelectionado.TabIndex = 9;
            this.txbNomeSelectionado.Visible = false;
            // 
            // txbTelefoneSelecionado
            // 
            this.txbTelefoneSelecionado.Location = new System.Drawing.Point(465, 380);
            this.txbTelefoneSelecionado.Name = "txbTelefoneSelecionado";
            this.txbTelefoneSelecionado.ReadOnly = true;
            this.txbTelefoneSelecionado.Size = new System.Drawing.Size(163, 20);
            this.txbTelefoneSelecionado.TabIndex = 10;
            this.txbTelefoneSelecionado.Visible = false;
            // 
            // txbTipoSelecionado
            // 
            this.txbTipoSelecionado.Location = new System.Drawing.Point(465, 424);
            this.txbTipoSelecionado.Name = "txbTipoSelecionado";
            this.txbTipoSelecionado.ReadOnly = true;
            this.txbTipoSelecionado.Size = new System.Drawing.Size(163, 20);
            this.txbTipoSelecionado.TabIndex = 11;
            this.txbTipoSelecionado.Visible = false;
            // 
            // AgendaTelefonica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.txbTipoSelecionado);
            this.Controls.Add(this.txbTelefoneSelecionado);
            this.Controls.Add(this.txbNomeSelectionado);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.chbxTermos);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AgendaTelefonica";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.CheckBox chbxTermos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.TextBox txbNomeSelectionado;
        private System.Windows.Forms.TextBox txbTelefoneSelecionado;
        private System.Windows.Forms.TextBox txbTipoSelecionado;
    }
}

