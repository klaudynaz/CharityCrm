using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class Message
    {
        [KeyAttribute]
        public int IdMessage { get; set; }
        [RequiredAttribute]
        public string TitleMessage { get; set; }
        [RequiredAttribute]
        public string ContentMessage { get; set; }
        [RequiredAttribute]
        public DateTime SendTime { get; set; }
        [RequiredAttribute]
        public DateTime ReadTime { get; set; }

        public virtual User Recipient { get; set; }//Odbiorca Id
        public virtual User Sender { get; set; }//Nadawca Id
        //Nadawca Nazwa
    }
}