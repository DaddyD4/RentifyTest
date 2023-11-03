namespace rentify.Models
{
    public class SocialMedia
    {
        public int SocialMediaID { get; set; }
        public int CondoID { get; set; }
        public string ViberAccount { get; set; }
        public string FacebookPage { get; set; }

        // Navigation property for the relationship to Condo
        public Condo Condo { get; set; }
    }

}
