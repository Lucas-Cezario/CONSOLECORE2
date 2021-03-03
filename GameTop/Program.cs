using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jogo = new JogoFODA(
            new Jogador1(),new Jogador2());
            
             Jogo.IniciarJogo();
        }
    }
}
