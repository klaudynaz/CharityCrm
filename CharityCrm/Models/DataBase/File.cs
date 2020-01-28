using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class File
    {
        [KeyAttribute]
        public int IdFile { get; set; }
        [RequiredAttribute]
        public string OriginalName { get; set; }
        [RequiredAttribute]
        public string NewName { get; set; }
        [RequiredAttribute]
        public string Path { get; set; }
        [RequiredAttribute]
        public string ObjectId { get; set; }
        [RequiredAttribute]
        public string ObjectType { get; set; }

        public virtual Action Action { get; set; } // IdAction
        public virtual Product Product { get; set; }//IdProduct
        public virtual User User { get; set; }//UserID
    }
}