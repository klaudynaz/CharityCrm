using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Role

    {
        [KeyAttribute]
        public int IdRole { get; set; }
        [RequiredAttribute]
        public String RoleName { get; set; }
    }
}