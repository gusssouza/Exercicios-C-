namespace asterisco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string asterisco = "";
            for(int i = 0; i < 10; i++)
            {
                asterisco = asterisco + "*";
                listBox1.Items.Add(asterisco);
            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            string asteriscoInvertido = "**********";
            for (int i = 0; i < 10; i++)
            {
                asteriscoInvertido = asteriscoInvertido.Remove(asteriscoInvertido.Length - 1);
                listBox1.Items.Add(asteriscoInvertido);
            }
        }

        private void btnPiramide_Click(object sender, EventArgs e)

        {
            string espaco = " ";
            string asteriscoPiramideDecrescente = "*******";
            for (int i = 0; i < 6; i++)
            {
                asteriscoPiramideDecrescente = espaco + asteriscoPiramideDecrescente.Remove(asteriscoPiramideDecrescente.Length - 1);
                listBox1.Items.Add(asteriscoPiramideDecrescente);
            }
                string espacoCrescente = "       ";
                string asteriscoPiramideCrescente = "";
                    for (int i = 0; i < 6; i++)
                    {
                        asteriscoPiramideCrescente = asteriscoPiramideCrescente + "*";
                        espacoCrescente = espacoCrescente.Remove(espacoCrescente.Length - 1);
                        listBox1.Items.Add(espacoCrescente + asteriscoPiramideCrescente);
                    }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}