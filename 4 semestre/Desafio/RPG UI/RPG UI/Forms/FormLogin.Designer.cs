namespace RPG_UI
{
    partial class FormLogin
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
            this.pn_login = new System.Windows.Forms.Panel();
            this.llb_registrar = new System.Windows.Forms.LinkLabel();
            this.lb_incorreto = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_senha = new RPG_UI.MyTextBox();
            this.tb_email = new RPG_UI.MyTextBox();
            this.bt_enviar = new ePOSOne.btnProduct.Button_WOC();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pn_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_login
            // 
            this.pn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pn_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_login.Controls.Add(this.llb_registrar);
            this.pn_login.Controls.Add(this.lb_incorreto);
            this.pn_login.Controls.Add(this.lb_senha);
            this.pn_login.Controls.Add(this.lb_email);
            this.pn_login.Controls.Add(this.tb_senha);
            this.pn_login.Controls.Add(this.tb_email);
            this.pn_login.Controls.Add(this.bt_enviar);
            this.pn_login.Controls.Add(this.lb_titulo);
            this.pn_login.Location = new System.Drawing.Point(198, 23);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(396, 407);
            this.pn_login.TabIndex = 1;
            // 
            // llb_registrar
            // 
            this.llb_registrar.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.llb_registrar.AutoSize = true;
            this.llb_registrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.llb_registrar.Location = new System.Drawing.Point(12, 227);
            this.llb_registrar.Name = "llb_registrar";
            this.llb_registrar.Size = new System.Drawing.Size(119, 13);
            this.llb_registrar.TabIndex = 109;
            this.llb_registrar.TabStop = true;
            this.llb_registrar.Text = "Não possui uma conta?";
            this.llb_registrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_registrar_LinkClicked);
            // 
            // lb_incorreto
            // 
            this.lb_incorreto.AutoSize = true;
            this.lb_incorreto.Font = new System.Drawing.Font("Courier New", 8F);
            this.lb_incorreto.ForeColor = System.Drawing.Color.Gray;
            this.lb_incorreto.Location = new System.Drawing.Point(71, 182);
            this.lb_incorreto.Name = "lb_incorreto";
            this.lb_incorreto.Size = new System.Drawing.Size(0, 14);
            this.lb_incorreto.TabIndex = 108;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Courier New", 11F);
            this.lb_senha.ForeColor = System.Drawing.Color.White;
            this.lb_senha.Location = new System.Drawing.Point(12, 180);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(53, 17);
            this.lb_senha.TabIndex = 107;
            this.lb_senha.Text = "Senha";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Courier New", 11F);
            this.lb_email.ForeColor = System.Drawing.Color.White;
            this.lb_email.Location = new System.Drawing.Point(12, 74);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(53, 17);
            this.lb_email.TabIndex = 106;
            this.lb_email.Text = "Email";
            // 
            // tb_senha
            // 
            this.tb_senha.BackColor = System.Drawing.Color.Black;
            this.tb_senha.BorderColor = System.Drawing.Color.White;
            this.tb_senha.Font = new System.Drawing.Font("Courier New", 11F);
            this.tb_senha.ForeColor = System.Drawing.Color.White;
            this.tb_senha.Location = new System.Drawing.Point(15, 200);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.Size = new System.Drawing.Size(366, 24);
            this.tb_senha.TabIndex = 105;
            this.tb_senha.UseSystemPasswordChar = true;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.Black;
            this.tb_email.BorderColor = System.Drawing.Color.White;
            this.tb_email.Font = new System.Drawing.Font("Courier New", 11F);
            this.tb_email.ForeColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(15, 94);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(366, 24);
            this.tb_email.TabIndex = 104;
            // 
            // bt_enviar
            // 
            this.bt_enviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_enviar.BorderColor = System.Drawing.Color.White;
            this.bt_enviar.ButtonColor = System.Drawing.Color.Black;
            this.bt_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_enviar.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.bt_enviar.Location = new System.Drawing.Point(118, 350);
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.OnHoverBorderColor = System.Drawing.Color.White;
            this.bt_enviar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bt_enviar.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_enviar.Size = new System.Drawing.Size(160, 40);
            this.bt_enviar.TabIndex = 103;
            this.bt_enviar.Text = "Enviar";
            this.bt_enviar.TextColor = System.Drawing.Color.White;
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.bt_enviar_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_titulo.Font = new System.Drawing.Font("Courier New", 32F);
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(118, 17);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(150, 46);
            this.lb_titulo.TabIndex = 102;
            this.lb_titulo.Text = "Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.pn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_login;
        private System.Windows.Forms.Label lb_titulo;
        private ePOSOne.btnProduct.Button_WOC bt_enviar;
        private MyTextBox tb_senha;
        private MyTextBox tb_email;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_incorreto;
        private System.Windows.Forms.LinkLabel llb_registrar;
    }
}