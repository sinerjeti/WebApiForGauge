namespace WebApiForGauge.Models
{
    public class RegisterUserDTO
    {
        public string Username { get; set; } = string.Empty;
        public int Password { get; set; } = 0;
        public DateTime Birthday { get; set; } = DateTime.MinValue;
    }
}
