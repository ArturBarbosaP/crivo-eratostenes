using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CrivoEratostenes
{
    public partial class frm_crivoEratostenes : Form
    {
        public frm_crivoEratostenes()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            ltx_resultado.Items.Clear(); //limpando o passo a passo
            dtg_listaNum.Rows.Clear(); //limpando a tabela

            int numero = int.Parse(txt_num.Text); //número passado pelo usuário
            string resultado = ""; //string do resultado para mostrar no passo a passo
            string numRemoveidos; //string dos numeros removidos
            List<int> lista = new List<int>(); //lista com todos números inteiros entre 2 e n-1

            int colunaAtual = 0; //coluna atual para inserção na tabela
            int linhaAtual = 0; //linha atual para inserção na tabela
            int linhasNecessarias = (int)Math.Ceiling((decimal)(numero - 1) / 10); // Calcula o número de linhas necessárias para imprimir os numeros

            if (numero > 2)
            {
                for (int l = 0; l < linhasNecessarias; l++)
                    dtg_listaNum.Rows.Add(); //adicionando as linhas ao dtg

                for (int i = 2; i < numero; i++) //adicionando na lista os números entre 2 e n - 1
                {
                    lista.Add(i); //adicionando a lista os numeros

                    dtg_listaNum.Rows[linhaAtual].Cells[colunaAtual].Value = i.ToString(); // adicionando os numeros ao dtg
                    colunaAtual++; //incrementando a coluna atual

                    if (colunaAtual == 10) //se a coluna atual for a última, saltar uma linha e começar da primeira coluna
                    {
                        colunaAtual = 0;
                        linhaAtual++;
                    }
                }

                int maiorNumVer = (int)Math.Sqrt(numero); //o maior número a ser verificado é a raiz quadrada do número passado pelo usuário arredondado para baixo.
                ltx_resultado.Items.Add($"Removendo da lista os múltiplos de cada primo menor que {maiorNumVer}."); //mostrando no passo a passo o maior número a ser verificado

                for (int i = 2; i <= maiorNumVer; i++) //para cada número primo menor que o maior número a ser verificado, remover da lista seus múltiplos, exceto o 2
                {
                    ltx_resultado.Items.Add($"Removendo os múltiplos de {i}: "); //mostrando no passo a passo os múltiplos de qual número que serão removidos
                    numRemoveidos = ""; //string dos números removidos para exibir no passo a passo
                    for (int j = i + i; j < numero; j += i) //removendo da lista todos os números múltiplos de i
                    {
                        if (lista.Contains(j)) //se o número a ser removido está na lista, remover e exibir no passo a passo, caso não esteja não será mostrado no passo a passo
                        {
                            if (numRemoveidos.Length == 0) //se for o primeiro numero inserido, só o numero, se não, inserir a ,
                                numRemoveidos += $"{j}";
                            else
                                numRemoveidos += $", {j}";

                            lista.Remove(j); //remover da lista
                        }
                    }
                    if (numRemoveidos.Length == 0) //se nenhum número foi removido, excluir a última linha do passo a passo
                        ltx_resultado.Items.RemoveAt(ltx_resultado.Items.Count - 1);
                    else
                        ltx_resultado.Items.Add(numRemoveidos); //se algum número for removido, mostrar no passo a passo
                }

                ltx_resultado.Items.Add($"Os números restantes da lista são os primos menores que {numero}.");
                ltx_resultado.Items.Add("Resultado:"); //final do passo a passo mostrando o resultado
                foreach (int i in lista)
                {
                    resultado += $"{i}, "; //adicionando os números restantes da lista no passo a passo
                    foreach (DataGridViewRow row in dtg_listaNum.Rows) //percorrendo todo data grid view para colorir o fundo dos números do resultado
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (row.Cells[j].Value != null && row.Cells[j].Value.ToString() == i.ToString())
                                row.Cells[j].Style.BackColor = Color.PaleTurquoise;
                        }
                    }
                }

                resultado = resultado.TrimEnd(',', ' '); //removendo a vírgula e o espaço final do resultado
                ltx_resultado.Items.Add(resultado); //exibindo o resultado no passo a passo
                txt_resultado.Text = resultado; //exibindo o resultado de maneira destacada
            }
            else
            {
                ltx_resultado.Items.Add("Não há números primos menores que 2.");
            }
        }

        private void dtg_listaNum_SelectionChanged(object sender, EventArgs e)
        {
            dtg_listaNum.ClearSelection(); //removendo a seleção do dtg
        }
    }
}