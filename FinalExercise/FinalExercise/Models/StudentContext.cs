using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalExercise.Models
{
    public class StudentContext: DbContext
    {
        public DbSet<StudentModels> Students { get; set; }
        public DbSet<SClass> Sc { get; set; }
    }
}