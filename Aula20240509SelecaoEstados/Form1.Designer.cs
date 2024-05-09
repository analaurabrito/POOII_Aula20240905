namespace Aula20240509SelecaoEstados
{
    partial class Form1
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
            this.txbAdicionar = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.lbxTodosEstados = new System.Windows.Forms.ListBox();
            this.btnCopiarTodos = new System.Windows.Forms.Button();
            this.btnCopiarSelecionados = new System.Windows.Forms.Button();
            this.lbxEstadosSelecionados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbAdicionar
            // 
            this.txbAdicionar.Location = new System.Drawing.Point(102, 10);
            this.txbAdicionar.Name = "txbAdicionar";
            this.txbAdicionar.Size = new System.Drawing.Size(334, 20);
            this.txbAdicionar.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cbxEstados
            // 
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(12, 53);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(424, 21);
            this.cbxEstados.TabIndex = 2;
            // 
            // lbxTodosEstados
            // 
            this.lbxTodosEstados.FormattingEnabled = true;
            this.lbxTodosEstados.Location = new System.Drawing.Point(12, 125);
            this.lbxTodosEstados.Name = "lbxTodosEstados";
            this.lbxTodosEstados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxTodosEstados.Size = new System.Drawing.Size(194, 69);
            this.lbxTodosEstados.TabIndex = 3;
            // 
            // btnCopiarTodos
            // 
            this.btnCopiarTodos.Location = new System.Drawing.Point(12, 96);
            this.btnCopiarTodos.Name = "btnCopiarTodos";
            this.btnCopiarTodos.Size = new System.Drawing.Size(100, 23);
            this.btnCopiarTodos.TabIndex = 4;
            this.btnCopiarTodos.Text = "Copiar Todos";
            this.btnCopiarTodos.UseVisualStyleBackColor = true;
            this.btnCopiarTodos.Click += new System.EventHandler(this.btnCopiarTodos_Click);
            // 
            // btnCopiarSelecionados
            // 
            this.btnCopiarSelecionados.Location = new System.Drawing.Point(242, 96);
            this.btnCopiarSelecionados.Name = "btnCopiarSelecionados";
            this.btnCopiarSelecionados.Size = new System.Drawing.Size(130, 23);
            this.btnCopiarSelecionados.TabIndex = 6;
            this.btnCopiarSelecionados.Text = "Copiar Selecionados";
            this.btnCopiarSelecionados.UseVisualStyleBackColor = true;
            this.btnCopiarSelecionados.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxEstadosSelecionados
            // 
            this.lbxEstadosSelecionados.FormattingEnabled = true;
            this.lbxEstadosSelecionados.Location = new System.Drawing.Point(242, 125);
            this.lbxEstadosSelecionados.Name = "lbxEstadosSelecionados";
            this.lbxEstadosSelecionados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbxEstadosSelecionados.Size = new System.Drawing.Size(194, 69);
            this.lbxEstadosSelecionados.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 201);
            this.Controls.Add(this.btnCopiarSelecionados);
            this.Controls.Add(this.lbxEstadosSelecionados);
            this.Controls.Add(this.btnCopiarTodos);
            this.Controls.Add(this.lbxTodosEstados);
            this.Controls.Add(this.cbxEstados);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txbAdicionar);
            this.Name = "Form1";
            this.Text = "Estados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAdicionar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.ListBox lbxTodosEstados;
        private System.Windows.Forms.Button btnCopiarTodos;
        private System.Windows.Forms.Button btnCopiarSelecionados;
        private System.Windows.Forms.ListBox lbxEstadosSelecionados;
    }
}

