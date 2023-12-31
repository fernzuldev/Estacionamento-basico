using Estacionamento.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Meio : Form
    {
        public int varPrecoInicial, varPrecoPorHora;
        List<Veiculo> listaVeiculos = new List<Veiculo>();
        public Meio(int varPrecoInicial, int varPrecoPorHora)
        {
            InitializeComponent();
            this.varPrecoInicial = varPrecoInicial;
            this.varPrecoPorHora = varPrecoPorHora;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string placaDoVeiculo = boxCadastrar.Text;

            if (!string.IsNullOrEmpty(placaDoVeiculo))
            {
                if (!PlacaExistente(placaDoVeiculo))
                {
                    Veiculo novoVeiculo = new Veiculo(placaDoVeiculo);

                    listaVeiculos.Add(novoVeiculo);
                    MessageBox.Show($"Veiculo {placaDoVeiculo} adicionado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Esta placa já está cadastrada, Por favor insira outra");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira a placa do veículo.");
            }
        }
        private bool PlacaExistente(string placa)
        {
            return listaVeiculos.Any(veiculo => veiculo.Placa == placa);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            rtbListar.Clear();

            if (listaVeiculos.Count > 0)
            {
                foreach (Veiculo veiculo in listaVeiculos)
                {
                    rtbListar.AppendText($"{veiculo.Placa}\n");
                }
            }
            else
            {
                rtbListar.AppendText("Nenhum veículo cadastrado.");
            }
        }

        private void boxRemover_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string placaDoVeiculoRemover = boxRemover.Text;

            if (!string.IsNullOrEmpty(placaDoVeiculoRemover))
            {
                Veiculo veiculoParaRemover = listaVeiculos.FirstOrDefault(veiculo => veiculo.Placa == placaDoVeiculoRemover);

                if (veiculoParaRemover != null)
                {
                    if (!string.IsNullOrEmpty(boxHoras.Text) && int.TryParse(boxHoras.Text, out int horasEstacionamento))
                    {
                        decimal valorTotal = varPrecoInicial + (varPrecoPorHora * horasEstacionamento);

                        MessageBox.Show($"Valor total do estacionamento: {valorTotal:C}");

                        listaVeiculos.Remove(veiculoParaRemover);

                        boxHoras.Clear();

                        AtualizarListaDeVeiculos();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, insira dados válidos na boxHoras.");
                    }
                }
                else
                {
                    MessageBox.Show("A placa informada não corresponde a nenhum veículo cadastrado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira a placa do veículo a ser removido.");
            }
        }
        private void AtualizarListaDeVeiculos()
        {
            rtbListar.Clear();

            if (listaVeiculos.Count > 0)
            {
                foreach (Veiculo veiculo in listaVeiculos)
                {
                    rtbListar.AppendText($"{veiculo.Placa}\n");
                }
            }
            else
            {
                rtbListar.AppendText("Nenhum veículo cadastrado.");
            }
        }

        private void Meio_Load(object sender, EventArgs e)
        {

        }
    }
}
