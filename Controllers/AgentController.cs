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
    public class AgentController:ControllerBase
    {
         private readonly applicationDbContext dbContext;
         public AgentController(applicationDbContext dbContext)
         {
             this.dbContext = dbContext;
         }
         [HttpGet]
        public async Task<ActionResult<IEnumerable<Agent>>> GetAgent()
        {
            return await dbContext.Agents.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Agent>> GetPlanning(string id)
        {
            var agent = await dbContext.Agents.FindAsync(id);

            if (agent == null)
            {
                return NotFound();
            }

            return agent;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgent(string id,Agent agent)
        {
            if (id != agent.codePlanning)
            {
                return BadRequest();
            }

            dbContext.Entry(agent).State = EntityState.Modified;

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        [HttpPost]
        public async Task<ActionResult<Planning>> PostAgent(Agent agent)
        {
            dbContext.Agents.Add(agent);
            await dbContext.SaveChangesAsync();
            return Ok(new{ success= "success"});
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Agent>> DeleteAgent(string id)
        {
            var agent = await dbContext.Agents.FindAsync(id);
            if (agent == null)
            {
                return NotFound();
            }

            dbContext.Agents.Remove(agent);
            await dbContext.SaveChangesAsync();

            return agent;
        }       
          private bool AgentExists(string id)
        {
            return dbContext.Agents.Any(e => e.codeAgent == id);
        }
    }
}