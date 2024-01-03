using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os dados
            txtNumero1.Clear();
            txtNumero2.Text = "";
            txtResultado.Text = String.Empty;

            txtNumero1.Focus();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if(double.TryParse(txtNumero1.Text, out Valor1) &&
                double.TryParse(txtNumero2.Text, out Valor2))
            {
                //Resultado = Valor1 + Valor2;
                Resultado = Valor1 + Valor2;
                txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos", "Erro o valor!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero1.Focus();
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if (double.TryParse(txtNumero1.Text, out Valor1) &&
                double.TryParse(txtNumero2.Text, out Valor2))
            {
                //Resultado = Valor1 - Valor2;
                Resultado = Valor1 - Valor2;
                txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos", "Erro o valor!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero1.Focus();
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if(double.TryParse(txtNumero1.Text, out Valor1) &&
                double.TryParse(txtNumero2.Text, out Valor2))
            {
                //Resultado = Valor1 * Valor2;
                Resultado = Valor1 * Valor2;
                txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos", "Erro o valor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero1.Focus();
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, Resultado;

            if(double.TryParse(txtNumero1.Text, out Valor1) &&
                double.TryParse(txtNumero2.Text, out Valor2))
            {
                //Resultado = Valor1 / Valor2;
                Resultado = Valor1 / Valor2;
                txtResultado.Text = Resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores Inválidos", "Erro o Valor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero1.Focus();
            }
        }
    }
}
