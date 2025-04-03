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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lb_CNPJ = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_grafico = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.bt_consultar = new System.Windows.Forms.Button();
            this.tb_soma = new System.Windows.Forms.TextBox();
            this.tb_CNPJ = new System.Windows.Forms.TextBox();
            this.rb_toneladas = new System.Windows.Forms.RadioButton();
            this.rb_valor = new System.Windows.Forms.RadioButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // lb_grafico
            // 
            this.lb_grafico.AutoSize = true;
            this.lb_grafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_grafico.Location = new System.Drawing.Point(23, 115);
            this.lb_grafico.Name = "lb_grafico";
            this.lb_grafico.Size = new System.Drawing.Size(65, 18);
            this.lb_grafico.TabIndex = 2;
            this.lb_grafico.Text = "Gráfico: ";
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
            // tb_soma
            // 
            this.tb_soma.Location = new System.Drawing.Point(299, 300);
            this.tb_soma.Name = "tb_soma";
            this.tb_soma.Size = new System.Drawing.Size(120, 20);
            this.tb_soma.TabIndex = 13;
            // 
            // tb_CNPJ
            // 
            this.tb_CNPJ.Location = new System.Drawing.Point(137, 44);
            this.tb_CNPJ.Name = "tb_CNPJ";
            this.tb_CNPJ.Size = new System.Drawing.Size(33, 20);
            this.tb_CNPJ.TabIndex = 14;
            // 
            // rb_toneladas
            // 
            this.rb_toneladas.AutoSize = true;
            this.rb_toneladas.Location = new System.Drawing.Point(94, 117);
            this.rb_toneladas.Name = "rb_toneladas";
            this.rb_toneladas.Size = new System.Drawing.Size(75, 17);
            this.rb_toneladas.TabIndex = 15;
            this.rb_toneladas.TabStop = true;
            this.rb_toneladas.Text = "Toneladas";
            this.rb_toneladas.UseVisualStyleBackColor = true;
            // 
            // rb_valor
            // 
            this.rb_valor.AutoSize = true;
            this.rb_valor.Location = new System.Drawing.Point(185, 117);
            this.rb_valor.Name = "rb_valor";
            this.rb_valor.Size = new System.Drawing.Size(49, 17);
            this.rb_valor.TabIndex = 16;
            this.rb_valor.TabStop = true;
            this.rb_valor.Text = "Valor";
            this.rb_valor.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 140);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(404, 154);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 328);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.rb_valor);
            this.Controls.Add(this.rb_toneladas);
            this.Controls.Add(this.tb_CNPJ);
            this.Controls.Add(this.tb_soma);
            this.Controls.Add(this.bt_consultar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_grafico);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.lb_CNPJ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CNPJ;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_grafico;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button bt_consultar;
        private System.Windows.Forms.TextBox tb_soma;
        private System.Windows.Forms.TextBox tb_CNPJ;
        private System.Windows.Forms.RadioButton rb_toneladas;
        private System.Windows.Forms.RadioButton rb_valor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

