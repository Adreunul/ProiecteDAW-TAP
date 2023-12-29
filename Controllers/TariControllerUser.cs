using AspNetCoreApp.Models;
using AspNetCoreApp.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreApp.Models.DTO.Tari;

namespace AspNetCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TariControllerUser : ControllerBase
    {
        private readonly TeamAppDb db;

        public TariControllerUser(TeamAppDb db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult getAllTari()
        {
            var tari = db.Tari.ToList();

            return Ok(tari);
        }

        [HttpGet]
        [Route("Specific")]
        public IActionResult getTara(string? denumire, int? idTara)
        {

            if (idTara != null)
            {
                var existingTara = db.Tari.Where(t => t.IdTara == idTara).FirstOrDefault();
                if (existingTara == null)
                    return BadRequest("Nu exista nicio inregistrare cu o tara care sa aibe ID-ul introdus !");

                return Ok(existingTara);
            }

            if (denumire != null)
            {
                var existingTara = db.Tari.Where(t => t.Denumire == denumire).FirstOrDefault();
                if (existingTara == null)
                    return BadRequest("Nu exista nicio inregistrare cu o tara care sa aibe numele introdus !");

                return Ok(existingTara);
            }

            return BadRequest("???");
        }

    }
}
