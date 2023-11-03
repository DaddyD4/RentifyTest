namespace rentify.Models
{
    public class CondoPicture
    {
        public int PictureID { get; set; }
        public int CondoID { get; set; }
        public string PictureURL { get; set; }

        // Navigation property for the relationship to Condo
        public Condo Condo { get; set; }
    }

}
