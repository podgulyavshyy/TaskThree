using ClassLibTime;

namespace AssignmentThreeApp.Controllers;


using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/stats/users/")]
public class TestController : ControllerBase
{
    [HttpGet("date={wantedTime}")]
    public IActionResult Get([FromRoute] string wantedTime)
    {

        var data = new OneJsonResponse()
        {
            // usersOnline = TimeSeenMain.TaskOne(wantedTime),
            test = "wantedTime"
        };
        
        return Ok(data);
    }

}
