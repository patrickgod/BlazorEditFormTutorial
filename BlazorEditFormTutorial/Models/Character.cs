using System.ComponentModel.DataAnnotations;

namespace BlazorEditFormTutorial.Models
{
    public class Character
    {
        [Required, Range(1, int.MaxValue, ErrorMessage = "The Id can't be smaller than 1.")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please give this character a name. Thanks! :)")]
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Image { get; set; } = string.Empty;
        public int TeamId { get; set; } = 1;
        public int DifficultyId { get; set; } = 1;
        public bool IsReadyToFight { get; set; } = true;
    }
}
