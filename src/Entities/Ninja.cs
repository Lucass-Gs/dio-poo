namespace dotnet_poo.src.Entities
{
      public class Ninja : Hero
      {
            public Ninja(string Name, int Level, string HeroType)
            {
                  this.Name = Name;
                  this.Level = Level;
                  this.HeroType = HeroType;
            }

            public override string Attack()
            {
                  return this.Name + " Atacou com a adaga";
            }
            public string Attack(int Bonus)
            {
                  if (Bonus > 6)
                  {
                        return this.Name + " Deu um ataque perfurante com bonus de " + Bonus;
                  }
                  else
                  {
                        return this.Name + " Deu um ataque fraco com bonus de " + Bonus;
                  }
            }
      }
}