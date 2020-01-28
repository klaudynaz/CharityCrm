using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class ProductCategory
    {
        [KeyAttribute]
        public int IdCategory { get; set; }
        [RequiredAttribute]
        public string CategoryName { get; set; }
    }
}