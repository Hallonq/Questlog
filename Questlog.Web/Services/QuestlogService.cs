using Questlog.Web.Models;
using Questlog.Web.ViewModels;
namespace Questlog.Web.Services;
public class QuestlogService
{
    private static List<Models.Questlog> quests = [];

    public QuestlogService()
    {
        quests.Add(new Models.Questlog(Guid.NewGuid(), "Slay Dragon", "Look south for a cave entrance, slay the monster and return with its head",
            new List<string>()
            {
                { "Find the cave entrance" },
                { "Slay the dragon" },
                { "Return with the dragon's head" }
            }));
        quests.Add(new Models.Questlog(Guid.NewGuid(), "WANTED: Sewer King", "Look NW for sewer entrance, defeat the usurper and return his necklace",
            new List<string>()
            {
                { "Find the sewer entrance" },
                { "Defeat the Sewer King" },
                { "Return with the necklace" }
            }));

        quests.Add(new Models.Questlog(Guid.NewGuid(), "Find the Lost Sword", "Look in the forest for a steep hill, find the sword and return it to the king",
            new List<string>()
            {
                { "Find the steep hill" },
                { "Find the sword" },
                { "Return the sword to the king" }
            }));
    }

    public ListAllQuestsViewModel GetAllQuestlogs() => new()
    {
        Quests = quests.OrderBy(x => x.Title).ToList()
    };
    public Models.Questlog GetQuestlogById(Guid id) => quests.Single(x => x.Id == id);
    public void Create(CreateQuestViewModel model)
    {
        var entity = new Models.Questlog(Guid.NewGuid(), model.Title, model.Description, model.Objectives);
        quests.Add(entity);
    }
}
