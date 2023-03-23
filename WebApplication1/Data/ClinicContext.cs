using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ClinicContext:DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors{ get; set; }

        //public DbSet<Appointment> Appointments { get; set; }

        public static ClinicContext context;
        public static ClinicContext getInstance()
        {
            if (context == null)
                context = Instantiate_ClinicContext();
            return context;
        }
        private ClinicContext(DbContextOptions o) : base(o)
            {

            }
        private static ClinicContext Instantiate_ClinicContext()
            {
                var optionsBuilder = new DbContextOptionsBuilder<ClinicContext>();
                optionsBuilder.UseSqlite(@"Data Source=C:\Users\Eya Ridene\Desktop\sqlite.db");
                return new ClinicContext(optionsBuilder.Options);

            }
        
    }
}