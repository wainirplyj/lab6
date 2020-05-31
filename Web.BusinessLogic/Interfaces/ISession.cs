using System;
using System.Collections.Generic;
using System.Text;
using Web.Models.Enteties.General;
using Web.Models.Enteties.User;

namespace Web.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ResponseMsg GetUserSession(USessionData udata);
        void GetTest1();
    }
}
