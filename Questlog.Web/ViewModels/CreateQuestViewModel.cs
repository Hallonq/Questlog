using System.ComponentModel.DataAnnotations;

namespace Questlog.Web.ViewModels;

public class CreateQuestViewModel
{
    [Required]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 50 characaters")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(1000, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 1000 characters")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [MinLength(1, ErrorMessage = "At least one objective is required.")]
    public List<string> Objectives { get; set; } = new();
}
