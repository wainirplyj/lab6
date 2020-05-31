using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.BusinessLogic.Core;
using Web.BusinessLogic.Interfaces;
using Web.Models.Enteties.General;
using Web.Models.Enteties.User;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        public readonly ISession _session;
        public readonly IMain _main;
        public LoginController()
        {
            var bl = new Web.BusinessLogic.BusinessLogic();
            _session = bl.GetSessionBL();
            _main = bl.GetMainBL();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(ULoginData data)
        {
            USessionData udata = new USessionData
            {
                UserName = data.UserName,
                UserPassword = data.UserPassword,
                SessionDate = DateTime.Now
            };

            _session.GetTest1();


            ResponseMsg st = _session.GetUserSession(udata);
            if (st.Status)
            {
                //COOKIES
            }
            else
            {
                string error = st.Error;

            }
            return View();
        }
    }
}