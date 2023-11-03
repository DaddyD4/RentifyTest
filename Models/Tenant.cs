namespace rentify.Models
{
    public class Tenant
    {
        public int TenantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime MoveOutDate { get; set; }
        public bool IsActive { get; set; }

        // Navigation property for the relationship to RentalAgreements
        public List<RentalAgreement> RentalAgreements { get; set; }
    }

}
