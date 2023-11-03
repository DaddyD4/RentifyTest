namespace rentify.Models
{
    public class Appliance
    {
        public int ApplianceID { get; set; }
        public string ApplianceName { get; set; }
        public int CondoID { get; set; }

        // Navigation property for the relationship to Condo
        public Condo Condo { get; set; }
    }

}
