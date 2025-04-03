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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acesso));
            this.bt_Listbox = new System.Windows.Forms.Button();
            this.lb_mostrar_dados = new System.Windows.Forms.ListBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ppd_preview = new System.Windows.Forms.PrintPreviewDialog();
            this.bt_mostrar_preview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Listbox
            // 
            this.bt_Listbox.Location = new System.Drawing.Point(12, 191);
            this.bt_Listbox.Name = "bt_Listbox";
            this.bt_Listbox.Size = new System.Drawing.Size(283, 23);
            this.bt_Listbox.TabIndex = 2;
            this.bt_Listbox.Text = "Listar no listbox";
            this.bt_Listbox.UseVisualStyleBackColor = true;
            this.bt_Listbox.Click += new System.EventHandler(this.bt_Listbox_Click);
            // 
            // lb_mostrar_dados
            // 
            this.lb_mostrar_dados.FormattingEnabled = true;
            this.lb_mostrar_dados.Location = new System.Drawing.Point(12, 12);
            this.lb_mostrar_dados.Name = "lb_mostrar_dados";
            this.lb_mostrar_dados.Size = new System.Drawing.Size(582, 173);
            this.lb_mostrar_dados.TabIndex = 5;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ppd_preview
            // 
            this.ppd_preview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd_preview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd_preview.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd_preview.Document = this.printDocument1;
            this.ppd_preview.Enabled = true;
            this.ppd_preview.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd_preview.Icon")));
            this.ppd_preview.Name = "ppd_preview";
            this.ppd_preview.Visible = false;
            // 
            // bt_mostrar_preview
            // 
            this.bt_mostrar_preview.Location = new System.Drawing.Point(311, 191);
            this.bt_mostrar_preview.Name = "bt_mostrar_preview";
            this.bt_mostrar_preview.Size = new System.Drawing.Size(283, 23);
            this.bt_mostrar_preview.TabIndex = 6;
            this.bt_mostrar_preview.Text = "Mostrar pré-visualização";
            this.bt_mostrar_preview.UseVisualStyleBackColor = true;
            this.bt_mostrar_preview.Click += new System.EventHandler(this.bt_mostrar_preview_Click);
            // 
            // Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 222);
            this.Controls.Add(this.bt_mostrar_preview);
            this.Controls.Add(this.lb_mostrar_dados);
            this.Controls.Add(this.bt_Listbox);
            this.Name = "Acesso";
            this.Text = "Acessar o banco de dados";
            this.Load += new System.EventHandler(this.Acesso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Listbox;
        private System.Windows.Forms.ListBox lb_mostrar_dados;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog ppd_preview;
        private System.Windows.Forms.Button bt_mostrar_preview;
    }
}

