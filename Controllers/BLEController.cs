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
    public class BLEController:ControllerBase
    {
        private readonly applicationDbContext dbContext;
        public BLEController( applicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BLE>>> GetBLE()
        {
            return await dbContext.BLEs.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<BLE>> PostBLE(BLE ble)
        {
            dbContext.BLEs.Add(ble);
            await dbContext.SaveChangesAsync();
            return Ok(new{ success= "success"});
        }
    }
}