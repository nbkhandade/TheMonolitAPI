using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TheMonolit.API.Data;
using TheMonolit.API.Models;

namespace TheMonolit.API.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class FundDataController : ControllerBase
    {
         private readonly DataContext _context;
        public FundDataController(DataContext context)
        {
            this._context = context;

        }

        // GET api/values
        [HttpGet]
        //public async Task<IActionResult> GetValues()
        public  IActionResult GetValues()
        {
            //var values = await _context.FundDataValues.ToListAsync();
            //return Ok(values);
            var values =  JsonConvert.DeserializeObject<IList<FundDataValue>>(  System.IO.File.ReadAllText("Data/FundData.js"));
            //return  Ok(JObject.Parse(System.IO.File.ReadAllText("Data/FundData.json")));
            return  Ok(values);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.FundDataValues.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}