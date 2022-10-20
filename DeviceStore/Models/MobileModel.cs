using System.ComponentModel.DataAnnotations;
namespace DeviceStore.Models
{
    public class MobileModel
    {
        public int MobileId { get; set; }
        [Required(ErrorMessage = "Please Add Model property")]
        public string Model { get; set; }
        public string Ram { get; set; }
        public int Cost { get; set; }
    }
}
