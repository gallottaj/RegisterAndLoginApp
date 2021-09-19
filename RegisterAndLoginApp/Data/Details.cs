using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegisterAndLoginApp.Models;

    public class Details : DbContext
    {
        public Details (DbContextOptions<Details> options)
            : base(options)
        {
        }

        public DbSet<RegisterAndLoginApp.Models.UserModel> UserModel { get; set; }
    }
