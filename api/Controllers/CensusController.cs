using System.Collections.Generic;
using System.Threading.Tasks;
using api.Models;
using api.Persistence;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("/[controller]")]
    public class CensusController: Controller
    {
        private readonly CensusDbContext context;
        private readonly IMapper mapper;

        public CensusController(CensusDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetCensusEntriesAll()
        { 
            var censusEntries = await context.CensusEntries.Include(c => c.Bunny).ToListAsync();
            
            return Ok(censusEntries);
        }
        
        [HttpGet("{id}", Name = "GetBunny")]
        public async Task<IActionResult> GetBunnyById(int id)
        {
            var bunny = await context.Bunny.FindAsync(id);
            
            return Ok(bunny);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]Bunny bunny)
        {
            context.Bunny.Add(bunny);
            await context.SaveChangesAsync();
            var bunnyUri = Url.Link("GetBunny", new {id = bunny.Id});
            
            return Created(bunnyUri, bunny);
        }
    }
}