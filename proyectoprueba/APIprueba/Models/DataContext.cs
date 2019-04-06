using System.Data.Entity;

namespace APIprueba.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
                
        }

        public System.Data.Entity.DbSet<APIprueba.Models.Product> Products { get; set; }
    }
}