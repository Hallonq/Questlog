using Microsoft.AspNetCore.Mvc;
using Questlog.Web.Services;

namespace Questlog.Web.Controllers;
public class QuestlogController : Controller
{
    private static QuestlogService _questlogService;
    public QuestlogController(QuestlogService questlogService)
    {
        _questlogService = questlogService;
    }
    [HttpGet("")]
    public IActionResult Index()
    {
        var model = _questlogService.GetAllQuestlogs();
        return View(model);
    }

    [HttpGet(nameof(Create))]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost(nameof(Create))]
    public IActionResult Create(Models.Questlog questlog)
    {
        if (!ModelState.IsValid)
        {
            return View(questlog);
        }

        try
        {
            _questlogService.Create(questlog);
        }
        catch (Exception e)
        {
            throw;
        }

        return RedirectToAction(nameof(Index));
    }
}
