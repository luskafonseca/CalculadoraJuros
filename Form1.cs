using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraJuros
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrincipal.Text, out double principal) &&
        double.TryParse(txtTaxaJuros.Text, out double taxaJuros) &&
        int.TryParse(txtNumeroParcelas.Text, out int numeroParcelas))
            {
                double taxaJurosMensal = (taxaJuros / 100) / 12;
                double valorParcela = principal * (taxaJurosMensal / (1 - Math.Pow(1 + taxaJurosMensal, -numeroParcelas)));
                double totalJuros = (valorParcela * numeroParcelas) - principal;
                double totalPago = principal + totalJuros;

                lblValorParcela.Text = $"Valor da parcela: {valorParcela:C}";
                lblTotalJuros.Text = $"Total em juros: {totalJuros:C}";
                lblTotalPago.Text = $"Total Pago: {totalPago:C}";
            }
            else
            {
                MessageBox.Show("Por favor, insira valores válidos.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
