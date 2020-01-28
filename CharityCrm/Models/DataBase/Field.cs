using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Field
    {
        [KeyAttribute]
        public int IdField { get; set; }
        [RequiredAttribute]
        public string FieldName { get; set; }
        [RequiredAttribute]
        public string FieldContent { get; set; }
    }
}