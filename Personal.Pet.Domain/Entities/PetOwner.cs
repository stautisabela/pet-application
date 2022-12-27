namespace Personal.Pet.Domain.Entities
{
    public class PetOwner
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public List<Pet> Pets { get; set; }

        public PetOwner(string name, string email, string phoneNo, string address)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            PhoneNo = phoneNo;
            Address = address;
            Pets = new List<Pet>();
        }
    }
}
