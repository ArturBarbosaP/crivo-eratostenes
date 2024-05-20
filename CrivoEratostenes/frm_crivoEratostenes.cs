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
            int numero = int.Parse(txt_num.Text); //número passado pelo usuário
            string passo = $"Primos menores que {numero}:\r\n"; //começo do passo a passo
            List<int> lista = new List<int>(); //lista com todos números inteiros entre 2 e n-1

            if (numero > 1) //se o número for menor que 1, mostrar erro na tela
            {
                if (numero > 2)
                {
                    for (int i = 2; i < numero; i++) //adicionando na lista os números entre 2 e n - 1
                        lista.Add(i);

                    passo += $"Escrevendo uma lista com números inteiros entre 2 e {lista[lista.Count - 1]}.\r\n";
                    int maiorNumVer = (int)Math.Sqrt(numero); //o maior número a ser verificado é a raiz quadrada do número passado pelo usuário arredondado para baixo.
                    passo += $"Removendo da lista os múltiplos de cada primo menor que {maiorNumVer}.\r\n";

                    for (int i = 2; i <= maiorNumVer; i++) //para cada número primo menor que o maior número a ser verificado, remover da lista seus múltiplos, exceto o 2
                    {
                        for (int j = i + i; j < numero; j += i)//removendo da lista todos os números múltiplos de i
                            lista.Remove(j);
                    }

                    passo += $"Os números restantes da lista são os primos menores que {numero}. Resultado: \r\n";
                    foreach (int i in lista) //adicionando os números restantes da lista no passo a passo
                        passo += $"{i}, ";
                }
                else
                {
                    passo = "Não há números primos menores que 2.";
                }

                txt_resultado.Text = passo; //fim do passo a passo
            }
            else
            {
                MessageBox.Show("Erro! O número deverá ser maior que 1");
            }
        }
    }
}