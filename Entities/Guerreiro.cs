using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro(string Nome, int Level, string Classe, int Vida, int Magia) : base(Nome, Level, $"Guerreiro {Classe}", Vida, Magia)
        {
        }
        public override string Atacar(Personagem alvo)
        {
            return $"{Nome} atacou com sua espada o {alvo.Nome}";
        }
        public string Atacar(int Bonus, Personagem alvo)
        {
            alvo.Vida -= Bonus;
            if (Bonus > 6)
            {
                return $"{Nome} lançou ataque com um bonus +{Bonus} em {alvo.Nome}";
            }

            return $"{Nome} lançou ataque fraco com {Bonus} em {alvo.Nome}";
        }
    }
}
