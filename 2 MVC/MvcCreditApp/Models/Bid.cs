using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCreditApp.Models
{
    public class Bid
    {

        // ID заявки
        public virtual int BidId { get; set; }

        // Имя заявителя
        [Required]
        [Display (Name = "Имя заявителя")]
        public virtual string Name { get; set; }

        // Название кредита
        [Display(Name = "Название кредита")]
        public virtual string CreditHead { get; set; }

        // Дата подачи заявки
       // [Required]
        [Display(Name = "Дата подачи заявки")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yy}")]
        public virtual DateTime bidDate { get; set; }

    }
}