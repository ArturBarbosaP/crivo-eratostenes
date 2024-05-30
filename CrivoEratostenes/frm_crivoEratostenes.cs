using System;

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

            int numero = int.Parse(txt_num.Text); //número passado pelo usuário
            string resultado = ""; //string do resultado para mostrar no passo a passo
            ltx_resultado.Items.Add($"Primos menores que {numero}:\r\n"); //começo do passo a passo
            List<int> lista = new List<int>(); //lista com todos números inteiros entre 2 e n-1
            if (numero > 2)
            {
                for (int i = 2; i < numero; i++) //adicionando na lista os números entre 2 e n - 1
                    lista.Add(i);

                dtg_listaNum.DataSource = lista;

                ltx_resultado.Items.Add($"Escrevendo uma lista com números inteiros entre 2 e {lista[lista.Count - 1]}.\r\n");
                int maiorNumVer = (int)Math.Sqrt(numero); //o maior número a ser verificado é a raiz quadrada do número passado pelo usuário arredondado para baixo.
                ltx_resultado.Items.Add($"Removendo da lista os múltiplos de cada primo menor que {maiorNumVer}.\r\n");

                for (int i = 2; i <= maiorNumVer; i++) //para cada número primo menor que o maior número a ser verificado, remover da lista seus múltiplos, exceto o 2
                {
                    for (int j = i + i; j < numero; j += i)//removendo da lista todos os números múltiplos de i
                        lista.Remove(j);
                }

                ltx_resultado.Items.Add($"Os números restantes da lista são os primos menores que {numero}. Resultado: \r\n");
                foreach (int i in lista) //adicionando os números restantes da lista no passo a passo
                    resultado += $"{i}, ";

                ltx_resultado.Items.Add(resultado);
            }
            else
            {
                ltx_resultado.Items.Add("Não há números primos menores que 2.");
            }
        }
    }
}