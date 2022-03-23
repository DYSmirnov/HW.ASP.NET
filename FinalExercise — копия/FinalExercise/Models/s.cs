using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace FinalExercise.Models
{
    public class s
    {
        


        
            public virtual int SId { get; set; }

            [Required]
            [Display(Name = "Имя")]
            public virtual string FirstName { get; set; }

            [Required]
            [Display(Name = "Фамилия")]
            public virtual string LastName { get; set; }


            [Display(Name = "Название курса")]
            public virtual string CourseName { get; set; }


            
            public virtual List<int> p { get; set; }




            public override string ToString()
            {
                return FirstName + " " + LastName;
            }

        }
    }

