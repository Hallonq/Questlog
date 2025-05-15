using Questlog.Web.Models;
namespace Questlog.Web.Services;
public class QuestlogService
{
    private static List<Models.Questlog> questlogs = [];

    public QuestlogService()
    {
        questlogs.Add(new Models.Questlog(Guid.NewGuid(), "Slay Dragon", "Look south for a cave entrance, slay the monster and return with its head",
            new Dictionary<int, string>()
            {
                { 0, "Find the cave entrance" },
                { 1, "Slay the dragon" },
                { 2, "Return with the dragon's head" }
            }));
        questlogs.Add(new Models.Questlog(Guid.NewGuid(), "WANTED: Sewer King", "Look NW for sewer entrance, defeat the usurper and return his necklace",
            new Dictionary<int, string>()
            {
                { 0, "Find the sewer entrance" },
                { 1, "Defeat the Sewer King" },
                { 2, "Return with the necklace" }
            }));

        questlogs.Add(new Models.Questlog(Guid.NewGuid(), "Find the Lost Sword", "Look in the forest for a steep hill, find the sword and return it to the king",
            new Dictionary<int, string>()
            {
                { 0, "Find the steep hill" },
                { 1, "Find the sword" },
                { 2, "Return the sword to the king" }
            }));
    }

    public Models.Questlog[] GetAllQuestlogs() => questlogs.OrderBy(x => x.Title).ToArray();
    public Models.Questlog GetQuestlogById(Guid id) => questlogs.Single(x => x.Id == id);
    public void Create(Models.Questlog item)
    {
        item.Id = Guid.NewGuid();
        questlogs.Add(item);
    }
}
