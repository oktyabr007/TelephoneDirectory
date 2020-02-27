using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace TelephoneDirectory.Models
{
    class TelephoneDirectoryDBContext: DbContext
    {
        public DbSet<MobilePhone> MobilePhones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
