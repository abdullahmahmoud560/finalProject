using finalProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ActiveController : ControllerBase
    {
        private readonly DB _db;

        public ActiveController(DB db)
        {
            _db = db;
        }

        [HttpGet("api/account/activate")]
        public async Task<IActionResult> ActivateAccount([FromQuery] string token)
        {
            var user = await _db.students.FirstOrDefaultAsync(u => u.Token == token);
            if (user == null)
            {
                return Content("The link is invalid or the user does not exist.");
            }

            if (user.isActive == true)
            {
                return Content("Your account is already activated.");
            }

            user.isActive = true;
            await _db.SaveChangesAsync();

            return Content(@"
                    <html>
                    <head>
                        <meta charset='UTF-8'>
                        <meta http-equiv='refresh' content='3;url=https://edu-guide-ai.vercel.app/login'>
                        <title>Account Activated</title>
                    </head>
                    <body style='font-family: Arial; text-align: center; padding-top: 50px;'>
                        <h2 style='color: green;'>✅ Your account has been successfully activated!</h2>
                        <p>You will be redirected to the login page shortly...</p>
                    </body>
                    </html>", "text/html");
        }

    }
}
