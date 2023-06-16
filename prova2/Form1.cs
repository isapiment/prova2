using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double codigo = Convert.ToDouble(tx_codigo.Text);
            string unidade = tx_unidade.Text;
            double descricao = Convert.ToDouble(tx_descricao.Text);
            double valor = Convert.ToDouble(tx_valor.Text);
            double pis = Convert.ToDouble(tx_pis.Text);
            double icms = Convert.ToDouble(tx_icms.Text);
            double confins = Convert.ToDouble(tx_confins.Text);
            double lucro = Convert.ToDouble(tx_lucro.Text);

            Calculo cal = Calculo.CalculoValor(valor, pis, icms, confins, lucro, unidade)
        }
    }
}
