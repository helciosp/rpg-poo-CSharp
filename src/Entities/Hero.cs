namespace poo.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name;
        }
        public virtual string Attack()
        {
            return $"{this.Name} atacou com a espada";
        }
    }
}