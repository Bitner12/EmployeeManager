using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using WebApplication1.Data;
using WebApplication1.Enties;
using WebApplication1.Models.Request;
using WebApplication1.Repositories;
using WebApplication1.Response;
using WebApplication1.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkerController : Controller
    {

        private readonly IWorkerService _workerService;
        public WorkerController(IWorkerService workerService)
        {
            _workerService = workerService;
        }



        [HttpPost]
        public async Task<IActionResult> Creat([FromBody] WorkerRequest worker)
        {
            await _workerService.CreatWorker(worker);
            if (string.IsNullOrWhiteSpace(worker.Name))
            {
                return BadRequest("Имя не может быть пустым");
            }

            if (worker.CostPerHour <= 0)
            {
                return BadRequest("Недопустимая стоимость за час.");
            }
            if (worker == null)
            {
                return BadRequest("Worker is null");
            }

            return Ok();
        }

        [HttpGet("by-name")]
        public async Task<IActionResult> GetByName(string searchName , DateTime? startDate, DateTime? endDate)
        {

            var response = await _workerService.GetWorkerResults(searchName, startDate, endDate);
                if (response == null)
            {
                return BadRequest("Not found");
            }
            return Ok(response);
             
        }

        [HttpPatch("{id:int}")]
        public async Task<IActionResult> Update(int id,[FromBody] WorkerRequest worker)
        {
            await _workerService.UpdateWorker(id, worker.Name, worker.CostPerHour);
            if (worker == null)
            {
                return BadRequest("Employee not found");
            }

            return Ok(worker);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _workerService.DeleteWorker(id);
           
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var response = await _workerService.GetAllAsync();
            if (response == null)
            {
                return BadRequest("Not found");
            }
            return Ok(response);

        }
        [HttpGet("by-Id")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _workerService.GetById(id);
            if (response == null)
            {
                return BadRequest("Not found");
            }
            return Ok(response);

        }
    }
}
