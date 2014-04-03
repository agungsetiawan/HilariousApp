using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilariousApp.DA
{
    public class MyContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}
