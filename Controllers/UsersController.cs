using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testSqlLite.Data; 

namespace testSqlLite.Controllers
{
[ApiController]
[Route("api/user")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }
[HttpGet]
public async Task< IActionResult> Get(){

    var users = await _context.User.ToListAsync() ; 
    return Ok(users);

    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById(int Id)
    {
        var result = await _context.User.FirstOrDefaultAsync(x=>x.id==Id); 
return Ok(result) ; 


    }
 }


}