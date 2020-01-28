using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class RodoProposal

    {
        [KeyAttribute]
        public int IdProposal { get; set; }
        [RequiredAttribute]
        public string ProposalName { get; set; }
        [RequiredAttribute]
        public string Content { get; set; }
        [RequiredAttribute]
        public string KindOfLaw { get; set; }
        [RequiredAttribute]
        public string Reply { get; set; }
        [RequiredAttribute]
        public bool CopyOfData { get; set; }
        [RequiredAttribute]
        public DateTime CreatedDate { get; set; }

        public virtual User ResponsiblePerson { get; set; }//Osoba odpowiedzialna
        public virtual User Declarant { get; set; }//User


    }
}