using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estacionamento
{
    public partial class Inicio : Form
    {
        public int varPrecoInicial, varPrecoPorHora;
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boxPrecoInicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(boxPrecoInicial.Text, out varPrecoInicial) && int.TryParse(boxPrecoPorHora.Text, out varPrecoPorHora))
            {
                Meio meio = new Meio(varPrecoInicial, varPrecoPorHora);
                meio.Show();
            }
            else
            {
                MessageBox.Show("Insira o valor nos campos!");
            }
        }
    }
}
