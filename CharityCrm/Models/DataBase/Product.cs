using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Product
    {
        [KeyAttribute]
        public int IdProduct { get; set; }
        [RequiredAttribute]
        public string ProductName { get; set; }
        [RequiredAttribute]
        public string ProductDesc { get; set; }
        [RequiredAttribute]
        public double Price { get; set; }

    }
}