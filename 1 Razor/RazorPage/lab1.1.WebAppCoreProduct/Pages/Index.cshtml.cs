using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab1._1.WebAppCoreProduct.Models;


namespace lab1._1.WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {

            //public bool IsCorrect { get; set; } = true;
            //public Product Product { get; set; }
            //public string MessageRezult;


        ////Get
        public void OnGet()
        {
            //    MessageRezult = "Для товара можно определить скидку";
            //    //Product = new Product();
            //    //if (price == null || price < 0 || string.IsNullOrEmpty(name))
            //    //{
            //    //    IsCorrect = false;
            //    //    return;
            //    //}

            //    //Product.Price = price;
            //    //Product.Name = name;

            //    //var result = price * (decimal?)0.18;
            //    //MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
            }


            ////Post
            //public void OnPost(string name, decimal? price)
            //{
            //    Product = new Product();
            //    if (price == null || price < 0 || string.IsNullOrEmpty(name))
            //    {
            //        IsCorrect = false;
            //        return;
            //    }

            //    Product.Price = price;
            //    Product.Name = name;

            //    var result = price * (decimal?)0.18;
            //    MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
            //}
        }
}
