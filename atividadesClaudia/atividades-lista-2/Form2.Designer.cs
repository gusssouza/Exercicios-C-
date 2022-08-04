namespace WinFormsApp1
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnRublo = new System.Windows.Forms.Button();
            this.btnYen = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor a ser convertido em real:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "para:";
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(304, 160);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(75, 23);
            this.btnDolar.TabIndex = 3;
            this.btnDolar.Text = "Dolar ";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnRublo
            // 
            this.btnRublo.Location = new System.Drawing.Point(385, 160);
            this.btnRublo.Name = "btnRublo";
            this.btnRublo.Size = new System.Drawing.Size(75, 23);
            this.btnRublo.TabIndex = 4;
            this.btnRublo.Text = "Rublo";
            this.btnRublo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRublo.UseVisualStyleBackColor = true;
            this.btnRublo.Click += new System.EventHandler(this.btnRublo_Click);
            // 
            // btnYen
            // 
            this.btnYen.Location = new System.Drawing.Point(466, 160);
            this.btnYen.Name = "btnYen";
            this.btnYen.Size = new System.Drawing.Size(75, 23);
            this.btnYen.TabIndex = 5;
            this.btnYen.Text = "Yene";
            this.btnYen.UseVisualStyleBackColor = true;
            this.btnYen.Click += new System.EventHandler(this.btnYen_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(345, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 19);
            this.listBox1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnYen);
            this.Controls.Add(this.btnRublo);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button btnDolar;
        private Button btnRublo;
        private Button btnYen;
        private ListBox listBox1;
    }
}