using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Registration
    {
        [KeyAttribute]
        public int IdRegistr { get; set; }
        [RequiredAttribute]
        public DateTime Created { get; set; }
        [RequiredAttribute]
        public DateTime Saved { get; set; }
        [RequiredAttribute]
        public DateTime SendExport { get; set; }

        public virtual DocumentTemplate DocumentTemplate { get; set; }//DokumentTemplate
        public virtual User User { get; set; }//User

    }
}