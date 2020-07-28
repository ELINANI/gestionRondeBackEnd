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
        public class planningController:ControllerBase
    {
        
        private readonly applicationDbContext dbContext;
        public planningController( applicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // GET: api/planning
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Planning>>> GetPlanning()
        {
            List<Planning> pln ;
                pln = await dbContext.Plannings.ToListAsync();

            return pln;
        }
        // GET: api/planning/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Planning>> GetPlanning(string id)
        {
            var pln = await dbContext.Plannings.FindAsync(id);

            if (pln == null)
            {
                return NotFound();
            }

            return pln;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(string id,Planning pln)
        {
            if (id != pln.codePlanning)
            {
                return BadRequest();
            }

            dbContext.Entry(pln).State = EntityState.Modified;

            try
            {
                await dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanningExists(id))
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
        public async Task<ActionResult<Planning>> PostClient(Planning pln)
        {
            dbContext.Plannings.Add(pln);
            await dbContext.SaveChangesAsync();
            return Ok(new{ success= "success"});
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Planning>> DeleteClient(string id)
        {
            var pln = await dbContext.Plannings.FindAsync(id);
            if (pln == null)
            {
                return NotFound();
            }

            dbContext.Plannings.Remove(pln);
            await dbContext.SaveChangesAsync();

            return pln;
        }       
         private bool PlanningExists(string id)
        {
            return dbContext.Plannings.Any(e => e.codePlanning == id);
        }

    }
}