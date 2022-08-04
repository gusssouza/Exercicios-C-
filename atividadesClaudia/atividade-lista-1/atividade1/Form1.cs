namespace kkkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numero = Convert.ToInt16(txbNum.Text);
            if (numero > 0)
            {
                txbPosNeg.Text = "Positivo";
            }
            else
            {
                txbPosNeg.Text = "Negativo";
            }

            if (numero % 2 == 0)
            {
                txbParImpar.Text = "Par";  
            }
            else
            {
                txbParImpar.Text = "Impar";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}