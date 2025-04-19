namespace Tickets
{
    partial class FormMain
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
            btnCadastro = new Button();
            label1 = new Label();
            btnTickets = new Button();
            btnListarFuncionarios = new Button();
            btnGerarRelatorio = new Button();
            btnRegistrarTickets = new Button();
            SuspendLayout();
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(67, 174);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(92, 51);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastrar Funcionarios";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 46);
            label1.Name = "label1";
            label1.Size = new Size(247, 32);
            label1.TabIndex = 1;
            label1.Text = "Gestor de Tickets";
            label1.Click += label1_Click;
            // 
            // btnTickets
            // 
            btnTickets.Location = new Point(162, 174);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(92, 51);
            btnTickets.TabIndex = 2;
            btnTickets.Text = "Editar Cadastros";
            btnTickets.UseVisualStyleBackColor = true;
            btnTickets.Click += btnCadastroTickets_Click;
            // 
            // btnListarFuncionarios
            // 
            btnListarFuncionarios.Location = new Point(67, 231);
            btnListarFuncionarios.Name = "btnListarFuncionarios";
            btnListarFuncionarios.Size = new Size(130, 51);
            btnListarFuncionarios.TabIndex = 3;
            btnListarFuncionarios.Text = "Listar Funcionarios";
            btnListarFuncionarios.UseVisualStyleBackColor = true;
            btnListarFuncionarios.Click += btnListarFuncionarios_Click;
            // 
            // btnGerarRelatorio
            // 
            btnGerarRelatorio.Location = new Point(203, 231);
            btnGerarRelatorio.Name = "btnGerarRelatorio";
            btnGerarRelatorio.Size = new Size(149, 51);
            btnGerarRelatorio.TabIndex = 4;
            btnGerarRelatorio.Text = "Gerar Relatorio";
            btnGerarRelatorio.UseVisualStyleBackColor = true;
            btnGerarRelatorio.Click += btnGerarRelatorio_Click;
            // 
            // btnRegistrarTickets
            // 
            btnRegistrarTickets.Location = new Point(260, 174);
            btnRegistrarTickets.Name = "btnRegistrarTickets";
            btnRegistrarTickets.Size = new Size(92, 51);
            btnRegistrarTickets.TabIndex = 5;
            btnRegistrarTickets.Text = "Cadastrar  Tickets";
            btnRegistrarTickets.UseVisualStyleBackColor = true;
            btnRegistrarTickets.Click += btnRegistrarTickets_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 364);
            Controls.Add(btnRegistrarTickets);
            Controls.Add(btnGerarRelatorio);
            Controls.Add(btnListarFuncionarios);
            Controls.Add(btnTickets);
            Controls.Add(label1);
            Controls.Add(btnCadastro);
            Name = "FormMain";
            Text = "Gestor de Tickets";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastro;
        private Label label1;
        private Button btnCadastroTickets;
        private Button btnListarFuncionarios;
        private Button btnGerarRelatorio;
        private Button btnTickets;
        private Button btnRegistrarTickets;
    }
}