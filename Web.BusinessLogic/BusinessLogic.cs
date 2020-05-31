using System;
using Web.BusinessLogic.Interfaces;
using Web.BusinessLogic.LogicBL;
using System.Collections.Generic;
using System.Text;

namespace Web.BusinessLogic
{
    public class BusinessLogic
    {
        public ISession GetSessionBL()
        {
            return new SessionBL();
        }

        public IMain GetMainBL()
        {
            return new MainBL();
        }
    }
}
