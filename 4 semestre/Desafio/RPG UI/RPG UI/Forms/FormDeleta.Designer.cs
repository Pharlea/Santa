namespace RPG_UI
{
    partial class FormDeleta
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
            this.bt_voltar = new System.Windows.Forms.Button();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pn_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pn_main.Controls.Add(this.bt_voltar);
            this.pn_main.Controls.Add(this.bt_deletar);
            this.pn_main.Controls.Add(this.tb_id);
            this.pn_main.Controls.Add(this.lb_id);
            this.pn_main.Controls.Add(this.lb_titulo);
            this.pn_main.Location = new System.Drawing.Point(207, 122);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(378, 208);
            this.pn_main.TabIndex = 0;
            // 
            // bt_voltar
            // 
            this.bt_voltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_voltar.BackColor = System.Drawing.Color.Black;
            this.bt_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_voltar.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_voltar.ForeColor = System.Drawing.Color.White;
            this.bt_voltar.Location = new System.Drawing.Point(192, 151);
            this.bt_voltar.Name = "bt_voltar";
            this.bt_voltar.Size = new System.Drawing.Size(155, 26);
            this.bt_voltar.TabIndex = 2;
            this.bt_voltar.Text = "Voltar";
            this.bt_voltar.UseVisualStyleBackColor = false;
            this.bt_voltar.Click += new System.EventHandler(this.bt_voltar_Click);
            this.bt_voltar.MouseEnter += new System.EventHandler(this.bt_voltar_MouseEnter);
            this.bt_voltar.MouseLeave += new System.EventHandler(this.bt_voltar_MouseLeave);
            // 
            // bt_deletar
            // 
            this.bt_deletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bt_deletar.BackColor = System.Drawing.Color.Black;
            this.bt_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_deletar.Font = new System.Drawing.Font("Courier New", 12F);
            this.bt_deletar.ForeColor = System.Drawing.Color.White;
            this.bt_deletar.Location = new System.Drawing.Point(33, 151);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(155, 26);
            this.bt_deletar.TabIndex = 2;
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.UseVisualStyleBackColor = false;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            this.bt_deletar.MouseEnter += new System.EventHandler(this.bt_deletar_MouseEnter);
            this.bt_deletar.MouseLeave += new System.EventHandler(this.bt_deletar_MouseLeave);
            // 
            // tb_id
            // 
            this.tb_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_id.BackColor = System.Drawing.Color.Black;
            this.tb_id.Font = new System.Drawing.Font("Courier New", 12F);
            this.tb_id.ForeColor = System.Drawing.Color.White;
            this.tb_id.Location = new System.Drawing.Point(74, 83);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(273, 26);
            this.tb_id.TabIndex = 1;
            // 
            // lb_id
            // 
            this.lb_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Courier New", 12F);
            this.lb_id.ForeColor = System.Drawing.Color.White;
            this.lb_id.Location = new System.Drawing.Point(30, 86);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(38, 18);
            this.lb_id.TabIndex = 0;
            this.lb_id.Text = "Id:";
            // 
            // lb_titulo
            // 
            this.lb_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Courier New", 32F);
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(96, 22);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(202, 46);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Deletar";
            // 
            // FormDeleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.pn_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDeleta";
            this.Text = "8";
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Button bt_voltar;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.TextBox tb_id;
    }
}