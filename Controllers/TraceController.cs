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
          public class TraceController:ControllerBase
    {
        private readonly applicationDbContext dbContext;
        public TraceController( applicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trace>>> GetTrace()
        {
            return await dbContext.Traces.ToListAsync();
        }
         [HttpPost]
        public async Task<ActionResult<Trace>> PostTrace(Trace trc)
        {
            dbContext.Traces.Add(trc);
            await dbContext.SaveChangesAsync();
            return Ok(new{ success= "success"});
        }
          [HttpDelete("{id}")]
        public async Task<ActionResult<Trace>> DeleteAgent(string id)
        {
            var trace = await dbContext.Traces.FindAsync(id);
            if (trace == null)
            {
                return NotFound();
            }

            dbContext.Traces.Remove(trace);
            await dbContext.SaveChangesAsync();

            return trace;
        } 
    }
}