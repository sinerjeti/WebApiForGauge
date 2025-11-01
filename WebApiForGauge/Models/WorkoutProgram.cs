namespace WebApiForGauge.Models
{
    public class WorkoutProgram
    {
        public int Id { get; set; } = 0;
        public int UserWeight { get; set; } = 0;
        public string Gender { get; set; } = string.Empty;
        public string Goal { get; set; } = string.Empty;
        public string FitnessLevel { get; set; } = string.Empty;
        public string DaysPerWeek { get; set; } = string.Empty;
        public List<WorkoutDay> WorkoutDays { get; set; } = [];
    }
}
