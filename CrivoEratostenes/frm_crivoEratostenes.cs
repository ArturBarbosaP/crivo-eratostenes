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

            int numero = int.Parse(txt_num.Text); //n�mero passado pelo usu�rio
            string resultado = ""; //string do resultado para mostrar no passo a passo
            string numRemoveidos; //string dos numeros removidos
            List<int> lista = new List<int>(); //lista com todos n�meros inteiros entre 2 e n-1

            int colunaAtual = 0; //coluna atual para inser��o na tabela
            int linhaAtual = 0; //linha atual para inser��o na tabela
            int linhasNecessarias = (int)Math.Ceiling((decimal)(numero - 1) / 10); // Calcula o n�mero de linhas necess�rias para imprimir os numeros

            if (numero > 2)
            {
                for (int l = 0; l < linhasNecessarias; l++)
                    dtg_listaNum.Rows.Add(); //adicionando as linhas ao dtg

                for (int i = 2; i < numero; i++) //adicionando na lista os n�meros entre 2 e n - 1
                {
                    lista.Add(i); //adicionando a lista os numeros

                    dtg_listaNum.Rows[linhaAtual].Cells[colunaAtual].Value = i.ToString(); // adicionando os numeros ao dtg
                    colunaAtual++; //incrementando a coluna atual

                    if (colunaAtual == 10) //se a coluna atual for a �ltima, saltar uma linha e come�ar da primeira coluna
                    {
                        colunaAtual = 0;
                        linhaAtual++;
                    }
                }

                int maiorNumVer = (int)Math.Sqrt(numero); //o maior n�mero a ser verificado � a raiz quadrada do n�mero passado pelo usu�rio arredondado para baixo.
                ltx_resultado.Items.Add($"Removendo da lista os m�ltiplos de cada primo menor que {maiorNumVer}."); //mostrando no passo a passo o maior n�mero a ser verificado

                for (int i = 2; i <= maiorNumVer; i++) //para cada n�mero primo menor que o maior n�mero a ser verificado, remover da lista seus m�ltiplos, exceto o 2
                {
                    ltx_resultado.Items.Add($"Removendo os m�ltiplos de {i}: "); //mostrando no passo a passo os m�ltiplos de qual n�mero que ser�o removidos
                    numRemoveidos = ""; //string dos n�meros removidos para exibir no passo a passo
                    for (int j = i + i; j < numero; j += i) //removendo da lista todos os n�meros m�ltiplos de i
                    {
                        if (lista.Contains(j)) //se o n�mero a ser removido est� na lista, remover e exibir no passo a passo, caso n�o esteja n�o ser� mostrado no passo a passo
                        {
                            if (numRemoveidos.Length == 0) //se for o primeiro numero inserido, s� o numero, se n�o, inserir a ,
                                numRemoveidos += $"{j}";
                            else
                                numRemoveidos += $", {j}";

                            lista.Remove(j); //remover da lista
                        }
                    }
                    if (numRemoveidos.Length == 0) //se nenhum n�mero foi removido, excluir a �ltima linha do passo a passo
                        ltx_resultado.Items.RemoveAt(ltx_resultado.Items.Count - 1);
                    else
                        ltx_resultado.Items.Add(numRemoveidos); //se algum n�mero for removido, mostrar no passo a passo
                }

                ltx_resultado.Items.Add($"Os n�meros restantes da lista s�o os primos menores que {numero}.");
                ltx_resultado.Items.Add("Resultado:"); //final do passo a passo mostrando o resultado
                foreach (int i in lista)
                {
                    resultado += $"{i}, "; //adicionando os n�meros restantes da lista no passo a passo
                    foreach (DataGridViewRow row in dtg_listaNum.Rows) //percorrendo todo data grid view para colorir o fundo dos n�meros do resultado
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (row.Cells[j].Value != null && row.Cells[j].Value.ToString() == i.ToString())
                                row.Cells[j].Style.BackColor = Color.PaleTurquoise;
                        }
                    }
                }

                resultado = resultado.TrimEnd(',', ' '); //removendo a v�rgula e o espa�o final do resultado
                ltx_resultado.Items.Add(resultado); //exibindo o resultado no passo a passo
                txt_resultado.Text = resultado; //exibindo o resultado de maneira destacada
            }
            else
            {
                ltx_resultado.Items.Add("N�o h� n�meros primos menores que 2.");
            }
        }

        private void dtg_listaNum_SelectionChanged(object sender, EventArgs e)
        {
            dtg_listaNum.ClearSelection(); //removendo a sele��o do dtg
        }
    }
}