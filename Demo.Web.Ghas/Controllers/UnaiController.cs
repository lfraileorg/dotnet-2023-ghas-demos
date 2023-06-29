using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Ghas.Controllers
{   

    [Route("[controller]")]
    [ApiController]
    public class UnaiController : Controller
    {
        private string _ImHere;
        
        public UnaiController()
        {
            _ImHere = "I'm here!";
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult WhoLikesUnai(string who)
        {
            if (!string.IsNullOrEmpty(who))
            {
                return Ok($"Say hi to {who}. {_ImHere}");
            }
            else if (who == "unai")
            {
                //WE don't want to say hello to unai
            }

            return Ok();
        }
    }
}
