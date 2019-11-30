using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab6.Models
{
    public class Context : DbContext
    {
        public Context() : base("name=HospitalContext") { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
    }
}