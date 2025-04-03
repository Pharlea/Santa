namespace Bim2Ex1
{
    partial class Form1
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
            this.lb_CNPJ = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_data = new System.Windows.Forms.Label();
            this.lb_toneladas = new System.Windows.Forms.Label();
            this.lb_valor = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.tb_somaTon = new System.Windows.Forms.TextBox();
            this.tb_somaVal = new System.Windows.Forms.TextBox();
            this.tb_CNPJ = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lb_CNPJ
            // 
            this.lb_CNPJ.AutoSize = true;
            this.lb_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_CNPJ.Location = new System.Drawing.Point(12, 44);
            this.lb_CNPJ.Name = "lb_CNPJ";
            this.lb_CNPJ.Size = new System.Drawing.Size(119, 18);
            this.lb_CNPJ.TabIndex = 0;
            this.lb_CNPJ.Text = "CNPJ do cliente:";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(12, 88);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(120, 18);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome do cliente:";
            // 
            // lb_data
            // 
            this.lb_data.AutoSize = true;
            this.lb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_data.Location = new System.Drawing.Point(29, 140);
            this.lb_data.Name = "lb_data";
            this.lb_data.Size = new System.Drawing.Size(114, 18);
            this.lb_data.TabIndex = 2;
            this.lb_data.Text = "Data de compra";
            // 
            // lb_toneladas
            // 
            this.lb_toneladas.AutoSize = true;
            this.lb_toneladas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_toneladas.Location = new System.Drawing.Point(173, 140);
            this.lb_toneladas.Name = "lb_toneladas";
            this.lb_toneladas.Size = new System.Drawing.Size(77, 18);
            this.lb_toneladas.TabIndex = 3;
            this.lb_toneladas.Text = "Toneladas";
            // 
            // lb_valor
            // 
            this.lb_valor.AutoSize = true;
            this.lb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor.Location = new System.Drawing.Point(287, 140);
            this.lb_valor.Name = "lb_valor";
            this.lb_valor.Size = new System.Drawing.Size(117, 18);
            this.lb_valor.TabIndex = 4;
            this.lb_valor.Text = "Valor de compra";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(137, 88);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(282, 20);
            this.tb_nome.TabIndex = 5;
            // 
            // bt_consultar
            // 
            this.bt_consultar.Location = new System.Drawing.Point(176, 44);
            this.bt_consultar.Name = "bt_consultar";
            this.bt_consultar.Size = new System.Drawing.Size(75, 23);
            this.bt_consultar.TabIndex = 10;
            this.bt_consultar.Text = "Consultar";
            this.bt_consultar.UseVisualStyleBackColor = true;
            this.bt_consultar.Click += new System.EventHandler(this.bt_consultar_Click);
            // 
            // tb_somaTon
            // 
            this.tb_somaTon.Location = new System.Drawing.Point(158, 272);
            this.tb_somaTon.Name = "tb_somaTon";
            this.tb_somaTon.Size = new System.Drawing.Size(120, 20);
            this.tb_somaTon.TabIndex = 12;
            // 
            // tb_somaVal
            // 
            this.tb_somaVal.Location = new System.Drawing.Point(284, 272);
            this.tb_somaVal.Name = "tb_somaVal";
            this.tb_somaVal.Size = new System.Drawing.Size(120, 20);
            this.tb_somaVal.TabIndex = 13;
            // 
            // tb_CNPJ
            // 
            this.tb_CNPJ.Location = new System.Drawing.Point(137, 44);
            this.tb_CNPJ.Name = "tb_CNPJ";
            this.tb_CNPJ.Size = new System.Drawing.Size(33, 20);
            this.tb_CNPJ.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(32, 171);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 15;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(158, 171);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 16;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(284, 171);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 95);
            this.listBox3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 347);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tb_CNPJ);
            this.Controls.Add(this.tb_somaVal);
            this.Controls.Add(this.tb_somaTon);
            this.Controls.Add(this.bt_consultar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_valor);
            this.Controls.Add(this.lb_toneladas);
            this.Controls.Add(this.lb_data);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_CNPJ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CNPJ;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_data;
        private System.Windows.Forms.Label lb_toneladas;
        private System.Windows.Forms.Label lb_valor;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.TextBox tb_somaTon;
        private System.Windows.Forms.TextBox tb_somaVal;
        private System.Windows.Forms.TextBox tb_CNPJ;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
    }
}

