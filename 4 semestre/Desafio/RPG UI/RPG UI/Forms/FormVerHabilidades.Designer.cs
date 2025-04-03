namespace RPG_UI
{
    partial class FormVerHabilidades
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
            ePOSOne.btnProduct.Button_WOC bt_buscarTodas;
            this.pn_main = new System.Windows.Forms.Panel();
            this.bt_buscar = new ePOSOne.btnProduct.Button_WOC();
            this.bt_voltar = new ePOSOne.btnProduct.Button_WOC();
            this.bt_criar_editar = new System.Windows.Forms.Button();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.tb_barraDePesquisa = new RPG_UI.MyTextBox();
            bt_buscarTodas = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // bt_buscarTodas
            // 
            bt_buscarTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            bt_buscarTodas.BorderColor = System.Drawing.Color.Transparent;
            bt_buscarTodas.ButtonColor = System.Drawing.Color.Black;
            bt_buscarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_buscarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            bt_buscarTodas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            bt_buscarTodas.Location = new System.Drawing.Point(721, 41);
            bt_buscarTodas.Name = "bt_buscarTodas";
            bt_buscarTodas.OnHoverBorderColor = System.Drawing.Color.Transparent;
            bt_buscarTodas.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            bt_buscarTodas.OnHoverTextColor = System.Drawing.Color.White;
            bt_buscarTodas.Size = new System.Drawing.Size(30, 30);
            bt_buscarTodas.TabIndex = 101;
            bt_buscarTodas.Text = "⤅";
            bt_buscarTodas.TextColor = System.Drawing.Color.White;
            bt_buscarTodas.UseVisualStyleBackColor = true;
            bt_buscarTodas.Click += new System.EventHandler(this.bt_buscarTodas_Click);
            // 
            // pn_main
            // 
            this.pn_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_main.AutoScroll = true;
            this.pn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pn_main.Location = new System.Drawing.Point(21, 87);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(760, 291);
            this.pn_main.TabIndex = 104;
            // 
            // bt_buscar
            // 
            this.bt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.bt_buscar.ButtonColor = System.Drawing.Color.Black;
            this.bt_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bt_buscar.Location = new System.Drawing.Point(689, 41);
            this.bt_buscar.Name = "bt_buscar";
            this.bt_buscar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.bt_buscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.bt_buscar.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_buscar.Size = new System.Drawing.Size(30, 30);
            this.bt_buscar.TabIndex = 103;
            this.bt_buscar.Text = "→";
            this.bt_buscar.TextColor = System.Drawing.Color.White;
            this.bt_buscar.UseVisualStyleBackColor = true;
            this.bt_buscar.Click += new System.EventHandler(this.bt_buscar_Click);
            // 
            // bt_voltar
            // 
            this.bt_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_voltar.BorderColor = System.Drawing.Color.Transparent;
            this.bt_voltar.ButtonColor = System.Drawing.Color.Black;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bt_voltar.Location = new System.Drawing.Point(755, 41);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.bt_voltar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bt_voltar.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_voltar.Size = new System.Drawing.Size(30, 30);
            this.bt_voltar.TabIndex = 102;
            this.bt_voltar.Text = "⤶";
            this.bt_voltar.TextColor = System.Drawing.Color.White;
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_criar_editar
            // 
            this.bt_criar_editar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_criar_editar.BackColor = System.Drawing.Color.Black;
            this.bt_criar_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_criar_editar.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_criar_editar.ForeColor = System.Drawing.Color.White;
            this.bt_criar_editar.Location = new System.Drawing.Point(21, 385);
            this.bt_criar_editar.Name = "bt_criar_editar";
            this.bt_criar_editar.Size = new System.Drawing.Size(375, 56);
            this.bt_criar_editar.TabIndex = 105;
            this.bt_criar_editar.Text = "Criar / Editar";
            this.bt_criar_editar.UseVisualStyleBackColor = false;
            this.bt_criar_editar.Click += new System.EventHandler(this.bt_criar_editar_Click);
            this.bt_criar_editar.MouseEnter += new System.EventHandler(this.bt_criar_editar_MouseEnter);
            this.bt_criar_editar.MouseLeave += new System.EventHandler(this.bt_criar_editar_MouseLeave);
            // 
            // bt_deletar
            // 
            this.bt_deletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deletar.BackColor = System.Drawing.Color.Black;
            this.bt_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deletar.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_deletar.ForeColor = System.Drawing.Color.White;
            this.bt_deletar.Location = new System.Drawing.Point(406, 385);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(375, 56);
            this.bt_deletar.TabIndex = 105;
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.UseVisualStyleBackColor = false;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            this.bt_deletar.MouseEnter += new System.EventHandler(this.bt_deletar_MouseEnter);
            this.bt_deletar.MouseLeave += new System.EventHandler(this.bt_deletar_MouseLeave);
            // 
            // tb_barraDePesquisa
            // 
            this.tb_barraDePesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_barraDePesquisa.BackColor = System.Drawing.Color.Black;
            this.tb_barraDePesquisa.BorderColor = System.Drawing.Color.White;
            this.tb_barraDePesquisa.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_barraDePesquisa.ForeColor = System.Drawing.Color.White;
            this.tb_barraDePesquisa.Location = new System.Drawing.Point(21, 41);
            this.tb_barraDePesquisa.Name = "tb_barraDePesquisa";
            this.tb_barraDePesquisa.Size = new System.Drawing.Size(662, 26);
            this.tb_barraDePesquisa.TabIndex = 0;
            // 
            // FormVerHabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.bt_deletar);
            this.Controls.Add(this.bt_criar_editar);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.bt_buscar);
            this.Controls.Add(this.bt_voltar);
            this.Controls.Add(bt_buscarTodas);
            this.Controls.Add(this.tb_barraDePesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerHabilidades";
            this.Text = "FormVerHabilidades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox tb_barraDePesquisa;
        private ePOSOne.btnProduct.Button_WOC bt_voltar;
        private ePOSOne.btnProduct.Button_WOC bt_buscar;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Button bt_criar_editar;
        private System.Windows.Forms.Button bt_deletar;
    }
}