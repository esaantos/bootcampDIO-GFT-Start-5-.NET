namespace desafio2.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name+ " também lança magia.";
        }
        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva, com bonus de "+ Bonus;
            }
            else
            {
                return this.Name + " lançou magia com força fraca, com bonus de "+ Bonus;
            }
            
        }
    }
}