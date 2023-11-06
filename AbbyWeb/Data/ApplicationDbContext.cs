﻿using AbbyWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base (option)
        {

        }
        public DbSet<RazorCategory> RazorCategory { get; set; }
    }
}
