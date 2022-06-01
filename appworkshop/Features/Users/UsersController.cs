using appworkshop.DataBase;
using Microsoft.AspNetCore.Mvc;

namespace appworkshop.Features.Users;
[ApiController]
[Route("api/users")]
public class UsersController : Controller
{
    private readonly AppDbContext _dbContext;

    public UsersController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public async Task<ActionResult<UserResponse>> Add([FromBody]UserRequest userRequest)
    {
        var user = new User
        {
            Id = Guid.NewGuid().ToString(),
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow,
            Username = userRequest.Username,
            Email = userRequest.Email,
            Password = userRequest.Password
        };

        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();

        return Ok(new UserResponse
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
        });
    }

    [HttpGet]
    public async Task<ActionResult<UserRequest>> Get()
    {
        return Ok(
            _dbContext.Users.Select(
                user => new UserResponse
                {
                    Id = user.Id,
                    Username = user.Username,
                    Email = user.Email,
                }
                ).ToList()
        );
    }
    
}