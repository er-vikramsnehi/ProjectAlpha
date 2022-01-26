using Microsoft.EntityFrameworkCore;
using ProjectAlpha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAlpha.Context
{
    public class DBContextClass : DbContext
    {
        public DBContextClass(DbContextOptions<DBContextClass> options) : base(options)
        {

        }


        public DbSet<UsersTable> UsersTables { get; set; }


    }
}
