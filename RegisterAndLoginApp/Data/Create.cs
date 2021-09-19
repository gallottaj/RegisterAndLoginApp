using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RegisterAndLoginApp.Models;

    public class Create : DbContext
    {
        public Create (DbContextOptions<Create> options)
            : base(options)
        {
        }

        public DbSet<RegisterAndLoginApp.Models.UserModel> UserModel { get; set; }
    }
