using projeto_rpg_bootcamp.Entities;

namespace projeto_rpg_bootcamp.src.Entities
{
    public class Darkness : Hero
    {
         public Darkness(string Name, int Level, string HeroType) : base (Name, Level, HeroType)
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
            return this.Name + " " + "Lançou Magia super efetiva com bônus de" + " " + Bonus;
        }
        else
        {
            return this.Name + " " + "Lançou uma magia de pouca amplitude com bônus de" + " " + Bonus;
        }
    }
}
}