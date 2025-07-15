using WebApplication1.Enties;
using WebApplication1.Models.Request;
using WebApplication1.Response;

namespace WebApplication1.Services
{
    public interface IWorkerService
    {
        Task<Worker> CreatWorker(WorkerRequest worker);
        Task<int> DeleteWorker(int id);
        Task<List<Worker>> GetAllAsync();
        Task<Worker> GetById(int id);
        Task<List<WorkerDto>> GetWorkerResults(string searchName, DateTime? startDate, DateTime? endDate);
        Task<int> UpdateWorker(int id, string name, decimal costPerHour);
    }
}