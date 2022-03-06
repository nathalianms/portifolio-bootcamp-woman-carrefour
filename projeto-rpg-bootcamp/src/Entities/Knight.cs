using projeto_rpg_bootcamp.Entities;

namespace projeto_rpg_bootcamp.src.Entities
{
    public class Knight : Hero 
    {
       public Knight(string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType; 
        }
         public override string Attack()
        {
            return this.Name + " " + "Lançou sua magia";
        }
        public string Attack(int Bonus){

        if (Bonus > 10)
        {
            return this.Name + " " + "que está no level" + " " + this.Level + " " + "e é um" + " " + this.HeroType + " " + "lançou uma magia muito poderosa e com um bônus de" + " " + Bonus;
        }
        else
        {
            return this.Name + " " + "que está no level" + " " + this.Level + " " + "e é um" + " " + this.HeroType + " " + "lançou uma magia de pouca potência com bônus de" + " " + Bonus;
        }
    }
}
}