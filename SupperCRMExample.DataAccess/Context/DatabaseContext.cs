using Microsoft.EntityFrameworkCore;
using SupperCRMExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SupperCRMExample.DataAccess.Context
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        

    }
}
