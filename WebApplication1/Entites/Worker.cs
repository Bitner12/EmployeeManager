using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Enties
{

    public class Worker
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal CostPerHour { get; set; }

        public virtual ICollection<Hour> Hours { get; set; }



    }

}
