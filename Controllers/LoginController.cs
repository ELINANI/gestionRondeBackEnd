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
    public class LoginController:ControllerBase
    {
        private readonly applicationDbContext dbContext;
        public LoginController(applicationDbContext dbContext)
        {
            this.dbContext =dbContext;
        }
        [HttpGet("{login}/{pwd}")]
        public async Task<ActionResult> GetLogin(string login, string pwd)
        {
           
              var admin = await dbContext.Admins.FindAsync(login);
                
                    if(admin.pawdAdmin == pwd){

                        return Ok( new {welcome ="welcom"});
                        
                    }
                      
                    else
                    {
                         return BadRequest( new {error   = "error"});
                    }
                   
               
            
           
        }
    }
}