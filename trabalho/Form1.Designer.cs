namespace trabalho
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calcularPotencia = new System.Windows.Forms.Label();
            this.textGravidade = new System.Windows.Forms.TextBox();
            this.textMassa = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(50, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a gravidade :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a massa do objeto :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(50, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite  a altura : ";
            // 
            // calcularPotencia
            // 
            this.calcularPotencia.AutoSize = true;
            this.calcularPotencia.BackColor = System.Drawing.Color.Transparent;
            this.calcularPotencia.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcularPotencia.ForeColor = System.Drawing.Color.White;
            this.calcularPotencia.Location = new System.Drawing.Point(76, 9);
            this.calcularPotencia.Name = "calcularPotencia";
            this.calcularPotencia.Size = new System.Drawing.Size(416, 20);
            this.calcularPotencia.TabIndex = 3;
            this.calcularPotencia.Text = "calcular energia potencial gravitacional";
            this.calcularPotencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textGravidade
            // 
            this.textGravidade.Location = new System.Drawing.Point(50, 138);
            this.textGravidade.Name = "textGravidade";
            this.textGravidade.Size = new System.Drawing.Size(100, 23);
            this.textGravidade.TabIndex = 4;
            // 
            // textMassa
            // 
            this.textMassa.Location = new System.Drawing.Point(50, 208);
            this.textMassa.Name = "textMassa";
            this.textMassa.Size = new System.Drawing.Size(100, 23);
            this.textMassa.TabIndex = 5;
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(50, 277);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(100, 23);
            this.textAltura.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "calcular ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(443, 302);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(100, 23);
            this.textResultado.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(443, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::trabalho.Properties.Resources.potencial_;
            this.ClientSize = new System.Drawing.Size(600, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textGravidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMassa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.calcularPotencia);
            this.Name = "Form1";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label calcularPotencia;
        private TextBox textGravidade;
        private TextBox textMassa;
        private TextBox textAltura;
        private Button button1;
        private TextBox textResultado;
        private Label label4;
    }
}