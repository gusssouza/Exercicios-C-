﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)

        {
            txbResultado.Text = "";
            int valor = Convert.ToInt32(txbNumero.Text);
            int total = 0;
            for (int i = valor; i > 0; i--)
            {
                if (i == valor)
                {
                    total = valor;
                    txbResultado.Text = i.ToString();
            }
                else
                {
                    total = total * i;
                    txbResultado.Text = total.ToString();
            }
            } 
        }
    }
}
