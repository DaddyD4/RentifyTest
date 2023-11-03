namespace rentify.Models
{
    public class CondoDescription
    {
        public int CondoID { get; set; }
        public string Description { get; set; }

        // Navigation property for the relationship to Condo
        public Condo Condo { get; set; }
    }

}
