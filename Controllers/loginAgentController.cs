using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gestionRondeBackEnd.models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;
namespace gestionRondeBackEnd.Controllers
{
    [Route("api/[controller]")]
      [ApiController]
      [EnableCors("corsPolicy")]  
    public class loginAgentController:ControllerBase
    {
         private readonly applicationDbContext applicationDbContext;
         public loginAgentController(applicationDbContext applicationDbContext)
         {
             this.applicationDbContext = applicationDbContext;
         }
         [HttpGet("{login}/{pwd}")]
         public async Task<ActionResult<IEnumerable<Planning>>> getAgent(string login ,string pwd){
             var Agent = await applicationDbContext.Agents.FindAsync(login);
                
                    if(Agent.pawdAgent == pwd){
                         
                         var planning = from s in applicationDbContext.Plannings
                                       where s.codePlanning == Agent.codePlanning
                                       select s;

                        return Ok(planning);
                        
                    }
                      
                    else
                    {
                         return BadRequest( new {error   = "error"});
                    }
        


         }
    }
}