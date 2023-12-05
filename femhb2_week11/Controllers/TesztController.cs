using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace femhb2_week11.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class TesztController : ControllerBase
    {
        [HttpGet]
        [Route("corvinus/nagybetus/{szoveg}")]
        public IActionResult M2(string szoveg)
        {
            return Ok(szoveg.ToUpper());
        }
    }
}
