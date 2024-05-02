using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5 {
    public partial class FormOrdenacao : Form {

        int[] vet = new int[500]; // vetor interno para a animação
        int[] vet_est; // vetor interno para estatística
        string preeenchimento; // modo de preenchimento

        public FormOrdenacao() 
        {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
            cbx_tamanho.SelectedIndex = 0;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < vet.Length; i++) 
            {
                e.Graphics.DrawLine(Pens.Blue, i, 299, i, 299 - vet[i]);
            }
        }

        //Animações
        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
            this.Text += " - Bolha";
        }

        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Selecao(vet, panel));
            this.Text += " - Seleção";
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Insercao(vet, panel));
            this.Text += " - Inserção";
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.ShellSort(vet, panel));
            this.Text += " - ShellSort";
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.HeapSort(vet, panel));
            this.Text += " - HeapSort";
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.QuickSort(vet, 0, vet.Length - 1, panel));
            this.Text += " - QuickSort";
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.MergeSort(vet, 0, vet.Length - 1, panel));
            this.Text += " - MergeSort";
        }

        //Sobre
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            MessageBox.Show(this, 
                "Prática 5 2023/1 - Métodos de Ordenação\n\n" +
                "Desenvolvido por:\n72300400 - Artur Barbosa Pinto\n" +
                "Prof. Virgílio Borges de Oliveira\n\n" +
                "Algoritmos e Estruturas de Dados\n" +
                "Faculdade COTEMIG\n" +
                "Apenas para fins didáticos.", 
                "Sobre o trabalho...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) 
        {
            if (bgw.IsBusy != true) 
            {
                //escolha do estado inicial
                if (rbt_ale.Checked)
                {
                    Preenchimento.Aleatorio(vet, 300);
                }
                else if (rbt_cres.Checked)
                {
                    Preenchimento.Crescente(vet, 300);
                }
                else
                {
                    Preenchimento.Decrescente(vet, 300);
                }

                bgw.RunWorkerAsync(a);
            }
            else 
            {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Prática 5 2023/1 - Métodos de Ordenação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) 
        {
            this.Text = "Prática 5 2023/1 - Métodos de Ordenação";
            MessageBox.Show(this,
               "Animação concluída!",
               "Prática 5 2023/1 - Métodos de Ordenação",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        //Estatísticas

        private void estatísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tamanho = Convert.ToInt32(cbx_tamanho.SelectedItem.ToString().Replace(".", ""));
            vet_est = new int[tamanho];

            if (rbt_ale.Checked)
            {
                Preenchimento.Aleatorio(vet_est, tamanho);
                preeenchimento = "Aleatório";
            }
            else if (rbt_cres.Checked)
            {
                Preenchimento.Crescente(vet_est, tamanho);
                preeenchimento = "Crescente";
            }
            else
            {
                Preenchimento.Decrescente(vet_est, tamanho);
                preeenchimento = "Decrescente";
            }
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e) 
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.ResetCont(); //resetar contadores
            OrdenacaoEstatistica.Bolha(vet_est);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + cbx_tamanho.SelectedItem +
                  "\nOrdenação inicial: " + preeenchimento +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void seleçaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.ResetCont(); //resetar contadores
            OrdenacaoEstatistica.Selecao(vet_est);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + cbx_tamanho.SelectedItem +
                  "\nOrdenação inicial: " + preeenchimento +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Seleção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void inserçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.ResetCont(); //resetar contadores
            OrdenacaoEstatistica.Insercao(vet_est);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + cbx_tamanho.SelectedItem +
                  "\nOrdenação inicial: " + preeenchimento +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Inserção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void shellSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.ResetCont(); //resetar contadores
            OrdenacaoEstatistica.ShellSort(vet_est);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + cbx_tamanho.SelectedItem +
                  "\nOrdenação inicial: " + preeenchimento +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método ShellSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void heapSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.ResetCont(); //resetar contadores
            OrdenacaoEstatistica.HeapSort(vet_est);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + cbx_tamanho.SelectedItem +
                  "\nOrdenação inicial: " + preeenchimento +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método HeapSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void quickSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.ResetCont(); //resetar contadores
            OrdenacaoEstatistica.QuickSort(vet_est, 0, vet_est.Length - 1);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + cbx_tamanho.SelectedItem +
                  "\nOrdenação inicial: " + preeenchimento +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método QuickSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void mergeSortToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.ResetCont(); //resetar contadores
            OrdenacaoEstatistica.MergeSort(vet_est, 0, vet_est.Length - 1);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + cbx_tamanho.SelectedItem +
                  "\nOrdenação inicial: " + preeenchimento +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método MergeSort",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }
    }
}