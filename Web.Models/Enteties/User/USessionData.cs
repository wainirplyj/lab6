using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Models.Enteties.User
{
    public class USessionData
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public DateTime SessionDate { get; set; }
    } 

}
   