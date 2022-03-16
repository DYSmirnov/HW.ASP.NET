using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using lab1._1.WebAppCoreProduct.Models;

namespace lab1._1.WebAppCoreProduct.Pages
{
    public class ProductModel : PageModel
    {
        public Product Product { get; set; }
        public string MessageRezult;

        //Get
        public void OnGet()
        {
            MessageRezult = "��� ������ ����� ���������� ������";
        }


        //Post
        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "������� ������������ ��������";
            }

            Product.Price = price;
            Product.Name = name;

            var result = price * (decimal?)0.18;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
        }

        //Post Discout
        public void OnPostDiscont(string name, decimal? price, double discont) 
        {
            Product = new Product();
            if (price == null || price < 0 || string.IsNullOrEmpty(name))
            {
                MessageRezult = "������� ������������ ��������";
            }

            var result = price - price * (decimal?)discont/100;
            MessageRezult = $"��� ������ {name} � ����� {price} � ������� {discont} �������� ��������� ��������� {result}";

            Product.Price = price;
            Product.Name = name;
        }

        ///Post Multi
        public void OnPostMulti(string name, decimal? price, double discont, int piece)
        {
            Product = new Product();
            var discResult = piece *(price - price * (decimal?)discont / 100);
            var result = piece * price;
            MessageRezult = $"����� {name} � ����� {price} ����� ������ {result} �� {piece} ��. " +
                $"���� {name} � ������ ������ � {discont}% �������� {discResult}";

        }
    }
}
