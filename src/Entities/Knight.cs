using System;

namespace src.Entities
{
    public class Knight : Character
    {
        public Knight(string Name, int Level, string HeroType) 
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
    }
}