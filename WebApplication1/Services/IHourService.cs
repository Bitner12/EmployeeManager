using WebApplication1.Enties;
using WebApplication1.Models.Request;

namespace WebApplication1.Services
{
    public interface IHourService
    {
        Task<Hour> CreateHour(HourRequest hour);
        Task<int> DeleteHour(int id, DateTime date);
        Task<int> UpdateHour(int id, float hours, DateTime date);
    }
}