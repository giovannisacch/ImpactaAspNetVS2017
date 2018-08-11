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

            var valorTroco = (valorPago - valorCompra);
            valorTrocoTextBox.Text = valorTroco.ToString("C", new CultureInfo("en-US"));
        }
    }
}
