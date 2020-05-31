using System;
using System.Collections.Generic;
using System.Text;
using Web.BusinessLogic.Core;
using Web.BusinessLogic.Interfaces;
using Web.Models.Enteties.General;
using Web.Models.Enteties.User;

namespace Web.BusinessLogic.LogicBL
{
    class SessionBL : UserAPi, ISession
    {
        public ResponseMsg GetUserSession(USessionData udata)
        {
            return UserSession(udata);
        }
        public void GetTest1()
        {
            Test1();
        }
    }
}
