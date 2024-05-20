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
            int numero = int.Parse(txt_num.Text); //n�mero passado pelo usu�rio
            string passo = $"Primos menores que {numero}:\r\n"; //come�o do passo a passo
            List<int> lista = new List<int>(); //lista com todos n�meros inteiros entre 2 e n-1

            if (numero > 1) //se o n�mero for menor que 1, mostrar erro na tela
            {
                if (numero > 2)
                {
                    for (int i = 2; i < numero; i++) //adicionando na lista os n�meros entre 2 e n - 1
                        lista.Add(i);

                    passo += $"Escrevendo uma lista com n�meros inteiros entre 2 e {lista[lista.Count - 1]}.\r\n";
                    int maiorNumVer = (int)Math.Sqrt(numero); //o maior n�mero a ser verificado � a raiz quadrada do n�mero passado pelo usu�rio arredondado para baixo.
                    passo += $"Removendo da lista os m�ltiplos de cada primo menor que {maiorNumVer}.\r\n";

                    for (int i = 2; i <= maiorNumVer; i++) //para cada n�mero primo menor que o maior n�mero a ser verificado, remover da lista seus m�ltiplos, exceto o 2
                    {
                        for (int j = i + i; j < numero; j += i)//removendo da lista todos os n�meros m�ltiplos de i
                            lista.Remove(j);
                    }

                    passo += $"Os n�meros restantes da lista s�o os primos menores que {numero}. Resultado: \r\n";
                    foreach (int i in lista) //adicionando os n�meros restantes da lista no passo a passo
                        passo += $"{i}, ";
                }
                else
                {
                    passo = "N�o h� n�meros primos menores que 2.";
                }

                txt_resultado.Text = passo; //fim do passo a passo
            }
            else
            {
                MessageBox.Show("Erro! O n�mero dever� ser maior que 1");
            }
        }
    }
}