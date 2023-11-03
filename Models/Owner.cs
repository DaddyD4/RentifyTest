namespace rentify.Models
{
    public class Owner
    {
        public int OwnerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

        // Navigation property for the relationship to Condo
        public List<Condo> Condos { get; set; }
    }

}
