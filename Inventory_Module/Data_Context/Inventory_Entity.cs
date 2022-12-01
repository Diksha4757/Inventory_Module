using Microsoft.EntityFrameworkCore;
using Inventory_Module.Models;

namespace Inventory_Module.Data_Context
{
    public class Inventory_Entity:DbContext
    {
        public Inventory_Entity(DbContextOptions<Inventory_Entity>x):base(x)
        {

        }
       public  DbSet<Client_Info> Client_tbl { get; set; }
        public DbSet<Log_maintain_class> Log_Maintain_tbl { get; set; }
    }
}
