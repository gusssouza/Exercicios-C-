using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_extra_atividade3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int quantidade = Convert.ToInt32(txbQuant.Text);
            int primeiro = 1;
            int segundo = 0;
            int soma = 0;
            listBox1.Items.Clear();
            for (int i = 0; i < quantidade; i++)
            {
                soma = primeiro + segundo;
                primeiro = segundo;
                segundo = soma;
                listBox1.Items.Add(Convert.ToString(soma));
            }
        }

        private void btnMMC_Click(object sender, EventArgs e)
        {
            Form1 mmc = new Form1();
            mmc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fatorar = new Form3();
            fatorar.ShowDialog();
        }
    }
}
