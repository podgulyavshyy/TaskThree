namespace AssignmentThreeApp.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MyDataController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var data = new MyData
        {
            Id = 1,
            Name = "Sample Data"
        };
        return new JsonResult(data);
    }
}
