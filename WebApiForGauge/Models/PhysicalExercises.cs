using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApiForGauge.Models
{
    public class PhysicalExercises
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Difficulty { get; set; } = string.Empty;
        public int Reps { get; set; } = 0;
        public WorkoutDay? WorkoutDay { get; set; }
    }
}
