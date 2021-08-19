using System;
using System.Collections.Generic;
using System.Text;

namespace JogoDaVelha1
{
    class Tabuleiro
    {
        //Chamando as classes
        Formatacao ft = new Formatacao();

        public int Tamanho()
        {
            return 32;
        }

        //Imprimindo o referêncial de coordenadas
        public void Coordenadas()
        {
            string[,] Guia = new string[3, 3];
            Guia[0, 0] = " a1 ";
            Guia[0, 1] = " a2 ";
            Guia[0, 2] = " a3 ";
            Guia[1, 0] = " b1 ";
            Guia[1, 1] = " b2 ";
            Guia[1, 2] = " b3 ";
            Guia[2, 0] = " c1 ";
            Guia[2, 1] = " c2 ";
            Guia[2, 2] = " c3 ";

            ft.MargEsqu();
            ft.MargEsqu();
            Console.WriteLine("Guia das posições");
            Console.WriteLine();
            for (int i = 0; i <= 2; i++)
            {

                ft.MargEsqu();
                ft.MargEsqu();
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write(Guia[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Painel()
        {
            // estabelecendo o tamanho do tabuleiro/ matriz
            int n = Tamanho();
            // calculando as linha e colunas onde estarão as divisões 
            int mA = n / 3;// unidade das divisões

            string[,] mat = new string[n, n];

            //Imprimindo a matriz vazia
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = " ";
                }
            }

            //Definindo as linhas divisórias da matriz
            for (int i = 0; i < n; i++)
            {
                mat[i, mA] = "│";
                mat[mA, i] = "_";
                mat[2 * mA, i] = "_";
                mat[i, 2 * mA] = "│";
            }

            ft.Altura();

            //Imprimindo as linhas divisórias da matriz
            for (int i = 0; i < n; i++)
            {
                ft.MargEsqu();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j]);
                }
                Console.WriteLine();
            }

            Coordenadas();

            //Imprimindo a matriz e limpando o painel
            void matriz()
            {
                Console.Clear();
                ft.Altura();
                for (int i = 0; i < n; i++)
                {
                    ft.MargEsqu();
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(mat[i, j]);
                    }
                    Console.WriteLine();

                }
            }

            //Contador para alternar os jogadores
            int count = 3;
            //Contador para o número de jogadas
            int countj = 1;

