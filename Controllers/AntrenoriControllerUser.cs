using AspNetCoreApp.Models;
using AspNetCoreApp.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreApp.Models.DTO.Antrenori;

namespace AspNetCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AntrenoriControllerUser : ControllerBase
    {
        private readonly TeamAppDb db;

        public AntrenoriControllerUser(TeamAppDb db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("Toti antrenorii")]
        public IActionResult getAllAntrenori()
        {
            var antrenori = db.Antrenori.ToList();

            return Ok(antrenori);
        }

        [HttpGet]
        [Route("Specific")]
        public IActionResult getAntrenor(string? nume, string? prenume, string? numeTara, int? idAntrenor, int? idTara)
        {

            if (idAntrenor != null)
            {
                var existingAntrenor = db.Antrenori.Where(a => a.IdAntrenor == idAntrenor).FirstOrDefault();
                if (existingAntrenor == null)
                    return BadRequest("Nu exista nicio inregistrare cu un antrenor cu acest ID !");

                return Ok(existingAntrenor);
            }

            else if (nume != null && prenume != null && numeTara == null)
            {
                var existingAntrenor = db.Antrenori.Where(a => a.Nume == nume && a.Prenume == prenume).ToList();
                if (existingAntrenor == null)
                    return BadRequest("Nu exista nicio inregistrare cu un antrenor cu acest nume !");

                return Ok(existingAntrenor);
            }

            else if (nume != null && prenume == null && numeTara == null)
            {
                var existingAntrenor = db.Antrenori.Where(a => a.Nume == nume).ToList();
                if (existingAntrenor == null)
                    return BadRequest("Nu exista nicio inregistrare cu un antrenor cu acest nume !");

                return Ok(existingAntrenor);
            }

            else if (nume == null && prenume != null && numeTara == null)
            {
                var existingAntrenor = db.Antrenori.Where(a => a.Prenume == prenume).ToList();
                if (existingAntrenor == null)
                    return BadRequest("Nu exista nicio inregistrare cu un antrenor cu acest prenume !");
                return Ok(existingAntrenor);
            }

            else if (nume == null && prenume == null && numeTara != null) // eu am zis pe grup ca fac dupa id, dar de fapt insert-ul il fac dupa id si asta dupa nume
            {
                var existingTara = db.Tari.Where(t => t.Denumire == numeTara).SingleOrDefault();
                if (existingTara == null)
                    return BadRequest("Nu exista nicio inregistrare cu o tara cu acest nume !");
                int IdTara = existingTara.IdTara;

                var existingAntrenor = db.Antrenori.Where(a => a.IdTara == IdTara).ToList();
                if (existingAntrenor == null)
                    return BadRequest("Nu exista niciun antrenor care sa provina din tara introdusa !");

                return Ok(existingAntrenor);
            }

            else if (nume == null && prenume == null && numeTara == null && idTara != null)
            {
                var existingAntrenor = db.Antrenori.Where(a => a.IdTara == idTara).ToList();
                if (existingAntrenor == null)
                    return BadRequest("Nu exista niciun antrenor care sa provina din tara introdusa !");

                return Ok(existingAntrenor);
            }

            return getAllAntrenori();
        }
    }
}
