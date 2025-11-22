
namespace WebApiForGauge.Models
{
    public class RegisterUserDTO
    {
        public string Username { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
    }
}
