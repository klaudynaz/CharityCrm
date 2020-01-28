using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Quest

    {
        [KeyAttribute]
        public int IdQuest { get; set; }
        [RequiredAttribute]
        public string QuestName { get; set; }
        [RequiredAttribute]
        public string DescQuest { get; set; }
        [RequiredAttribute]
        public string Status { get; set; }
        [RequiredAttribute]
        public DateTime CreatDate { get; set; }
        [RequiredAttribute]
        public DateTime FinishDate { get; set; }

        public virtual User Owner { get; set; }//PracownikProwadzacy
        public virtual List<User> People { get; set; } //Osoby powiązane
        public virtual User Author { get; set; }//TwórcaId
    }
}