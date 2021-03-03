using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : iJogador
    {
        public readonly string _Nome;

        public Jogador2(string nome = "Shevchenko")
        {
            _Nome = nome;
        }
          public string Chuta()
          {
              return $"{_Nome} Is kicking\n";
          }                  

          public string Passe()
          {
              return $"{_Nome} Is passing by\n";

          }          


          public string Corre()
          {
              return $"{_Nome} Is running\n";

          }                  
    }
}