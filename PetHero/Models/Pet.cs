namespace PetHero.Models
{
    public class Pet
    {
        public Pet() { }
        public Pet(Guid id, string name, Guid departmentID, DateTime dateOfJoining) : this()
        {
            ID = id;
            Name = name;
            DepartmentID = departmentID;
            DateOfCreation = dateOfJoining;
        }

        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid DepartmentID { get; set; }
        public DateTime DateOfCreation { get; set; }
        public Tutor Tutor { get; set; }
    }
}
