﻿//===================
// Full-stack dasturchi (bo'lishini xoxlaganlar uchun)
// Dot-net
//===================


using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult<string> Get() => "Hammasi ishladi raxmat!";

        
    }
}
