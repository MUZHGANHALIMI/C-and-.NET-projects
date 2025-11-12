using System.Data.Entity;

namespace CarInsurance.Models
{
    public partial class InsuranceEntities : DbContext
    {
        public InsuranceEntities()
            : base("name=InsuranceEntities")
        {
        }

        public virtual DbSet<Insuree> Insurees { get; set; }
    }
}
