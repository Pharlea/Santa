namespace Mensagens_por_ip
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
            this.lb_CaixaDeTexto = new System.Windows.Forms.ListBox();
            this.tb_Mensagens = new System.Windows.Forms.TextBox();
            this.bt_Enviar = new System.Windows.Forms.Button();
            this.bt_LigarServidor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_CaixaDeTexto
            // 
            this.lb_CaixaDeTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_CaixaDeTexto.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_CaixaDeTexto.FormattingEnabled = true;
            this.lb_CaixaDeTexto.Location = new System.Drawing.Point(13, 13);
            this.lb_CaixaDeTexto.Name = "lb_CaixaDeTexto";
            this.lb_CaixaDeTexto.Size = new System.Drawing.Size(264, 121);
            this.lb_CaixaDeTexto.TabIndex = 0;
            // 
            // tb_Mensagens
            // 
            this.tb_Mensagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_Mensagens.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_Mensagens.Location = new System.Drawing.Point(13, 140);
            this.tb_Mensagens.Name = "tb_Mensagens";
            this.tb_Mensagens.Size = new System.Drawing.Size(205, 20);
            this.tb_Mensagens.TabIndex = 1;
            // 
            // bt_Enviar
            // 
            this.bt_Enviar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Enviar.Location = new System.Drawing.Point(224, 138);
            this.bt_Enviar.Name = "bt_Enviar";
            this.bt_Enviar.Size = new System.Drawing.Size(53, 23);
            this.bt_Enviar.TabIndex = 2;
            this.bt_Enviar.Text = "Enviar";
            this.bt_Enviar.UseVisualStyleBackColor = true;
            this.bt_Enviar.Click += new System.EventHandler(this.bt_Enviar_Click);
            // 
            // bt_LigarServidor
            // 
            this.bt_LigarServidor.BackColor = System.Drawing.Color.Red;
            this.bt_LigarServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_LigarServidor.Location = new System.Drawing.Point(13, 166);
            this.bt_LigarServidor.Name = "bt_LigarServidor";
            this.bt_LigarServidor.Size = new System.Drawing.Size(264, 23);
            this.bt_LigarServidor.TabIndex = 3;
            this.bt_LigarServidor.Text = "Ligar servidor";
            this.bt_LigarServidor.UseVisualStyleBackColor = false;
            this.bt_LigarServidor.Click += new System.EventHandler(this.bt_LigarServidor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(294, 204);
            this.Controls.Add(this.bt_LigarServidor);
            this.Controls.Add(this.bt_Enviar);
            this.Controls.Add(this.tb_Mensagens);
            this.Controls.Add(this.lb_CaixaDeTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Envio de mensagens por ip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_CaixaDeTexto;
        private System.Windows.Forms.TextBox tb_Mensagens;
        private System.Windows.Forms.Button bt_Enviar;
        private System.Windows.Forms.Button bt_LigarServidor;
    }
}

