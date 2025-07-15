using WebApplication1.Enties;

namespace WebApplication1.Models.Request
{
    public class HourRequest
    {
        public DateTime Date { get; set; }
        public float Hours { get; set; }
        public int WorkerId { get; set; }

    }
}
