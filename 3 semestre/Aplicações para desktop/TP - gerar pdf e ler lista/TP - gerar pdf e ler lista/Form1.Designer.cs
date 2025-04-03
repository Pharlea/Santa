namespace TP___gerar_pdf_e_ler_lista
{
    partial class Acesso
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
            this.bt_Listbox = new System.Windows.Forms.Button();
            this.bt_word = new System.Windows.Forms.Button();
            this.bt_excel = new System.Windows.Forms.Button();
            this.lb_mostrar_dados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_Listbox
            // 
            this.bt_Listbox.Location = new System.Drawing.Point(211, 199);
            this.bt_Listbox.Name = "bt_Listbox";
            this.bt_Listbox.Size = new System.Drawing.Size(184, 23);
            this.bt_Listbox.TabIndex = 2;
            this.bt_Listbox.Text = "Listar no listbox";
            this.bt_Listbox.UseVisualStyleBackColor = true;
            this.bt_Listbox.Click += new System.EventHandler(this.bt_Listbox_Click);
            // 
            // bt_word
            // 
            this.bt_word.Location = new System.Drawing.Point(211, 228);
            this.bt_word.Name = "bt_word";
            this.bt_word.Size = new System.Drawing.Size(184, 23);
            this.bt_word.TabIndex = 3;
            this.bt_word.Text = "Listar no word";
            this.bt_word.UseVisualStyleBackColor = true;
            this.bt_word.Click += new System.EventHandler(this.bt_word_Click);
            // 
            // bt_excel
            // 
            this.bt_excel.Location = new System.Drawing.Point(211, 259);
            this.bt_excel.Name = "bt_excel";
            this.bt_excel.Size = new System.Drawing.Size(184, 23);
            this.bt_excel.TabIndex = 4;
            this.bt_excel.Text = "Listar no excel";
            this.bt_excel.UseVisualStyleBackColor = true;
            this.bt_excel.Click += new System.EventHandler(this.bt_excel_Click);
            // 
            // lb_mostrar_dados
            // 
            this.lb_mostrar_dados.FormattingEnabled = true;
            this.lb_mostrar_dados.Location = new System.Drawing.Point(12, 12);
            this.lb_mostrar_dados.Name = "lb_mostrar_dados";
            this.lb_mostrar_dados.Size = new System.Drawing.Size(582, 173);
            this.lb_mostrar_dados.TabIndex = 5;
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 302);
            this.Controls.Add(this.lb_mostrar_dados);
            this.Controls.Add(this.bt_excel);
            this.Controls.Add(this.bt_word);
            this.Controls.Add(this.bt_Listbox);
            this.Name = "Acesso";
            this.Text = "Acessar o banco de dados";
            this.Load += new System.EventHandler(this.Acesso_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_Listbox;
        private System.Windows.Forms.Button bt_word;
        private System.Windows.Forms.Button bt_excel;
        private System.Windows.Forms.ListBox lb_mostrar_dados;
    }
}

