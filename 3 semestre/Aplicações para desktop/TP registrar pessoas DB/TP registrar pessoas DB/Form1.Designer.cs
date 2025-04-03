namespace TP_registrar_pessoas_DB
{
    partial class Form1
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
            this.código_lb = new System.Windows.Forms.Label();
            this.nome_lb = new System.Windows.Forms.Label();
            this.sexo_lb = new System.Windows.Forms.Label();
            this.idade_lb = new System.Windows.Forms.Label();
            this.salvar_bt = new System.Windows.Forms.Button();
            this.ler_bt = new System.Windows.Forms.Button();
            this.limpar_bt = new System.Windows.Forms.Button();
            this.código_tb = new System.Windows.Forms.TextBox();
            this.idade_nud1 = new System.Windows.Forms.NumericUpDown();
            this.nome_tb = new System.Windows.Forms.TextBox();
            this.sexo_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.idade_nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // código_lb
            // 
            this.código_lb.AutoSize = true;
            this.código_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.código_lb.Location = new System.Drawing.Point(15, 29);
            this.código_lb.Name = "código_lb";
            this.código_lb.Size = new System.Drawing.Size(75, 25);
            this.código_lb.TabIndex = 0;
            this.código_lb.Text = "Código";
            // 
            // nome_lb
            // 
            this.nome_lb.AutoSize = true;
            this.nome_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_lb.Location = new System.Drawing.Point(15, 80);
            this.nome_lb.Name = "nome_lb";
            this.nome_lb.Size = new System.Drawing.Size(64, 25);
            this.nome_lb.TabIndex = 1;
            this.nome_lb.Text = "Nome";
            // 
            // sexo_lb
            // 
            this.sexo_lb.AutoSize = true;
            this.sexo_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo_lb.Location = new System.Drawing.Point(15, 105);
            this.sexo_lb.Name = "sexo_lb";
            this.sexo_lb.Size = new System.Drawing.Size(58, 25);
            this.sexo_lb.TabIndex = 2;
            this.sexo_lb.Text = "Sexo";
            // 
            // idade_lb
            // 
            this.idade_lb.AutoSize = true;
            this.idade_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idade_lb.Location = new System.Drawing.Point(15, 55);
            this.idade_lb.Name = "idade_lb";
            this.idade_lb.Size = new System.Drawing.Size(61, 25);
            this.idade_lb.TabIndex = 3;
            this.idade_lb.Text = "Idade";
            // 
            // salvar_bt
            // 
            this.salvar_bt.Location = new System.Drawing.Point(20, 132);
            this.salvar_bt.Name = "salvar_bt";
            this.salvar_bt.Size = new System.Drawing.Size(75, 23);
            this.salvar_bt.TabIndex = 4;
            this.salvar_bt.Text = "Salvar";
            this.salvar_bt.UseVisualStyleBackColor = true;
            this.salvar_bt.Click += new System.EventHandler(this.salvar_bt_Click);
            // 
            // ler_bt
            // 
            this.ler_bt.Location = new System.Drawing.Point(101, 132);
            this.ler_bt.Name = "ler_bt";
            this.ler_bt.Size = new System.Drawing.Size(75, 23);
            this.ler_bt.TabIndex = 5;
            this.ler_bt.Text = "Ler";
            this.ler_bt.UseVisualStyleBackColor = true;
            this.ler_bt.Click += new System.EventHandler(this.ler_bt_Click);
            // 
            // limpar_bt
            // 
            this.limpar_bt.Location = new System.Drawing.Point(182, 132);
            this.limpar_bt.Name = "limpar_bt";
            this.limpar_bt.Size = new System.Drawing.Size(75, 23);
            this.limpar_bt.TabIndex = 6;
            this.limpar_bt.Text = "Limpar";
            this.limpar_bt.UseVisualStyleBackColor = true;
            this.limpar_bt.Click += new System.EventHandler(this.limpar_bt_Click);
            // 
            // código_tb
            // 
            this.código_tb.Location = new System.Drawing.Point(96, 29);
            this.código_tb.Name = "código_tb";
            this.código_tb.Size = new System.Drawing.Size(161, 20);
            this.código_tb.TabIndex = 7;
            // 
            // idade_nud1
            // 
            this.idade_nud1.Location = new System.Drawing.Point(96, 55);
            this.idade_nud1.Name = "idade_nud1";
            this.idade_nud1.Size = new System.Drawing.Size(161, 20);
            this.idade_nud1.TabIndex = 8;
            // 
            // nome_tb
            // 
            this.nome_tb.Location = new System.Drawing.Point(96, 80);
            this.nome_tb.Name = "nome_tb";
            this.nome_tb.Size = new System.Drawing.Size(161, 20);
            this.nome_tb.TabIndex = 9;
            // 
            // sexo_cb
            // 
            this.sexo_cb.DisplayMember = "Masc";
            this.sexo_cb.FormattingEnabled = true;
            this.sexo_cb.Items.AddRange(new object[] {
            "",
            "Masc",
            "Fem"});
            this.sexo_cb.Location = new System.Drawing.Point(96, 105);
            this.sexo_cb.Name = "sexo_cb";
            this.sexo_cb.Size = new System.Drawing.Size(161, 21);
            this.sexo_cb.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 171);
            this.Controls.Add(this.sexo_cb);
            this.Controls.Add(this.nome_tb);
            this.Controls.Add(this.idade_nud1);
            this.Controls.Add(this.código_tb);
            this.Controls.Add(this.limpar_bt);
            this.Controls.Add(this.ler_bt);
            this.Controls.Add(this.salvar_bt);
            this.Controls.Add(this.idade_lb);
            this.Controls.Add(this.sexo_lb);
            this.Controls.Add(this.nome_lb);
            this.Controls.Add(this.código_lb);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idade_nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label código_lb;
        private System.Windows.Forms.Label nome_lb;
        private System.Windows.Forms.Label sexo_lb;
        private System.Windows.Forms.Label idade_lb;
        private System.Windows.Forms.Button salvar_bt;
        private System.Windows.Forms.Button ler_bt;
        private System.Windows.Forms.Button limpar_bt;
        private System.Windows.Forms.TextBox código_tb;
        private System.Windows.Forms.NumericUpDown idade_nud1;
        private System.Windows.Forms.TextBox nome_tb;
        private System.Windows.Forms.ComboBox sexo_cb;
    }
}

