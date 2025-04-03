namespace PraticasDeProgramacao_Desafio_Bim01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_criar = new System.Windows.Forms.Button();
            this.bt_ler = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.bt_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_criar
            // 
            this.bt_criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_criar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_criar.ForeColor = System.Drawing.Color.White;
            this.bt_criar.Location = new System.Drawing.Point(12, 12);
            this.bt_criar.Name = "bt_criar";
            this.bt_criar.Size = new System.Drawing.Size(133, 23);
            this.bt_criar.TabIndex = 1;
            this.bt_criar.Text = "Criar";
            this.bt_criar.UseVisualStyleBackColor = false;
            this.bt_criar.Click += new System.EventHandler(this.bt_criar_Click);
            // 
            // bt_ler
            // 
            this.bt_ler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_ler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ler.ForeColor = System.Drawing.Color.White;
            this.bt_ler.Location = new System.Drawing.Point(12, 41);
            this.bt_ler.Name = "bt_ler";
            this.bt_ler.Size = new System.Drawing.Size(133, 23);
            this.bt_ler.TabIndex = 2;
            this.bt_ler.Text = "Ler";
            this.bt_ler.UseVisualStyleBackColor = false;
            this.bt_ler.Click += new System.EventHandler(this.bt_ler_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar.ForeColor = System.Drawing.Color.White;
            this.bt_editar.Location = new System.Drawing.Point(12, 70);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(133, 23);
            this.bt_editar.TabIndex = 3;
            this.bt_editar.Text = "Editar";
            this.bt_editar.UseVisualStyleBackColor = false;
            this.bt_editar.Click += new System.EventHandler(this.bt_atualizar_Click);
            // 
            // bt_deletar
            // 
            this.bt_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_deletar.ForeColor = System.Drawing.Color.White;
            this.bt_deletar.Location = new System.Drawing.Point(12, 99);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(133, 23);
            this.bt_deletar.TabIndex = 5;
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.UseVisualStyleBackColor = false;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_fechar.Location = new System.Drawing.Point(12, 128);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.Size = new System.Drawing.Size(133, 23);
            this.bt_fechar.TabIndex = 6;
            this.bt_fechar.Text = "Fechar";
            this.bt_fechar.UseVisualStyleBackColor = false;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(157, 159);
            this.ControlBox = false;
            this.Controls.Add(this.bt_fechar);
            this.Controls.Add(this.bt_deletar);
            this.Controls.Add(this.bt_editar);
            this.Controls.Add(this.bt_ler);
            this.Controls.Add(this.bt_criar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_criar;
        private System.Windows.Forms.Button bt_ler;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.Button bt_fechar;
    }
}

