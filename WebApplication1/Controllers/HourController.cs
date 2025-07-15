using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models.Request;
using WebApplication1.Response;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HourContoller : Controller
    {
        private readonly IHourService _hourServis;

        public HourContoller (IHourService hourServis)
        {
            _hourServis = hourServis;
        }

        [HttpPost]
        public async Task<IActionResult> CreateHour([FromBody] HourRequest hour)
        {
            
            
            if (hour == null)
            {
                return BadRequest("Hour is null");
            }
            await _hourServis.CreateHour(hour);
            return Ok();
        }
        [HttpPatch("{id:int}")]
        public async Task<ActionResult<HourDto>> UpdateHour(int id , float hour , DateTime date)
        {
   
            if (hour == null)
            {
                return BadRequest("Not found");
            }
            await _hourServis.UpdateHour(id, hour, date);

            return Ok();
            

        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteHour(int id , DateTime date)
        {
           
            if (id == 0)
            {
                return BadRequest("Not found");
            }
            await _hourServis.DeleteHour(id, date);
            return Ok();
        }



    }








}
