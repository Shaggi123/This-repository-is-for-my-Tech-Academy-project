using YourProject.Models;
namespace YourProject.Models
{
    public class InsureeViewModel
    {
        // Define the properties for the InsureeViewModel
        public int Age { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int SpeedingTickets { get; set; }
        public bool HasDUI { get; set; }
        public string CoverageType { get; set; }
        public decimal Quote { get; set; }
    }
}
