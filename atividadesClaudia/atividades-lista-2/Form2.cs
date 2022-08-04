using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDolar_Click(object sender, EventArgs e)

        {
            listBox1.Items.Clear();
           int real = Convert.ToInt16(textBox1.Text);
            int dolar = real / 5;
            listBox1.Items.Add(dolar);
        }

        private void btnRublo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            float real = Convert.ToInt32(textBox1.Text);
            double rublo = real * 0.095;
            listBox1.Items.Add(rublo);
        }

        private void btnYen_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            float real = Convert.ToInt32(textBox1.Text);
            double yene = real * 0.040;
            listBox1.Items.Add(yene);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
