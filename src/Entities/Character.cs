using System;

namespace src.Entities
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Character(string Name, int Level, string HeroType) 
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public Character() {}

        public override string ToString()
        {
            return $"Name: {this.Name}\nLevel: {this.Level}\nHeroType: {this.HeroType}";
        }

        public virtual void Attack() {
            Console.WriteLine($"{this.Name} Atacou com a espada");
        }
    }
}