using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;


namespace BPO.ECM
{

    public class EntityController : Controller {
        public EntityController ()
        {
          
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult GetEntityDefinition()
        {
            return default(IActionResult);
        }




    }
}