using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class DocumentTemplate

    {
        [KeyAttribute]
        public int IdDocument { get; set; }
        [RequiredAttribute]
        public string DocTitle { get; set; }
        [RequiredAttribute]
        public string DocContent { get; set; }
        public virtual List<Field> Fields { get; set; } //Pola (FK)

    }
}