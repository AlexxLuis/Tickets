namespace Tickets
{
    partial class FormListagemFuncionarios
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
            components = new System.ComponentModel.Container();
            ticketBindingSource = new BindingSource(components);
            funcionarioBindingSource = new BindingSource(components);
            ticketBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(Models.Ticket);
            // 
            // funcionarioBindingSource
            // 
            funcionarioBindingSource.DataSource = typeof(Funcionario);
            // 
            // ticketBindingSource1
            // 
            ticketBindingSource1.DataSource = typeof(Models.Ticket);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(800, 450);
            dataGridView1.TabIndex = 0;
            // 
            // FormListagemFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "FormListagemFuncionarios";
            Text = "Listagem de Funcionarios";
            Load += FormListagemFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)funcionarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource funcionarioBindingSource;
        private DataGridViewTextBoxColumn ticketsCountDataGridViewTextBoxColumn;
        private BindingSource ticketBindingSource;
        private BindingSource ticketBindingSource1;
        private DataGridView dataGridView1;
    }
}