using Demo_Company_API.Data;
using Demo_Company_API.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo_Company_API.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    public class EmployeeController : ControllerBase   //ControllerBase
    {
        private readonly AgentsAPIDbContext dbContext;

        public EmployeeController(AgentsAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAgents()
        {
            return Ok(await dbContext.Agents.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> PostAgents(AddAgentRequest addAgentRequest)
        {
            var agent = new Agent()
            {
                AGENT_CODE = addAgentRequest.AGENT_CODE,
                AGENT_NAME = addAgentRequest.AGENT_NAME,
                WORKING_AREA = addAgentRequest.WORKING_AREA,
                COMMISSION = addAgentRequest.COMMISSION,
                PHONE_NO = addAgentRequest.PHONE_NO,
                COUNTRY = addAgentRequest.COUNTRY,
            };
            await dbContext.Agents.AddAsync(agent);
            await dbContext.SaveChangesAsync();

            return Ok(agent);
        }

        //[HttpPut]
        //[Route("{AGENT_CODE:string}")]
        //public async Task<IActionResult> UpdateAgent([FromRoute] string AGENT_CODE, UpdateAgentRequest updateAgentRequest)
        //{
        //    var agent = await dbContext.Agents.FindAsync();

        //    if (agent == null)
        //    {
        //        agent.AGENT_NAME = updateAgentRequest.AGENT_NAME;
        //        agent.WORKING_AREA = updateAgentRequest.WORKING_AREA;
        //        agent.COMMISSION = updateAgentRequest.COMMISSION;
        //        agent.PHONE_NO = updateAgentRequest.PHONE_NO;
        //        agent.COUNTRY = updateAgentRequest.COUNTRY;

        //        await dbContext.SaveChangesAsync();

        //        return Ok(agent);
        //    }

        //    return NotFound();
        //}
    }
}
