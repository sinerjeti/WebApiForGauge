using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiForGauge.Models
{
    public class WorkoutDay
    {
        public string Name { get; set; } = string.Empty;
        [ForeignKey(nameof(Number))]
        [PrimaryKey(nameof(Number))]
        public int Number { get; set; } = 0;
        public WorkoutProgram? WorkoutProgram { get; set; }
        public List<PhysicalExercises> PhysicalExercises { get; set; } = [];
    }
}
