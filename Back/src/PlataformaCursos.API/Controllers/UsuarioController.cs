using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PlataformaCursos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
    
        public UsuarioController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "value";
        }
    }
}
