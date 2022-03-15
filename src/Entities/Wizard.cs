using System;
namespace src.Entities
{
    public class Wizard : Character
    {
        public Wizard(string Name, int Level, string HeroType) {
            this.Name = Name; 
            this.Level = Level; 
            this.HeroType = HeroType;
        }
        public override void Attack()
        {
            Console.WriteLine($"{this.Name} Lançou magia");
        }

        public void Attack(int bonus) {
            Console.WriteLine($"{this.Name} Lançou magia com bonus de ataque de {bonus}");
        }
    }
}