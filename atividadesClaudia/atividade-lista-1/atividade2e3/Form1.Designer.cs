namespace Atividade03
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
            this.txbInicio = new System.Windows.Forms.TextBox();
            this.txbFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txbIntervalo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNegativo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbPares = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMult = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero inicio:";
            // 
            // txbInicio
            // 
            this.txbInicio.Location = new System.Drawing.Point(368, 108);
            this.txbInicio.Name = "txbInicio";
            this.txbInicio.Size = new System.Drawing.Size(100, 23);
            this.txbInicio.TabIndex = 1;
            // 
            // txbFinal
            // 
            this.txbFinal.Location = new System.Drawing.Point(368, 137);
            this.txbFinal.Name = "txbFinal";
            this.txbFinal.Size = new System.Drawing.Size(100, 23);
            this.txbFinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero final:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(284, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 94);
            this.listBox1.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(342, 394);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txbIntervalo
            // 
            this.txbIntervalo.Location = new System.Drawing.Point(368, 169);
            this.txbIntervalo.Name = "txbIntervalo";
            this.txbIntervalo.Size = new System.Drawing.Size(100, 23);
            this.txbIntervalo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Intervalo:";
            // 
            // txbNegativo
            // 
            this.txbNegativo.Location = new System.Drawing.Point(368, 198);
            this.txbNegativo.Name = "txbNegativo";
            this.txbNegativo.Size = new System.Drawing.Size(100, 23);
            this.txbNegativo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Negativos:";
            // 
            // txbPares
            // 
            this.txbPares.Location = new System.Drawing.Point(368, 227);
            this.txbPares.Name = "txbPares";
            this.txbPares.Size = new System.Drawing.Size(100, 23);
            this.txbPares.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pares:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txbMult
            // 
            this.txbMult.Location = new System.Drawing.Point(368, 256);
            this.txbMult.Name = "txbMult";
            this.txbMult.Size = new System.Drawing.Size(100, 23);
            this.txbMult.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Multiplos de 7:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbMult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbPares);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNegativo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIntervalo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txbFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbInicio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lstNum";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbInicio;
        private TextBox txbFinal;
        private Label label2;
        private ListBox listBox1;
        private Button btnEnviar;
        private TextBox txbIntervalo;
        private Label label3;
        private TextBox txbNegativo;
        private Label label4;
        private TextBox txbPares;
        private Label label5;
        private TextBox txbMult;
        private Label label6;
    }
}