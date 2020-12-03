using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RsoSem1.Controllers
{
    public class TestController : Controller
    {
        // GET: /Test/
        public string Index()
        {
            return "Hi i am online.";
        }
    }
}