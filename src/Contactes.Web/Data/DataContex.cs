using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contactes.Web.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contactes.Web.Models
{
    public class DataContex : IdentityDbContext<AppUser>
    {
        public DataContex(DbContextOptions<DataContex> options)
            : base(options)
        {
        }

        public DbSet<Persona>  Personas { get; set; }

        public DbSet<Tipo> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
