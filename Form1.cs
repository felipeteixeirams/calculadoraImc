using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CalcularIMC IMC = new CalcularIMC();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int peso = Convert.ToInt32(txbPeso.Text);
                double altura = (Convert.ToDouble(Convert.ToInt32(txbAltura.Text)))/100;
                txbResultado.Text = IMC.Calcular(peso, altura);
            }
            catch
            {
                txbResultado.Text = "Verifique os dados informados!";
            }
        }

    }
}
