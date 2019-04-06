using System.Data.Entity;

namespace MVCprueba.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<MVCprueba.Models.Product> Products { get; set; }
    }
}