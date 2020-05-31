using System;
using System.Collections.Generic;
using System.Text;
using Web.BusinessLogic.Core;
using Web.BusinessLogic.Interfaces;

namespace Web.BusinessLogic.LogicBL
{
    class MainBL : UserAPi, IMain
    {
        public void GetTest1()
        {
            Test1();
        }
        public void GetTest2()
        {
            Test2();
        }
    }
}
