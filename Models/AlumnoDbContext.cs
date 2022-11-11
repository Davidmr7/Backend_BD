using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Backend_BD.Models
{
    public class AlumnoDbContext:DbContext
    {
        private static String connection1 = "DefaultConnection";

        public AlumnoDbContext() : base(connection1)
        {

        }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Maestros> Maestros { get; set; }

    }
}