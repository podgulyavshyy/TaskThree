using ClassLibTime;

namespace AssignmentThreeApp.Controllers;


using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TaskOneController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult Get([FromRoute] int id)
    {

        var data = new OneJsonResponse()
        {
            usersOnline = id,
            test = "test"
            
        };
        return Ok(data);
    }

}
