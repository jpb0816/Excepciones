using System;

namespace Exception
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
            this.Aceptar = new System.Windows.Forms.Button();
            this.Aceptartxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Semestretxt = new System.Windows.Forms.TextBox();
            this.Matriculatxt = new System.Windows.Forms.TextBox();
            this.Telefonotxt = new System.Windows.Forms.TextBox();
            this.Carreratxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(478, 356);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(100, 38);
            this.Aceptar.TabIndex = 0;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Aceptartxt
            // 
            this.Aceptartxt.Location = new System.Drawing.Point(166, 190);
            this.Aceptartxt.Name = "Aceptartxt";
            this.Aceptartxt.Size = new System.Drawing.Size(100, 26);
            this.Aceptartxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono";
            // 
            // Semestretxt
            // 
            this.Semestretxt.Location = new System.Drawing.Point(630, 123);
            this.Semestretxt.Name = "Semestretxt";
            this.Semestretxt.Size = new System.Drawing.Size(100, 26);
            this.Semestretxt.TabIndex = 6;
            // 
            // Matriculatxt
            // 
            this.Matriculatxt.Location = new System.Drawing.Point(346, 123);
            this.Matriculatxt.Name = "Matriculatxt";
            this.Matriculatxt.Size = new System.Drawing.Size(100, 26);
            this.Matriculatxt.TabIndex = 7;
            // 
            // Telefonotxt
            // 
            this.Telefonotxt.Location = new System.Drawing.Point(630, 301);
            this.Telefonotxt.Name = "Telefonotxt";
            this.Telefonotxt.Size = new System.Drawing.Size(100, 26);
            this.Telefonotxt.TabIndex = 8;
            // 
            // Carreratxt
            // 
            this.Carreratxt.Location = new System.Drawing.Point(346, 301);
            this.Carreratxt.Name = "Carreratxt";
            this.Carreratxt.Size = new System.Drawing.Size(100, 26);
            this.Carreratxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Matricula";
            // 
            // txtCalif
            // 
            this.txtCalif.Location = new System.Drawing.Point(166, 301);
            this.txtCalif.Name = "txtCalif";
            this.txtCalif.Size = new System.Drawing.Size(100, 26);
            this.txtCalif.TabIndex = 12;
            this.txtCalif.Validating += new System.ComponentModel.CancelEventHandler(this.txtCalif_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Calificacion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCalif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Carreratxt);
            this.Controls.Add(this.Telefonotxt);
            this.Controls.Add(this.Matriculatxt);
            this.Controls.Add(this.Semestretxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptartxt);
            this.Controls.Add(this.Aceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.TextBox Aceptartxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Semestretxt;
        private System.Windows.Forms.TextBox Matriculatxt;
        private System.Windows.Forms.TextBox Telefonotxt;
        private System.Windows.Forms.TextBox Carreratxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalif;
        private System.Windows.Forms.Label label6;
    }
}

