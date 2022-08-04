namespace Atividade03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)

        {
            listBox1.Items.Clear();

            int numeroInicio = Convert.ToInt16(txbInicio.Text);
            int numeroFim = Convert.ToInt16(txbFinal.Text);
            int intervalo = Convert.ToInt16(txbIntervalo.Text);
            int negativos = 0;
            int pares = 0;
            int mult7 = 0;
  
          

            for (int i = numeroInicio; i <= numeroFim; i += intervalo)
            {
                string resultado = i.ToString();
                listBox1.Items.Add(resultado);

                if ( i < 0)
                {
                    negativos +=1;
                }
                if (i % 2 == 0)
                {
                   pares +=1;
                }
                if (i % 7 == 0)
                {
                    mult7 +=1;
                }
            }

            listBox1.Items.Add(negativos + " Números negativos");
            listBox1.Items.Add(pares + " Números pares");
            listBox1.Items.Add(mult7 + " Múltiplos de 7");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}