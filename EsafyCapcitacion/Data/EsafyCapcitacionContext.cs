using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EsafyCapcitacion.Models;

namespace EsafyCapcitacion.Models
{
    public class EsafyCapcitacionContext : DbContext
    {
        public EsafyCapcitacionContext (DbContextOptions<EsafyCapcitacionContext> options)
            : base(options)
        {
        }

        public DbSet<EsafyCapcitacion.Models.CapacitationClass> CapacitationClass { get; set; }

        public DbSet<EsafyCapcitacion.Models.CapacitationPlan> CapacitationPlan { get; set; }

        public DbSet<EsafyCapcitacion.Models.Company> Company { get; set; }

        public DbSet<EsafyCapcitacion.Models.Course> Course { get; set; }

        public DbSet<EsafyCapcitacion.Models.Student> Student { get; set; }

        public DbSet<EsafyCapcitacion.Models.Vertical> Vertical { get; set; }

        public DbSet<EsafyCapcitacion.Models.CourseTest> CourseTest { get; set; }

        public DbSet<EsafyCapcitacion.Models.TestQuestion> TestQuestion { get; set; }

        public DbSet<EsafyCapcitacion.Models.QuestionOption> QuestionOption { get; set; }

        public DbSet<EsafyCapcitacion.Models.Answer> Answer { get; set; }

        public DbSet<EsafyCapcitacion.Models.Examination> Examination { get; set; }
    }
}
