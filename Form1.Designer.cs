﻿
namespace calculadoraIMC
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
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura (cm):";
            // 
            // txbPeso
            // 
            this.txbPeso.Location = new System.Drawing.Point(117, 26);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(114, 27);
            this.txbPeso.TabIndex = 2;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(117, 65);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(114, 27);
            this.txbAltura.TabIndex = 3;
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(11, 26);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.ReadOnly = true;
            this.txbResultado.Size = new System.Drawing.Size(220, 27);
            this.txbResultado.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(71, 113);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 29);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPeso);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbAltura);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados para calculo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbResultado);
            this.groupBox2.Location = new System.Drawing.Point(23, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 67);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculadora de IMC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.TextBox txbResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

