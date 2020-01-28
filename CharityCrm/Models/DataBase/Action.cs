using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Action
    {
        [KeyAttribute]
        public int IdAction { get; set; }
        [RequiredAttribute]
        public string ActionName { get; set; }
        [RequiredAttribute]
        public DateTime StartDate { get; set; }
        [RequiredAttribute]
        public DateTime FinishDate { get; set; }
        public string ActionDescr { get; set; }
        [RequiredAttribute]
        public string KindOfAction { get; set; }

        public virtual User Leader { get; set; } //Relacja Prowadzacy Akcje

        public virtual List<User> Users { get; set; }  // Lista zaangażowanych w akcje

        public virtual Product Product { get; set; } //Produkt 

        public virtual List<File> Files { get; set; } //Lista plików

    }
}