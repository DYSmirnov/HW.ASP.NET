using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalExercise.Models
{
    //public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
    public class StudentDbInitializer : DropCreateDatabaseIfModelChanges<StudentContext>
    {

        protected override void Seed(StudentContext context)
        {
            context.ss.Add(new s { FirstName = "ss", LastName = "ss", p = new List<int> { 97, 92, 81, 60 } });
        //    context.Students.Add(new StudentModels { FirstName = "Name2", LastName = "LName2"});
           
        //    context.Courses.Add(new CourseModels { course = "ADO/ASP" });

            

            base.Seed(context);
        }
    }
}