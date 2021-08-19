using System;

namespace JogoDaVelha1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamando as classes
            Tabuleiro tab = new Tabuleiro();
            Pecas pecas = new Pecas();
            Formatacao ft = new Formatacao();

            Console.WriteLine();
            ft.MargEsqu();
            Console.WriteLine("Olá! Seja bem-vindo ao Jogo da Velha");
            ft.MargEsqu();
            Console.WriteLine("Por favor, entre com as coordenadas para primeira jogada");
            Console.WriteLine();

            string opcao = "";
            while(opcao!="n")
            {
                //Desenhando o Tabuleiro
                tab.Painel();

                ft.MargEsqu();
                Console.WriteLine("Outra partida? Digite qualquer tecla, se quiser encerrar digite 'n'");
                ft.MargEsqu();
                opcao = Console.ReadLine().ToLower();
                Console.Clear();
            }
            

                        
            
            
        }
    }
}
