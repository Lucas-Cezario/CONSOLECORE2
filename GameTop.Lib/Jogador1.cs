using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador1 : iJogador
    {
        public string Corre()
        {
            return "Pelé está correndo\n";
        }
        public string Chuta()
        {
            return "Pelé está chutando\n";
        }
        public string Passe()
        {

            return "Pelé está Passando\n";
        }
    }
}