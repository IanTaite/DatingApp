using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Users")]
    public IEnumerable<AppUser> Get()
    {
        AppUser user = new AppUser() { Id = 1, UserName = "fred" };
        return new List<AppUser>() { user };
    }
}
