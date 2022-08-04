namespace lista_extra_atividade3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            int primeiro = Convert.ToInt16(txbPrimeiro.Text);
            int segundo = Convert.ToInt16(txbSegundo.Text);
            int mmc = 1;
            listBox1.Items.Clear();
            while (!(mmc % primeiro == 0 && mmc % segundo == 0))
            {
                mmc++;
            };
            listBox1.Items.Add(Convert.ToString(mmc));

        }

        private void btnFibbonati_Click(object sender, EventArgs e)

        {
            Form2 fibonnati = new Form2();
            fibonnati.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fatorar = new Form3();
            fatorar.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}