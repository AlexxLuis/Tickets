namespace Tickets
{
    partial class FormEditarCadastro
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
            btnGravar = new Button();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            cbSituacao = new ComboBox();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            btnPesquisar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(354, 124);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 23);
            btnGravar.TabIndex = 0;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(15, 124);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(121, 124);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(100, 23);
            txtCpf.TabIndex = 2;
            txtCpf.TextChanged += textBox2_TextChanged;
            // 
            // cbSituacao
            // 
            cbSituacao.FormattingEnabled = true;
            cbSituacao.Location = new Point(227, 124);
            cbSituacao.Name = "cbSituacao";
            cbSituacao.Size = new Size(121, 23);
            cbSituacao.TabIndex = 3;
            cbSituacao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Arial", 12F);
            Label3.Location = new Point(39, 103);
            Label3.Name = "Label3";
            Label3.Size = new Size(50, 18);
            Label3.TabIndex = 4;
            Label3.Text = "Nome";
            Label3.Click += Label3_Click;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Arial", 12F);
            Label2.Location = new Point(149, 103);
            Label2.Name = "Label2";
            Label2.Size = new Size(41, 18);
            Label2.TabIndex = 5;
            Label2.Text = "CPF";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Arial", 12F);
            Label1.Location = new Point(254, 103);
            Label1.Name = "Label1";
            Label1.Size = new Size(70, 18);
            Label1.TabIndex = 6;
            Label1.Text = "Situação";
            Label1.Click += cbSituacao_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(160, 188);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 20.25F);
            label4.Location = new Point(64, 9);
            label4.Name = "label4";
            label4.Size = new Size(284, 32);
            label4.TabIndex = 8;
            label4.Text = "Edição de cadastros";
            // 
            // FormEditarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 249);
            Controls.Add(label4);
            Controls.Add(btnPesquisar);
            Controls.Add(Label1);
            Controls.Add(Label2);
            Controls.Add(Label3);
            Controls.Add(cbSituacao);
            Controls.Add(txtCpf);
            Controls.Add(txtNome);
            Controls.Add(btnGravar);
            Name = "FormEditarCadastro";
            Text = "Editação de Cadastro";
            Load += FormEditarCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGravar;
        private TextBox txtNome;
        private TextBox txtCpf;
        private ComboBox cbSituacao;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private Button btnPesquisar;
        private Label label4;
    }
}