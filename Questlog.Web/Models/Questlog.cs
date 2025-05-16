namespace Questlog.Web.Models;
public class Questlog
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Objectives { get; set; }

    // for hardcoded entities
    public Questlog(Guid id, string title, string description, List<string> objectives)
    {
        Id = id;
        Title = title;
        Description = description;
        Objectives = objectives;
    }
}
