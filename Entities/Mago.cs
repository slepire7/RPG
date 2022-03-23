using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Entities
{
    internal class Mago : Personagem
    {
        public Mago(string Nome, int Level, string Classe, int Vida, int Magia) : base(Nome, Level, $"Mago {Classe}", Vida, Magia)
        {
        }
        public override string Atacar(Personagem alvo)
        {
            return $"{Nome} atacou com magia o {alvo.Nome}";
        }
        public string Atacar(int Bonus, Personagem alvo)
        {
            if (Bonus > Magia)
            {
                return $"{Nome} não possui magia o suficiente para atacar";
            }
            Magia -= Bonus;
            alvo.Vida -= Bonus;
            if (Bonus > 6)
            {
                return $"{Nome} lançou ataque com um bonus +{Bonus} em {alvo.Nome}";
            }

            return $"{Nome} lançou ataque fraco com {Bonus} em {alvo.Nome}";
        }
    }
}
