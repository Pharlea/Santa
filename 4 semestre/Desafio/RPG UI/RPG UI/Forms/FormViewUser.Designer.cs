namespace RPG_UI.Forms
{
    partial class FormViewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewUser));
            this.pb_fotoPerfil = new System.Windows.Forms.PictureBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_role = new System.Windows.Forms.Label();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.bt_deletar = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_fotoPerfil
            // 
            this.pb_fotoPerfil.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_fotoPerfil.Image = ((System.Drawing.Image)(resources.GetObject("pb_fotoPerfil.Image")));
            this.pb_fotoPerfil.Location = new System.Drawing.Point(0, 0);
            this.pb_fotoPerfil.Name = "pb_fotoPerfil";
            this.pb_fotoPerfil.Size = new System.Drawing.Size(88, 100);
            this.pb_fotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_fotoPerfil.TabIndex = 0;
            this.pb_fotoPerfil.TabStop = false;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Courier New", 12F);
            this.lb_id.ForeColor = System.Drawing.Color.White;
            this.lb_id.Location = new System.Drawing.Point(94, 9);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(28, 18);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "ID";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.Black;
            this.tb_id.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_id.ForeColor = System.Drawing.Color.White;
            this.tb_id.Location = new System.Drawing.Point(97, 30);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(25, 26);
            this.tb_id.TabIndex = 2;
            // 
            // lb_nome
            // 
            this.lb_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Courier New", 12F);
            this.lb_nome.ForeColor = System.Drawing.Color.White;
            this.lb_nome.Location = new System.Drawing.Point(128, 9);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(48, 18);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome";
            // 
            // tb_nome
            // 
            this.tb_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nome.BackColor = System.Drawing.Color.Black;
            this.tb_nome.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_nome.ForeColor = System.Drawing.Color.White;
            this.tb_nome.Location = new System.Drawing.Point(131, 30);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.ReadOnly = true;
            this.tb_nome.Size = new System.Drawing.Size(250, 26);
            this.tb_nome.TabIndex = 2;
            // 
            // lb_email
            // 
            this.lb_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Courier New", 12F);
            this.lb_email.ForeColor = System.Drawing.Color.White;
            this.lb_email.Location = new System.Drawing.Point(384, 9);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(58, 18);
            this.lb_email.TabIndex = 1;
            this.lb_email.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_email.BackColor = System.Drawing.Color.Black;
            this.tb_email.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_email.ForeColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(387, 30);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(250, 26);
            this.tb_email.TabIndex = 2;
            // 
            // lb_role
            // 
            this.lb_role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Courier New", 12F);
            this.lb_role.ForeColor = System.Drawing.Color.White;
            this.lb_role.Location = new System.Drawing.Point(640, 9);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(48, 18);
            this.lb_role.TabIndex = 1;
            this.lb_role.Text = "Role";
            // 
            // tb_role
            // 
            this.tb_role.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_role.BackColor = System.Drawing.Color.Black;
            this.tb_role.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_role.ForeColor = System.Drawing.Color.White;
            this.tb_role.Location = new System.Drawing.Point(643, 30);
            this.tb_role.Name = "tb_role";
            this.tb_role.ReadOnly = true;
            this.tb_role.Size = new System.Drawing.Size(114, 26);
            this.tb_role.TabIndex = 2;
            // 
            // bt_deletar
            // 
            this.bt_deletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_deletar.BorderColor = System.Drawing.Color.Transparent;
            this.bt_deletar.ButtonColor = System.Drawing.Color.Firebrick;
            this.bt_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deletar.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_deletar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.bt_deletar.Location = new System.Drawing.Point(663, 65);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.bt_deletar.OnHoverButtonColor = System.Drawing.Color.Red;
            this.bt_deletar.OnHoverTextColor = System.Drawing.Color.Black;
            this.bt_deletar.Size = new System.Drawing.Size(94, 30);
            this.bt_deletar.TabIndex = 3;
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.TextColor = System.Drawing.Color.Black;
            this.bt_deletar.UseVisualStyleBackColor = true;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // FormViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(769, 100);
            this.Controls.Add(this.bt_deletar);
            this.Controls.Add(this.tb_role);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.pb_fotoPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewUser";
            this.Text = "FormViewUser";
            this.Load += new System.EventHandler(this.FormViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_fotoPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_fotoPerfil;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.TextBox tb_role;
        private ePOSOne.btnProduct.Button_WOC bt_deletar;
    }
}