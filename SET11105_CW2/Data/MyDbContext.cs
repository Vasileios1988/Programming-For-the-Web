using System;
using Microsoft.EntityFrameworkCore;
using SET11105_CW2.Models;

namespace SET11105_CW2.Data
{
    public class MyDbContext : DbContext
    {
       
        //create the DB context class
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Member> member { get; set; }

        public DbSet<Cause> cause { get; set; }


    }
}
