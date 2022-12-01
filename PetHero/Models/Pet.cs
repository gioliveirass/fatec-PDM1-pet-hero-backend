namespace PetHero.Models
{
    public class Pet
    {
        protected Pet() { }
        public Pet(Guid id, string name) : this()
        {
            ID = id;
            Name = name;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
    }
}
