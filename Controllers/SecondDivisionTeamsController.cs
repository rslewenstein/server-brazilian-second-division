using Microsoft.AspNetCore.Mvc;
using server_brazilian_second_division.Repository.interfaces;

namespace server_brazilian_second_division.Controllers;

[ApiController]
[Route("[controller]")]
public class SecondDivisionTeamsController : ControllerBase
{
    private readonly ISecondDivisionRepository _repo;

     public SecondDivisionTeamsController(ISecondDivisionRepository repo)
     {
        _repo = repo;
     }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_repo.GetAllTeams());
    }
}
