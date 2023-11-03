namespace rentify.Models
{
    public class Condo
    {
        public int CondoID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public decimal MonthlyRent { get; set; }
        public bool Available { get; set; }
        public int OwnerID { get; set; }
        public string PaxRange { get; set; }

        // Navigation property for the relationship to CondoDescriptions
        public CondoDescription Description { get; set; }

        // Navigation property for the relationship to CondoPictures
        public List<CondoPicture> Pictures { get; set; }

        // Navigation property for the relationship to Appliances
        public List<Appliance> Appliances { get; set; }

        // Navigation property for the relationship to SocialMedia
        public SocialMedia SocialMedia { get; set; }

        // Navigation property for the relationship to RentalAgreements
        public List<RentalAgreement> RentalAgreements { get; set; }

        // Navigation property for the relationship to Owners
        public Owner Owner { get; set; }
    }
}
