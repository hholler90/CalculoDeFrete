namespace ExercicioCalculoFrete
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUf = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.gbValoresCalculados = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblValordaCompra = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbValoresCalculados.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxUf);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Entrega";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(183, 134);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 34);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(47, 134);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // cbxUf
            // 
            this.cbxUf.FormattingEnabled = true;
            this.cbxUf.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "AM",
            "RS",
            "PR",
            "SC",
            "MT"});
            this.cbxUf.Location = new System.Drawing.Point(69, 75);
            this.cbxUf.Name = "cbxUf";
            this.cbxUf.Size = new System.Drawing.Size(121, 21);
            this.cbxUf.TabIndex = 2;
            this.cbxUf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxUf_KeyDown);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(69, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // gbValoresCalculados
            // 
            this.gbValoresCalculados.Controls.Add(this.lblTotal);
            this.gbValoresCalculados.Controls.Add(this.lblFrete);
            this.gbValoresCalculados.Controls.Add(this.lblValordaCompra);
            this.gbValoresCalculados.Controls.Add(this.label6);
            this.gbValoresCalculados.Controls.Add(this.label5);
            this.gbValoresCalculados.Controls.Add(this.label4);
            this.gbValoresCalculados.Location = new System.Drawing.Point(27, 228);
            this.gbValoresCalculados.Name = "gbValoresCalculados";
            this.gbValoresCalculados.Size = new System.Drawing.Size(328, 158);
            this.gbValoresCalculados.TabIndex = 2;
            this.gbValoresCalculados.TabStop = false;
            this.gbValoresCalculados.Text = "Valores Calculados";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(132, 107);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(67, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "__________";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(132, 76);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(67, 13);
            this.lblFrete.TabIndex = 4;
            this.lblFrete.Text = "__________";
            // 
            // lblValordaCompra
            // 
            this.lblValordaCompra.AutoSize = true;
            this.lblValordaCompra.Location = new System.Drawing.Point(132, 45);
            this.lblValordaCompra.Name = "lblValordaCompra";
            this.lblValordaCompra.Size = new System.Drawing.Size(67, 13);
            this.lblValordaCompra.TabIndex = 3;
            this.lblValordaCompra.Text = "__________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Frete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor da Compra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.gbValoresCalculados);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculo de Frete";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbValoresCalculados.ResumeLayout(false);
            this.gbValoresCalculados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUf;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox gbValoresCalculados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.Label lblValordaCompra;
    }
}

