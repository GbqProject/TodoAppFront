using System.ComponentModel.DataAnnotations;

namespace TodoAppFront.Components.Modules.Task.Domain
{
    public class Task
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(400)]
        public string Description { get; set; }

        [Range(1, 5)]
        public int priority { get; set; }

        [Required]
        [StringLength(100)]
        public string status { get; set; }

        public string? base64pdf { get; set; }
    }
}
