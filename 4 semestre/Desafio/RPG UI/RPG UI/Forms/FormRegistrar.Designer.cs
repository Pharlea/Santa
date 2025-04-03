namespace RPG_UI
{
    partial class FormRegistrar
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
            this.pn_main = new System.Windows.Forms.Panel();
            this.lb_nomeDeUsuario = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.tb_nomeDeUsuario = new RPG_UI.MyTextBox();
            this.tb_senha = new RPG_UI.MyTextBox();
            this.tb_email = new RPG_UI.MyTextBox();
            this.bt_voltar = new ePOSOne.btnProduct.Button_WOC();
            this.bt_registrar = new ePOSOne.btnProduct.Button_WOC();
            this.lb_resultado = new System.Windows.Forms.Label();
            this.pn_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pn_main.Controls.Add(this.lb_resultado);
            this.pn_main.Controls.Add(this.lb_nomeDeUsuario);
            this.pn_main.Controls.Add(this.tb_nomeDeUsuario);
            this.pn_main.Controls.Add(this.lb_senha);
            this.pn_main.Controls.Add(this.tb_senha);
            this.pn_main.Controls.Add(this.lb_email);
            this.pn_main.Controls.Add(this.tb_email);
            this.pn_main.Controls.Add(this.bt_voltar);
            this.pn_main.Controls.Add(this.bt_registrar);
            this.pn_main.Controls.Add(this.lb_titulo);
            this.pn_main.Location = new System.Drawing.Point(198, 23);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(396, 407);
            this.pn_main.TabIndex = 0;
            // 
            // lb_nomeDeUsuario
            // 
            this.lb_nomeDeUsuario.AutoSize = true;
            this.lb_nomeDeUsuario.Font = new System.Drawing.Font("Courier New", 11F);
            this.lb_nomeDeUsuario.ForeColor = System.Drawing.Color.White;
            this.lb_nomeDeUsuario.Location = new System.Drawing.Point(14, 76);
            this.lb_nomeDeUsuario.Name = "lb_nomeDeUsuario";
            this.lb_nomeDeUsuario.Size = new System.Drawing.Size(143, 17);
            this.lb_nomeDeUsuario.TabIndex = 108;
            this.lb_nomeDeUsuario.Text = "Nome de usuário";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Courier New", 11F);
            this.lb_senha.ForeColor = System.Drawing.Color.White;
            this.lb_senha.Location = new System.Drawing.Point(14, 170);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(53, 17);
            this.lb_senha.TabIndex = 110;
            this.lb_senha.Text = "Senha";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Courier New", 11F);
            this.lb_email.ForeColor = System.Drawing.Color.White;
            this.lb_email.Location = new System.Drawing.Point(14, 123);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(53, 17);
            this.lb_email.TabIndex = 108;
            this.lb_email.Text = "Email";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Courier New", 24F);
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(114, 21);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(167, 36);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Registar";
            // 
            // tb_nomeDeUsuario
            // 
            this.tb_nomeDeUsuario.BackColor = System.Drawing.Color.Black;
            this.tb_nomeDeUsuario.BorderColor = System.Drawing.Color.White;
            this.tb_nomeDeUsuario.Font = new System.Drawing.Font("Courier New", 11F);
            this.tb_nomeDeUsuario.ForeColor = System.Drawing.Color.White;
            this.tb_nomeDeUsuario.Location = new System.Drawing.Point(17, 96);
            this.tb_nomeDeUsuario.Name = "tb_nomeDeUsuario";
            this.tb_nomeDeUsuario.Size = new System.Drawing.Size(366, 24);
            this.tb_nomeDeUsuario.TabIndex = 107;
            // 
            // tb_senha
            // 
            this.tb_senha.BackColor = System.Drawing.Color.Black;
            this.tb_senha.BorderColor = System.Drawing.Color.White;
            this.tb_senha.Font = new System.Drawing.Font("Courier New", 11F);
            this.tb_senha.ForeColor = System.Drawing.Color.White;
            this.tb_senha.Location = new System.Drawing.Point(17, 190);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(366, 24);
            this.tb_senha.TabIndex = 109;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Black;
            this.tb_email.BorderColor = System.Drawing.Color.White;
            this.tb_email.Font = new System.Drawing.Font("Courier New", 11F);
            this.tb_email.ForeColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(17, 143);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(366, 24);
            this.tb_email.TabIndex = 107;
            // 
            // bt_voltar
            // 
            this.bt_voltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_voltar.BorderColor = System.Drawing.Color.White;
            this.bt_voltar.ButtonColor = System.Drawing.Color.Black;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_voltar.Location = new System.Drawing.Point(223, 350);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.OnHoverBorderColor = System.Drawing.Color.White;
            this.bt_voltar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bt_voltar.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_voltar.Size = new System.Drawing.Size(160, 40);
            this.bt_voltar.TabIndex = 1;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.TextColor = System.Drawing.Color.White;
            this.bt_voltar.UseVisualStyleBackColor = true;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            // 
            // bt_registrar
            // 
            this.bt_registrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_registrar.BorderColor = System.Drawing.Color.White;
            this.bt_registrar.ButtonColor = System.Drawing.Color.Black;
            this.bt_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_registrar.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_registrar.Location = new System.Drawing.Point(17, 350);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.OnHoverBorderColor = System.Drawing.Color.White;
            this.bt_registrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bt_registrar.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_registrar.Size = new System.Drawing.Size(160, 40);
            this.bt_registrar.TabIndex = 1;
            this.bt_registrar.Text = "Registrar";
            this.bt_registrar.TextColor = System.Drawing.Color.White;
            this.bt_registrar.UseVisualStyleBackColor = true;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            // 
            // lb_resultado
            // 
            this.lb_resultado.AutoSize = true;
            this.lb_resultado.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.lb_resultado.ForeColor = System.Drawing.Color.Gray;
            this.lb_resultado.Location = new System.Drawing.Point(17, 221);
            this.lb_resultado.Name = "lb_resultado";
            this.lb_resultado.Size = new System.Drawing.Size(0, 14);
            this.lb_resultado.TabIndex = 111;
            // 
            // FormRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.pn_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrar";
            this.Text = "FormRegistrar";
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Label lb_titulo;
        private ePOSOne.btnProduct.Button_WOC bt_registrar;
        private System.Windows.Forms.Label lb_nomeDeUsuario;
        private MyTextBox tb_nomeDeUsuario;
        private System.Windows.Forms.Label lb_senha;
        private MyTextBox tb_senha;
        private System.Windows.Forms.Label lb_email;
        private MyTextBox tb_email;
        private ePOSOne.btnProduct.Button_WOC bt_voltar;
        private System.Windows.Forms.Label lb_resultado;
    }
}