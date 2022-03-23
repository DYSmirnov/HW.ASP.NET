using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace FinalExercise.Models
{
    public class SClass
    {
        public virtual int SClassId { get; set; }

        [Required]
        [Display(Name = "Имя Фамилия")]
        public virtual string Name { get; set; }

        [Display(Name = "Название курса")]
        public virtual string CourseName { get; set; }

        [Display(Name = "Оценка")]
        public virtual int Point { get; set; }
    }
}