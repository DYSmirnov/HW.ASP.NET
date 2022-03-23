
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FinalExercise.Models
{
    public class StudentModels
    {
        public virtual int StudentModelsId { get; set; }

        [Required]
        [Display(Name = "Имя")]
        public virtual string FirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public virtual string LastName { get; set; }

        
        [Display(Name = "Название курса")]
        public virtual string CourseName { get; set; }

        
        [Display(Name = "28.02.2022")]
        public virtual int point1 { get; set; }

        [Display(Name = "03.03.2022")]
        public virtual int point2 { get; set; }

        [Display(Name = "10.03.2022")]
        public virtual int point3 { get; set; }

        [Display(Name = "11.03.2022")]
        public virtual int point4 { get; set; }

        [Display(Name = "14.03.2022")]
        public virtual int point5 { get; set; }

        [Display(Name = "15.03.2022")]
        public virtual int point6 { get; set; }

        [Display(Name = "17.03.2022")]
        public virtual int point7 { get; set; }

        [Display(Name = "18.03.2022")]
        public virtual int point8 { get; set; }

        [Display(Name = "21.03.2022")]
        public virtual int point9 { get; set; }

        [Display(Name = "22.03.2022")]
        public virtual int point10 { get; set; }
        


        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public int PointSum()
        {
            int sum = point1 + point2 + point3 + point4 + point5 + point6 + point7 + point8 + point9 + point10;
            return sum;
                
        }
    }
}