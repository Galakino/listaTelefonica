namespace listaTelefonica
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTelefoneEncontrado = new System.Windows.Forms.Label();
            this.txbNomeLista = new System.Windows.Forms.TextBox();
            this.cbxTelefones = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.cbxIdentifica = new System.Windows.Forms.ComboBox();
            this.cbxEscolha = new System.Windows.Forms.ComboBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblErro1 = new System.Windows.Forms.Label();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxIdentificacao = new System.Windows.Forms.ComboBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.lblTelefoneEncontrado);
            this.tabPage1.Controls.Add(this.txbNomeLista);
            this.tabPage1.Controls.Add(this.cbxTelefones);
            this.tabPage1.Controls.Add(this.btnListar);
            this.tabPage1.Controls.Add(this.cbxIdentifica);
            this.tabPage1.Controls.Add(this.cbxEscolha);
            this.tabPage1.Controls.Add(this.lblBuscar);
            this.tabPage1.Controls.Add(this.lblErro1);
            this.tabPage1.Controls.Add(this.lstLista);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnLimpar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listar contatos";
            // 
            // lblTelefoneEncontrado
            // 
            this.lblTelefoneEncontrado.AutoSize = true;
            this.lblTelefoneEncontrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTelefoneEncontrado.Location = new System.Drawing.Point(99, 136);
            this.lblTelefoneEncontrado.Name = "lblTelefoneEncontrado";
            this.lblTelefoneEncontrado.Size = new System.Drawing.Size(55, 16);
            this.lblTelefoneEncontrado.TabIndex = 13;
            this.lblTelefoneEncontrado.Text = "telefone";
            // 
            // txbNomeLista
            // 
            this.txbNomeLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNomeLista.Location = new System.Drawing.Point(252, 85);
            this.txbNomeLista.Name = "txbNomeLista";
            this.txbNomeLista.Size = new System.Drawing.Size(110, 22);
            this.txbNomeLista.TabIndex = 12;
            this.txbNomeLista.Text = "Digite um nome";
            // 
            // cbxTelefones
            // 
            this.cbxTelefones.FormattingEnabled = true;
            this.cbxTelefones.Location = new System.Drawing.Point(252, 83);
            this.cbxTelefones.Name = "cbxTelefones";
            this.cbxTelefones.Size = new System.Drawing.Size(110, 24);
            this.cbxTelefones.TabIndex = 11;
            this.cbxTelefones.Text = "Telefones";
            this.cbxTelefones.SelectedIndexChanged += new System.EventHandler(this.cbxTelefones_SelectedIndexChanged);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(378, 81);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(84, 26);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // cbxIdentifica
            // 
            this.cbxIdentifica.FormattingEnabled = true;
            this.cbxIdentifica.Items.AddRange(new object[] {
            "Mãe",
            "Pai",
            "Namorada",
            "Tio",
            "Tia",
            "Primo",
            "Prima",
            "Avô",
            "Avó",
            "Colega",
            "Amigo",
            "Amiga"});
            this.cbxIdentifica.Location = new System.Drawing.Point(252, 83);
            this.cbxIdentifica.Name = "cbxIdentifica";
            this.cbxIdentifica.Size = new System.Drawing.Size(110, 24);
            this.cbxIdentifica.TabIndex = 8;
            this.cbxIdentifica.Text = "Identificar";
            // 
            // cbxEscolha
            // 
            this.cbxEscolha.FormattingEnabled = true;
            this.cbxEscolha.Items.AddRange(new object[] {
            "Listar tudo",
            "Nome",
            "Telefone",
            "Identificação"});
            this.cbxEscolha.Location = new System.Drawing.Point(122, 83);
            this.cbxEscolha.Name = "cbxEscolha";
            this.cbxEscolha.Size = new System.Drawing.Size(110, 24);
            this.cbxEscolha.TabIndex = 7;
            this.cbxEscolha.SelectedIndexChanged += new System.EventHandler(this.cbxEscolha_SelectedIndexChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(30, 86);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(86, 16);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // lblErro1
            // 
            this.lblErro1.AutoSize = true;
            this.lblErro1.ForeColor = System.Drawing.Color.Black;
            this.lblErro1.Location = new System.Drawing.Point(6, 3);
            this.lblErro1.Name = "lblErro1";
            this.lblErro1.Size = new System.Drawing.Size(45, 16);
            this.lblErro1.TabIndex = 5;
            this.lblErro1.Text = "<erro>";
            // 
            // lstLista
            // 
            this.lstLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lstLista.FormattingEnabled = true;
            this.lstLista.ItemHeight = 16;
            this.lstLista.Location = new System.Drawing.Point(102, 136);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(332, 148);
            this.lstLista.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(159, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seus contatos aqui:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(226, 303);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 29);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lblErro);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inserir contatos";
            // 
            // cbxIdentificacao
            // 
            this.cbxIdentificacao.FormattingEnabled = true;
            this.cbxIdentificacao.Items.AddRange(new object[] {
            "Mãe",
            "Pai",
            "Namorada",
            "Tio",
            "Tia",
            "Primo",
            "Prima",
            "Avô",
            "Avó",
            "Colega",
            "Amigo",
            "Amiga"});
            this.cbxIdentificacao.Location = new System.Drawing.Point(130, 180);
            this.cbxIdentificacao.Name = "cbxIdentificacao";
            this.cbxIdentificacao.Size = new System.Drawing.Size(100, 24);
            this.cbxIdentificacao.TabIndex = 10;
            this.cbxIdentificacao.Text = "Quem é?";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(28, 347);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(45, 16);
            this.lblErro.TabIndex = 9;
            this.lblErro.Text = "<erro>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Identificação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadastre seus contatos aqui";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(63, 137);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 16);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(80, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 16);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(130, 134);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 22);
            this.txbTelefone.TabIndex = 2;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(130, 92);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 22);
            this.txbNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(97, 242);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 29);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.cbxIdentificacao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbTelefone);
            this.panel1.Controls.Add(this.txbNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Location = new System.Drawing.Point(120, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 309);
            this.panel1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 405);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Label lblErro1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ComboBox cbxIdentifica;
        private System.Windows.Forms.ComboBox cbxEscolha;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cbxTelefones;
        private System.Windows.Forms.ComboBox cbxIdentificacao;
        private System.Windows.Forms.TextBox txbNomeLista;
        private System.Windows.Forms.Label lblTelefoneEncontrado;
        private System.Windows.Forms.Panel panel1;
    }
}

