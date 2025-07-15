using EmployeeManager.Repositories;
using WebApplication1.Enties;
using WebApplication1.Models.Request;

namespace WebApplication1.Services
{
    public class HourService : IHourService
    {
        private readonly IHourRepository _hourRepository;
        public HourService(IHourRepository hourRepository)
        {
            _hourRepository = hourRepository;
        }

        public async Task<Hour> CreateHour(HourRequest hour)
        {
            return await _hourRepository.Create(hour);
        }
        public async Task<int> DeleteHour(int id, DateTime date)
        {
            await _hourRepository.Delete(id, date);
            return id;
        }
        public async Task<int> UpdateHour(int id, float hours, DateTime date)
        {
            await _hourRepository.Update(id, hours, date);
            return id;

        }
    }
}
