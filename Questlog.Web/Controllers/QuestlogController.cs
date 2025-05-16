using Microsoft.AspNetCore.Mvc;
using Questlog.Web.Services;
using Questlog.Web.ViewModels;

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
        var model = new CreateQuestViewModel();
        return View(model);
    }

    [HttpPost(nameof(Create))]
    public IActionResult Create(CreateQuestViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        try
        {
            _questlogService.Create(model);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }
        return RedirectToAction(nameof(Index));
    }
}
