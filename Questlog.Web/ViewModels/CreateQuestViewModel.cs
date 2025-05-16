namespace Questlog.Web.ViewModels;

public class CreateQuestViewModel
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Objectives { get; set; } = new();
}
