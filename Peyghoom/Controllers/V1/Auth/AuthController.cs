using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

using MongoDB.Bson;
using MongoDB.Driver;

using Peyghoom.Contracts;
using Peyghoom.Entities.Auth;
using Peyghoom.Services;

namespace Peyghoom.Controllers.V1.Auth
{

    [ApiController]
    [Route("[Controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;
        public AuthController(AuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("Login")]
        public async Task<ActionResult<User>> LoginAsync(CancellationToken cancellationToken)
        {
            var client = new MongoClient("mongodb://rezayari.ir:27017/?directConnection=true&serverSelectionTimeoutMS=2000");
            var database = client.GetDatabase("rpeyghoom");
            var collection = database.GetCollection<User>("users");
            var user = await collection.Find(user => user.Email == "rezaayaari@gmail.com").FirstOrDefaultAsync();
            if (user == null)
            {
                return NotFound("user not found");
            }
            //await _authService.LookUpUserAsync(cancellationToken);

            //await _authService.CheckTokenValidityAsync(cancellationToken);

            //await _authService.GenerateTokenAsync(cancellationToken);
            
            return user;
        }
        
    }
}
