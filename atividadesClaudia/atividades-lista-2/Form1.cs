namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int inicio = Convert.ToInt16(txbInicio.Text);
            int final = Convert.ToInt16(txbFinal.Text);
            for(int i = inicio; i<=final ; i++)
            {
                listBox1.Items.Add(i.ToString());
            }
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 dois = new Form2();
            dois.ShowDialog();
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            Form3 tres = new Form3();
            tres.ShowDialog();
        }
    }

        
}