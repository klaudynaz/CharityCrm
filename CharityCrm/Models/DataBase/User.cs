using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CharityCrm.Models.DataBase
{
    public class User
    {
        [KeyAttribute]
        public int IdUser { get; set; }
        [RequiredAttribute]
        public string Nickname { get; set; }
        [RequiredAttribute]
        public string Name { get; set; }
        public string Surname { get; set; }
        [EmailAddressAttribute]
        public string Address { get; set; }
        [RequiredAttribute]
        public string Email { get; set; }
        [PhoneAttribute]
        public string PhoneNumber { get; set; }

        public virtual User Superior { get; set; } //Tutaj będzie odnośnik do przełożonego
        public virtual Role Role { get; set; }//Tutaj dodam jeszcze rolę
    }
}