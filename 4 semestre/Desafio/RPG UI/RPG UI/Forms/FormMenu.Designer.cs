namespace RPG_UI
{
    partial class FormMenu
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
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pn_principal = new System.Windows.Forms.Panel();
            this.bt_habilidades = new ePOSOne.btnProduct.Button_WOC();
            this.pn_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Courier New", 50F);
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(88, 13);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(190, 71);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Menu";
            // 
            // pn_principal
            // 
            this.pn_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pn_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pn_principal.Controls.Add(this.bt_habilidades);
            this.pn_principal.Controls.Add(this.lb_titulo);
            this.pn_principal.Location = new System.Drawing.Point(221, 25);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(350, 394);
            this.pn_principal.TabIndex = 1;
            // 
            // bt_habilidades
            // 
            this.bt_habilidades.BorderColor = System.Drawing.Color.White;
            this.bt_habilidades.ButtonColor = System.Drawing.Color.Black;
            this.bt_habilidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_habilidades.Font = new System.Drawing.Font("Courier New", 16F);
            this.bt_habilidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bt_habilidades.Location = new System.Drawing.Point(72, 167);
            this.bt_habilidades.Name = "bt_habilidades";
            this.bt_habilidades.OnHoverBorderColor = System.Drawing.Color.White;
            this.bt_habilidades.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bt_habilidades.OnHoverTextColor = System.Drawing.Color.White;
            this.bt_habilidades.Size = new System.Drawing.Size(206, 62);
            this.bt_habilidades.TabIndex = 1;
            this.bt_habilidades.Text = "Habilidades";
            this.bt_habilidades.TextColor = System.Drawing.Color.White;
            this.bt_habilidades.UseVisualStyleBackColor = true;
            this.bt_habilidades.Click += new System.EventHandler(this.bt_habilidades_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.ControlBox = false;
            this.Controls.Add(this.pn_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.pn_principal.ResumeLayout(false);
            this.pn_principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Panel pn_principal;
        private ePOSOne.btnProduct.Button_WOC bt_habilidades;
    }
}