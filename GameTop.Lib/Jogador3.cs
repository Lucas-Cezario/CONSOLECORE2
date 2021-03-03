using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste Chuta\n";
        }

        public string Corre()
        {
            return "teste corre\n";
        }

        public string Passe()
        {
            return "teste passe\n";
        }
    }
}