namespace RPG_UI
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.pn_controlBar = new System.Windows.Forms.Panel();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.bt_verUsuarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sairConta = new System.Windows.Forms.Button();
            this.lb_userName = new System.Windows.Forms.Label();
            this.pb_perfil = new System.Windows.Forms.PictureBox();
            this.pn_Main = new System.Windows.Forms.Panel();
            this.bt_minimize = new ePOSOne.btnProduct.Button_WOC();
            this.bt_fechar = new ePOSOne.btnProduct.Button_WOC();
            this.pn_controlBar.SuspendLayout();
            this.pn_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_controlBar
            // 
            this.pn_controlBar.BackColor = System.Drawing.Color.Black;
            this.pn_controlBar.Controls.Add(this.bt_minimize);
            this.pn_controlBar.Controls.Add(this.lb_titulo);
            this.pn_controlBar.Controls.Add(this.bt_fechar);
            this.pn_controlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_controlBar.Location = new System.Drawing.Point(0, 0);
            this.pn_controlBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_controlBar.Name = "pn_controlBar";
            this.pn_controlBar.Size = new System.Drawing.Size(933, 32);
            this.pn_controlBar.TabIndex = 0;
            this.pn_controlBar.DoubleClick += new System.EventHandler(this.bt_windowState_Click);
            this.pn_controlBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_controlBar_MouseDown);
            this.pn_controlBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_controlBar_MouseMove);
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Courier New", 13F);
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(12, 6);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(53, 20);
            this.lb_titulo.TabIndex = 2;
            this.lb_titulo.Text = "Home";
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.pn_menu.Controls.Add(this.bt_verUsuarios);
            this.pn_menu.Controls.Add(this.label1);
            this.pn_menu.Controls.Add(this.bt_sairConta);
            this.pn_menu.Controls.Add(this.lb_userName);
            this.pn_menu.Controls.Add(this.pb_perfil);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 32);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(140, 453);
            this.pn_menu.TabIndex = 1;
            // 
            // bt_verUsuarios
            // 
            this.bt_verUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_verUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_verUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_verUsuarios.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_verUsuarios.ForeColor = System.Drawing.Color.White;
            this.bt_verUsuarios.Location = new System.Drawing.Point(0, 353);
            this.bt_verUsuarios.Name = "bt_verUsuarios";
            this.bt_verUsuarios.Size = new System.Drawing.Size(140, 50);
            this.bt_verUsuarios.TabIndex = 0;
            this.bt_verUsuarios.Text = "Ver usuários";
            this.bt_verUsuarios.UseVisualStyleBackColor = true;
            this.bt_verUsuarios.Click += new System.EventHandler(this.bt_verUsuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.MaximumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // bt_sairConta
            // 
            this.bt_sairConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_sairConta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_sairConta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_sairConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sairConta.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_sairConta.ForeColor = System.Drawing.Color.White;
            this.bt_sairConta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sairConta.Location = new System.Drawing.Point(0, 403);
            this.bt_sairConta.Name = "bt_sairConta";
            this.bt_sairConta.Size = new System.Drawing.Size(140, 50);
            this.bt_sairConta.TabIndex = 0;
            this.bt_sairConta.Text = "Sair";
            this.bt_sairConta.UseVisualStyleBackColor = true;
            this.bt_sairConta.Click += new System.EventHandler(this.bt_sairConta_Click);
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Courier New", 11F);
            this.lb_userName.ForeColor = System.Drawing.Color.White;
            this.lb_userName.Location = new System.Drawing.Point(17, 123);
            this.lb_userName.MaximumSize = new System.Drawing.Size(100, 0);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(0, 17);
            this.lb_userName.TabIndex = 1;
            // 
            // pb_perfil
            // 
            this.pb_perfil.Image = ((System.Drawing.Image)(resources.GetObject("pb_perfil.Image")));
            this.pb_perfil.Location = new System.Drawing.Point(20, 20);
            this.pb_perfil.Name = "pb_perfil";
            this.pb_perfil.Size = new System.Drawing.Size(100, 100);
            this.pb_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_perfil.TabIndex = 0;
            this.pb_perfil.TabStop = false;
            // 
            // pn_Main
            // 
            this.pn_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(140, 32);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(793, 453);
            this.pn_Main.TabIndex = 2;
            this.pn_Main.Tag = "-1";
            // 
            // bt_minimize
            // 
            this.bt_minimize.BorderColor = System.Drawing.Color.Transparent;
            this.bt_minimize.ButtonColor = System.Drawing.Color.Khaki;
            this.bt_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_minimize.ForeColor = System.Drawing.Color.Black;
            this.bt_minimize.Location = new System.Drawing.Point(869, 0);
            this.bt_minimize.Name = "bt_minimize";
            this.bt_minimize.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.bt_minimize.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.bt_minimize.OnHoverTextColor = System.Drawing.Color.Black;
            this.bt_minimize.Size = new System.Drawing.Size(32, 32);
            this.bt_minimize.TabIndex = 100;
            this.bt_minimize.Text = "-";
            this.bt_minimize.TextColor = System.Drawing.Color.Black;
            this.bt_minimize.UseVisualStyleBackColor = true;
            this.bt_minimize.Click += new System.EventHandler(this.bt_minimize_Click);
            // 
            // bt_fechar
            // 
            this.bt_fechar.BorderColor = System.Drawing.Color.Transparent;
            this.bt_fechar.ButtonColor = System.Drawing.Color.Brown;
            this.bt_fechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_fechar.ForeColor = System.Drawing.Color.Black;
            this.bt_fechar.Location = new System.Drawing.Point(901, 0);
            this.bt_fechar.Name = "bt_fechar";
            this.bt_fechar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.bt_fechar.OnHoverButtonColor = System.Drawing.Color.Red;
            this.bt_fechar.OnHoverTextColor = System.Drawing.Color.Black;
            this.bt_fechar.Size = new System.Drawing.Size(32, 32);
            this.bt_fechar.TabIndex = 100;
            this.bt_fechar.Text = "X";
            this.bt_fechar.TextColor = System.Drawing.Color.Black;
            this.bt_fechar.UseVisualStyleBackColor = true;
            this.bt_fechar.Click += new System.EventHandler(this.bt_fechar_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(933, 485);
            this.ControlBox = false;
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.pn_menu);
            this.Controls.Add(this.pn_controlBar);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.TextChanged += new System.EventHandler(this.FormHome_TextChanged);
            this.pn_controlBar.ResumeLayout(false);
            this.pn_controlBar.PerformLayout();
            this.pn_menu.ResumeLayout(false);
            this.pn_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_controlBar;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Panel pn_Main;
        private ePOSOne.btnProduct.Button_WOC bt_minimize;
        private ePOSOne.btnProduct.Button_WOC bt_fechar;
        private System.Windows.Forms.PictureBox pb_perfil;
        private System.Windows.Forms.Button bt_sairConta;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_verUsuarios;
    }
}