            //contadores/marcadores de posições para 'X'
            int countxa1 = 0;
            int countxa2 = 0;
            int countxa3 = 0;
            int countxb1 = 0;
            int countxb2 = 0;
            int countxb3 = 0;
            int countxc1 = 0;
            int countxc2 = 0;
            int countxc3 = 0;
            //contadores/marcadores de posições para 'O'
            int countoa1 = 0;
            int countoa2 = 0;
            int countoa3 = 0;
            int countob1 = 0;
            int countob2 = 0;
            int countob3 = 0;
            int countoc1 = 0;
            int countoc2 = 0;
            int countoc3 = 0;
            while (countj <= 9)
            {
                //Condição de jogada para o jogador 1
                if (count % 2 != 0)
                {
                    ft.MargEsqu();
                    Console.Write("Jogador 1, suas coordenadas: ");
                    string m = Console.ReadLine().ToLower();
                    // Colocação do 'X' se a posição estiver disponível
                    if (m == "a1" && countxa1 == 0 && countoa1 == 0)
                    {
                        //Xa1
                        ft.MargEsqu();
                        for (int i = 3; i < mA - 2; i++)
                        {
                            mat[i, i] = "X";
                            mat[(mA) - i, i] = "X";
                        }

                        count = 4;
                        countxa1 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "a2" && countxa2 == 0 && countoa2 == 0)
                    {
                        //Xa2
                        ft.MargEsqu();
                        for (int i = mA + 3; i < 2 * mA - 2; i++)
                        {
                            mat[i - mA, i] = "X";
                            mat[(2 * mA) - i, i] = "X";
                        }

                        count = 4;
                        countxa2 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "a3" && countxa3 == 0 && countoa3 == 0)
                    {
                        //Xa3
                        ft.MargEsqu();
                        for (int i = 2 * mA + 3; i < 3 * mA - 2; i++)
                        {
                            mat[i - 2 * mA, i] = "X";
                            mat[(3 * mA) - i, i] = "X";
                        }

                        count = 4;
                        countxa3 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "b1" && countxb1 == 0 && countob1 == 0)
                    {
                        //Xb1
                        ft.MargEsqu();
                        for (int i = 3; i < mA - 2; i++)
                        {
                            mat[i + mA, i] = "X";
                            mat[(2 * mA - i), i] = "X";
                        }

                        count = 4;
                        countxb1 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "b2" && countxb2 == 0 && countob2 == 0)
                    {
                        //Xb2
                        ft.MargEsqu();
                        for (int i = mA + 3; i < 2 * mA - 2; i++)
                        {
                            mat[i, i] = "X";
                            mat[(3 * mA) - i, i] = "X";
                        }

                        count = 4;
                        countxb2 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "b3" && countxb3 == 0 && countob3 == 0)
                    {
                        //Xb3
                        ft.MargEsqu();
                        for (int i = 2 * mA + 3; i < 3 * mA - 2; i++)
                        {
                            mat[i - mA, i] = "X";
                            mat[(4 * mA) - i, i] = "X";
                        }

                        count = 4;
                        countxb3 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "c1" && countxc1 == 0 && countoc1 == 0)
                    {
                        //XC1
                        ft.MargEsqu();
                        for (int i = 3; i < mA - 2; i++)
                        {
                            mat[i + 2 * mA, i] = "X";
                            mat[(3 * mA - i), i] = "X";
                        }

                        count = 4;
                        countxc1 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "c2" && countxc2 == 0 && countoc2 == 0)
                    {
                        //XC2
                        ft.MargEsqu();
                        for (int i = mA + 3; i < 2 * mA - 2; i++)
                        {
                            mat[i + mA, i] = "X";
                            mat[(4 * mA) - i, i] = "X";
                        }

                        count = 4;
                        countxc2 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "c3" && countxc3 == 0 && countoc3 == 0)
                    {
                        //XC3
                        ft.MargEsqu();
                        for (int i = 2 * mA + 3; i < 3 * mA - 2; i++)
                        {
                            mat[i, i] = "X";
                            mat[(5 * mA) - i, i] = "X";
                        }

                        count = 4;
                        countxc3 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if(count==3)
                    {
                        ft.MargEsqu();
                        Console.WriteLine("Posição já ocupada ou inexistente");
                        //count = 3;
                    }

                }
                //Condição de jogada para o jogador 2

                else
                {
                    ft.MargEsqu();
                    Console.Write("Jogador 2, suas coordenadas: ");
                    string m = Console.ReadLine().ToLower();
                    // Colocação do 'O' se a posição estiver disponível
                    if (m == "a1" && countxa1 == 0 && countoa1 == 0)
                    {
                        //Oa1
                        ft.MargEsqu();
                        for (int i = 3; i < mA - 2; i++)
                        {
                            mat[3, i] = "O";
                            mat[i, mA - 2] = "O";
                            mat[mA - 2, i] = "O";
                            mat[i, 3] = "O";
                        }

                        count = 3;
                        countoa1 = 1;

                        matriz();

                        Coordenadas();
                    }
                    
                    if (m == "a2" && countxa2 == 0 && countoa2 == 0)
                    {
                        //Oa2
                        ft.MargEsqu();
                        for (int i = mA + 3; i < 2 * mA - 2; i++)
                        {
                            mat[3, i] = "O";
                            mat[i - mA, 2 * mA - 2] = "O";
                            mat[mA - 2, i] = "O";
                            mat[i - mA, mA + 3] = "O";
                        }

                        count = 3;
                        countoa2 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (m == "a3" && countxa3 == 0 && countoa3 == 0)
                    {
                        //Oa3
                        ft.MargEsqu();
                        for (int i = 2 * mA + 3; i < 3 * mA - 2; i++)
                        {
                            mat[3, i] = "O";
                            mat[i - 2 * mA, 3 * mA - 2] = "O";
                            mat[mA - 2, i] = "O";
                            mat[i - 2 * mA, 2 * mA + 3] = "O";
                        }

                        count = 3;
                        countoa3 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (m == "b1" && countxb1 == 0 && countob1 == 0)
                    {
                        //Ob1
                        ft.MargEsqu();
                        for (int i = 3; i < mA - 2; i++)
                        {
                            mat[mA + 3, i] = "O";
                            mat[i + mA, mA - 2] = "O";
                            mat[2 * mA - 2, i] = "O";
                            mat[i + mA, 3] = "O";
                        }

                        count = 3;
                        countob1 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (m == "b2" && countxb2 == 0 && countob2 == 0)
                    {
                        //Ob2
                        ft.MargEsqu();
                        for (int i = mA + 3; i < 2 * mA - 2; i++)
                        {
                            mat[mA + 3, i] = "O";
                            mat[i, 2 * mA - 2] = "O";
                            mat[2 * mA - 2, i] = "O";
                            mat[i, mA + 3] = "O";
                        }

                        count = 3;
                        countob2 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (m == "b3" && countxb3 == 0 && countob3 == 0)
                    {
                        //Ob3
                        ft.MargEsqu();
                        for (int i = 2 * mA + 3; i < 3 * mA - 2; i++)
                        {
                            mat[mA + 3, i] = "O";
                            mat[i - mA, 3 * mA - 2] = "O";
                            mat[2 * mA - 2, i] = "O";
                            mat[i - mA, 2 * mA + 3] = "O";
                        }

                        count = 3;
                        countob3 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (m == "c1" && countxc1 == 0 && countoc1 == 0)
                    {
                        //Oc1
                        ft.MargEsqu();
                        for (int i = 3; i < mA - 2; i++)
                        {
                            mat[2 * mA + 3, i] = "O";
                            mat[i + 2 * mA, mA - 2] = "O";
                            mat[3 * mA - 2, i] = "O";
                            mat[i + 2 * mA, 3] = "O";
                        }

                        count = 3;
                        countoc1 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (m == "c2" && countxc2 == 0 && countoc2 == 0)
                    {
                        //Oc2
                        ft.MargEsqu();
                        for (int i = mA + 3; i < 2 * mA - 2; i++)
                        {
                            mat[2 * mA + 3, i] = "O";
                            mat[i + mA, 2 * mA - 2] = "O";
                            mat[3 * mA - 2, i] = "O";
                            mat[i + mA, mA + 3] = "O";
                        }

                        count = 3;
                        countoc2 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (m == "c3" && countxc3 == 0 && countoc3 == 0)
                    {
                        //Oc3
                        ft.MargEsqu();
                        for (int i = 2 * mA + 3; i < 3 * mA - 2; i++)
                        {
                            mat[2 * mA + 3, i] = "O";
                            mat[i, 3 * mA - 2] = "O";
                            mat[3 * mA - 2, i] = "O";
                            mat[i, 2 * mA + 3] = "O";
                        }

                        count = 3;
                        countoc3 = 1;

                        matriz();

                        Coordenadas();
                    }

                    if (count == 4)
                    {
                        ft.MargEsqu();
                        Console.WriteLine("Posição já ocupada ou inexistente");
                        //count = 4;
                    }

                }
                //Condições de vitoria do jogador 1 (X)
                if ((countxa1 == 1 && countxa2 == 1 && countxa3 == 1) ||
                    (countxb1 == 1 && countxb2 == 1 && countxb3 == 1) ||
                    (countxc1 == 1 && countxc2 == 1 && countxc3 == 1)||
                    (countxa1 == 1 && countxb1 == 1 && countxc1 == 1) ||
                    (countxa2 == 1 && countxb2 == 1 && countxc2 == 1) ||
                    (countxa3 == 1 && countxb3 == 1 && countxc3 == 1) ||
                    (countxa1 == 1 && countxb2 == 1 && countxc3 == 1) ||
                    (countxa3 == 1 && countxb2 == 1 && countxc1 == 1))
                {
                    ft.MargEsqu();
                    Console.WriteLine("Jogador 1 venceu!");
                    countj = 10;
                }

                //Condições de vitoria do jogador 2 (X)
                if ((countoa1 == 1 && countoa2 == 1 && countoa3 == 1) ||
                    (countob1 == 1 && countob2 == 1 && countob3 == 1) ||
                    (countoc1 == 1 && countoc2 == 1 && countoc3 == 1) ||
                    (countoa1 == 1 && countob1 == 1 && countoc1 == 1) ||
                    (countoa2 == 1 && countob2 == 1 && countoc2 == 1) ||
                    (countoa3 == 1 && countob3 == 1 && countoc3 == 1) ||
                    (countoa1 == 1 && countob2 == 1 && countoc3 == 1) ||
                    (countoa3 == 1 && countob2 == 1 && countoc1 == 1))
                {
                    ft.MargEsqu();
                    Console.WriteLine("Jogador 2 venceu!");
                    countj = 10;
                }

                //Condição de empate
                if ((countxa1 == 1 || countoa1 == 1) && (countxa2 == 1 || countoa2 == 1) && (countxa3 == 1 || countoa3 == 1) &&
                   (countxb1 == 1 || countob1 == 1) && (countxb2 == 1 || countob2 == 1) && (countxb3 == 1 || countob3 == 1) &&
                   (countxc1 == 1 || countoc1 == 1) && (countxc2 == 1 || countoc2 == 1) && (countxc3 == 1 || countoc3 == 1))
                {
                    ft.MargEsqu();
                    Console.WriteLine("Empate!");
                    countj = 10;
                }
            }
            ft.MargEsqu();
            Console.WriteLine("Fim de jogo!");

        }
    }
}
