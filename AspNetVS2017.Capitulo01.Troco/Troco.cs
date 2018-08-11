using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetVS2017.Capitulo01.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            var valorCompra = Convert.ToDecimal(valorCompraTextbox.Text);
            var valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            if (valorPago >= valorCompra) {

                var valorTroco = (valorPago - valorCompra);
                valorTrocoTextBox.Text = valorTroco.ToString("C", new CultureInfo("en-US"));

                //ToDo: Refatorar para usar vetor e for.

                var moedas1 = (int)valorTroco;
                valorTroco = (valorTroco % 1); //ou valorTroco = valoTroco - moedas1;

                var moedas050 = (int)(valorTroco / 0.5M);
                valorTroco %= 0.5M;

                var moedas025 = (int)(valorTroco / 0.25M);
                valorTroco %= 0.25M;

                var moedas010 = (int)(valorTroco / 0.10M);
                valorTroco %= 0.10M;

                var moedas005 = (int)(valorTroco / 0.05M);
                valorTroco %= 0.05M;

                var moedas001 = (int)(valorTroco / 0.01M);
                valorTroco %= 0.01M;

                moedasListView.Items[0].Text = moedas1.ToString();
                moedasListView.Items[1].Text = moedas050.ToString();
                moedasListView.Items[2].Text = moedas025.ToString();
                moedasListView.Items[3].Text = moedas010.ToString();
                moedasListView.Items[4].Text = moedas005.ToString();
                moedasListView.Items[5].Text = moedas001.ToString();
            }
            else
            {
                valorTrocoTextBox.Text = "Valor pago inferior ao da compra";
            }
        }
    }
}
