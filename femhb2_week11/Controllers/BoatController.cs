using femhb2_week11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace femhb2_week11.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        [HttpGet]
        [Route("questions/all")]
        public IActionResult MindegyHogyHivjak()
        {
            HajosContext context = new HajosContext();
            var kérdések = from x in context.Questions select x.Question1;

            return Ok(kérdések);
        }

        [HttpGet]
        [Route("questions/{sorszám}")]
        public ActionResult M2(int sorszám)
        {
            HajosContext context = new HajosContext();
            var kérdés = (from x in context.Questions
                          where x.QuestionId == sorszám
                          select x).FirstOrDefault();

            if (kérdés == null) return BadRequest("Nincs ilyen sorszámú kérdés");

            return new JsonResult(kérdés);
        }

        [HttpGet]
        [Route("questions/count")]
        public int M4() //Tetszőleges metódusnév
        {
            HajosContext context = new HajosContext();
            int kérdésekSzáma = context.Questions.Count();

            return kérdésekSzáma;
        }
    }
}
