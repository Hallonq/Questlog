namespace Questlog.Web.Models;
public class Questlog
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Dictionary<int, string> Objectives { get; set; }

    public Questlog(Guid id, string title, string description, Dictionary<int, string> objectives)
    {
        Id = id;
        Title = title;
        Description = description;
        Objectives = objectives;
    }
}
