using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ActiveController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public ActiveController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("account/activate")]
        public async Task<IActionResult> ActivateAccount([FromQuery] string token)
        {
            var user = (await _serviceManager.StudentService.GetByConditionAsync(x => x.Token == token)).FirstOrDefault();
            if (user == null)
            {
                return Content("The link is invalid or the user does not exist.");
            }

            if (user.isActive == true)
            {
                return Content("Your account is already activated.");
            }

            user.isActive = true;
            await _serviceManager.StudentService.UpdateStudent(user);
            return Content(@"
                    <html>
                    <head>
                        <meta charset='UTF-8'>
                        <meta http-equiv='refresh' content='3;url=https://guido-three.vercel.app/login'>
                        <title>Account Activated</title>
                    </head>
                    <body style='font-family: Arial; text-align: center; padding-top: 50px;'>
                        <h2 style='color: green;'>✅ Your account has been successfully activated!</h2>
                        <p>You will be redirected to the login page shortly...</p>
                    </body>
                    </html>", "text/html");
        }
        
        [HttpGet("Reset/activate")]
        public async Task<IActionResult> ActiveReset([FromQuery] string token)
        {
            var user = (await _serviceManager.StudentService.GetByConditionAsync(x => x.Token == token)).FirstOrDefault();
            if (user == null)
            {
                return Content("The link is invalid or the user does not exist.");
            }

            if (user.isActive == true)
            {
                await _serviceManager.StudentService.UpdateStudent(user);
                return Content($@"
    <html>
    <head>
        <meta charset='UTF-8'>
        <meta http-equiv='refresh' content='3;url=https://guido-three.vercel.app/reset-password'>
        <title>Account Activated</title>
    </head>
    <body style='font-family: Arial; text-align: center; padding-top: 50px;'>
        <h2 style='color: green;'>✅ Your account has been successfully activated!</h2>
        <p>You will be redirected to the reset password page shortly...</p>
    </body>
    </html>", "text/html");
            }

           return Content("Your account is not activated yet. Please activate your account first.");
        }

    }
}
