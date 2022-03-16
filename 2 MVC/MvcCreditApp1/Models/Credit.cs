using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcCreditApp1.Models
{
    public class Credit
    {
        
        // ID кредита
        public virtual int CreditId { get; set; }

        // Название
        [Required]
        [DisplayName("Название")]
        public virtual string Head { get; set; }

        // Период, на который выдается 
        [DisplayName("Период")]
        public virtual int Period { get; set; }

        // Максимальная сумма кредита
        [Required]
        [DisplayName("Максимальная сумма кредита")]
        public virtual int Sum { get; set; }

        // Процентная ставка
        [Required]
        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }


    }
}