namespace PetHero.Models
{
    public class Tutor
    {
        protected Tutor() => Pets = new List<Pet>();
        public Tutor(Guid id, string name) : this()
        {
            ID = id;
            Name = name;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
