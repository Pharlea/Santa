namespace ConversãoDistancia
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ValorConvertido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.KmOuMilha = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_valor_raio = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_valor_convertido_radio = new System.Windows.Forms.Label();
            this.bt_calc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(288, 187);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.ValorConvertido);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.KmOuMilha);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(280, 161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Combobox";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // ValorConvertido
            // 
            this.ValorConvertido.AutoSize = true;
            this.ValorConvertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorConvertido.Location = new System.Drawing.Point(28, 126);
            this.ValorConvertido.Name = "ValorConvertido";
            this.ValorConvertido.Size = new System.Drawing.Size(185, 18);
            this.ValorConvertido.TabIndex = 3;
            this.ValorConvertido.Text = "valor convertido:                 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um Valor: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KmOuMilha
            // 
            this.KmOuMilha.DisplayMember = "1";
            this.KmOuMilha.FormattingEnabled = true;
            this.KmOuMilha.Items.AddRange(new object[] {
            "quilometro pra milha",
            "Milha para quilometro "});
            this.KmOuMilha.Location = new System.Drawing.Point(31, 70);
            this.KmOuMilha.Name = "KmOuMilha";
            this.KmOuMilha.Size = new System.Drawing.Size(118, 21);
            this.KmOuMilha.TabIndex = 0;
            this.KmOuMilha.Text = "Kilômetro para milha";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_calc);
            this.tabPage2.Controls.Add(this.lb_valor_convertido_radio);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lb_valor_raio);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RadioButton";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_valor_raio
            // 
            this.lb_valor_raio.AutoSize = true;
            this.lb_valor_raio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor_raio.Location = new System.Drawing.Point(17, 14);
            this.lb_valor_raio.Name = "lb_valor_raio";
            this.lb_valor_raio.Size = new System.Drawing.Size(102, 18);
            this.lb_valor_raio.TabIndex = 2;
            this.lb_valor_raio.Text = "Digite o valor: ";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(136, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(137, 40);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Milhas \r\npara quilometros";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(20, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(112, 40);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Quilômetros \r\npara milhas";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lb_valor_convertido_radio
            // 
            this.lb_valor_convertido_radio.AutoSize = true;
            this.lb_valor_convertido_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valor_convertido_radio.Location = new System.Drawing.Point(17, 126);
            this.lb_valor_convertido_radio.Name = "lb_valor_convertido_radio";
            this.lb_valor_convertido_radio.Size = new System.Drawing.Size(123, 18);
            this.lb_valor_convertido_radio.TabIndex = 4;
            this.lb_valor_convertido_radio.Text = "Valor convertido: ";
            // 
            // bt_calc
            // 
            this.bt_calc.Location = new System.Drawing.Point(20, 86);
            this.bt_calc.Name = "bt_calc";
            this.bt_calc.Size = new System.Drawing.Size(226, 32);
            this.bt_calc.TabIndex = 5;
            this.bt_calc.Text = "Calcular";
            this.bt_calc.UseVisualStyleBackColor = true;
            this.bt_calc.Click += new System.EventHandler(this.bt_calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 208);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ValorConvertido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox KmOuMilha;
        private System.Windows.Forms.Label lb_valor_raio;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button bt_calc;
        private System.Windows.Forms.Label lb_valor_convertido_radio;
        private System.Windows.Forms.TextBox textBox2;
    }
}

