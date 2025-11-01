namespace WebApiForGauge.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public WorkoutProgram? WorkoutProgram { get; set; }
    }
}
