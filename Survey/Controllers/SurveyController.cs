using Microsoft.AspNetCore.Mvc;

namespace NewWeb.Controllers;

public class SurveyController : Controller
{
    // [HttpGet]
    // [Route("")]
    // public string Index()
    // {
    //     return "Hello from the controller";
    // }

    // [HttpGet("results")]
    // public string Two()
    // {
    //     return "Page Two";
    // }

    // [HttpGet("params/{id}/{name}")]
    // public string Params(int id, string name)
    // {
    //     return $"{name} is id {id}";
    // }

    // [HttpGet("view")]
    // public ViewResult SurveyView()
    // {
    //     return View("SurveyView");
    // }

    [HttpGet("")]
    public ViewResult SurveyView()
    {
        return View();
    }

    [HttpGet("results")]
    public ViewResult ResultView()
    {
        return View();
    }

    [HttpPost("submit")]
    public IActionResult Submit(string name, string location, string language, string comment)
    {
        ViewBag.Name = name;
        ViewBag.Location = location;
        ViewBag.Language = language;
        ViewBag.Comment = comment;
        return View("ResultView");
    }
}
