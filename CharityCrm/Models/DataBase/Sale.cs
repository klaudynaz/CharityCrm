using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Sale
    {
        [KeyAttribute]
        public int IdSale { get; set; }
        [RequiredAttribute]
        public string SaleTitle { get; set; }
        [RequiredAttribute]
        public string SaleContent { get; set; }
        [RequiredAttribute]
        public double SalePrice { get; set; }
        [RequiredAttribute]
        public string Contact { get; set; }


        public virtual List<File> Files { get; set; } //Plik
        public virtual ProductCategory ProductCategory { get; set; }//Kategoria
        public virtual Product Product { get; set; } //Produkt

    }
}