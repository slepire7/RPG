using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace RPG.Entities
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int Level { get; set; }
        public string Classe { get; set; }
        public int Vida { get; set; }
        public int Magia { get; set; }
        public Personagem(string Nome, int Level, string Classe, int Vida, int Magia)
        {
            this.Nome = Nome;
            this.Level = Level;
            this.Classe = Classe;
            this.Vida = Vida;
            this.Magia = Magia;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} Level: {Level} Classe: {Classe} Vida: {Vida} Magia: {Magia}";
        }
        public virtual string Atacar(Personagem alvo)
        {
            return $"{Nome} atacou {alvo.Nome}";
        }

    }
}
