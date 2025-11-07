using System.ComponentModel.DataAnnotations;

namespace WebApiForGauge.Models
{
    public class User
    {
        public string Email { get; set; } = string.Empty;
        [Key]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public List<string> Features { get; set; } = new List<string>();
    }
}
