using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LoginRegistration.Models
{
    public class Model : DbContext
    {
        public Model()
            : base("Name=UsersEntities")
        {; }

        public DbSet<User> Users { get; set; }
    }
}