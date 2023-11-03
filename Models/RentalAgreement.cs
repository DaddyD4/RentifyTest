namespace rentify.Models
{
    public class RentalAgreement
    {
        public int AgreementID { get; set; }
        public int CondoID { get; set; }
        public int TenantID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RentAmount { get; set; }
        public bool IsTerminated { get; set; }

        // Navigation property for the relationship to Condo
        public Condo Condo { get; set; }

        // Navigation property for the relationship to Tenant
        public Tenant Tenant { get; set; }
    }

}
