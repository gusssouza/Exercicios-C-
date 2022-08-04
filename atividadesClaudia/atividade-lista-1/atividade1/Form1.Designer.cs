namespace kkkk
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
            this.txbVerifica = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.txbPosNeg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbParImpar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbVerifica
            // 
            this.txbVerifica.Location = new System.Drawing.Point(366, 255);
            this.txbVerifica.Name = "txbVerifica";
            this.txbVerifica.Size = new System.Drawing.Size(75, 23);
            this.txbVerifica.TabIndex = 0;
            this.txbVerifica.Text = "Verificar";
            this.txbVerifica.UseVisualStyleBackColor = true;
            this.txbVerifica.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insira um número:";
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(400, 156);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(100, 23);
            this.txbNum.TabIndex = 2;
            // 
            // txbPosNeg
            // 
            this.txbPosNeg.Location = new System.Drawing.Point(400, 187);
            this.txbPosNeg.Name = "txbPosNeg";
            this.txbPosNeg.Size = new System.Drawing.Size(100, 23);
            this.txbPosNeg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "positivo ou negativo:";
            // 
            // txbParImpar
            // 
            this.txbParImpar.Location = new System.Drawing.Point(400, 216);
            this.txbParImpar.Name = "txbParImpar";
            this.txbParImpar.Size = new System.Drawing.Size(100, 23);
            this.txbParImpar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "par ou impar:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbParImpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbPosNeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbVerifica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button txbVerifica;
        private Label label1;
        private TextBox txbNum;
        private TextBox txbPosNeg;
        private Label label2;
        private TextBox txbParImpar;
        private Label label3;
    }
}