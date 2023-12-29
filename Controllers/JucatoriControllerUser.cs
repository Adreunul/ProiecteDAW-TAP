using AspNetCoreApp.Models;
using AspNetCoreApp.DataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreApp.Models.DTO.Jucatori;
using AutoMapper;

namespace AspNetCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JucatoriControllerUser : ControllerBase
    {
        private readonly TeamAppDb db;
        private readonly IMapper mapper;

        public JucatoriControllerUser(TeamAppDb db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("Toti jucatorii")]
        public IActionResult getAllJucatori()
        {
            var jucatori = db.Jucatori.ToList();

            return Ok(jucatori);
        }

        [HttpGet]
        [Route("Specific")]
        public IActionResult getJucator(string? nume, string? prenume, string? numeTara, int? idJucator, int? idTara, int? idEchipa, string? denumireEchipa, int? idPozitie)
        {
            /*if (idJucator != null)
            {
                var existingJucator = db.Jucatori.Where(j => j.IdJucator == idJucator).FirstOrDefault();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator cu acest ID !");

                return Ok(existingJucator);
            }

            else if (nume != null && prenume != null && numeTara == null && idTara == null && denumireEchipa == null && idEchipa == null && idPozitie == null)
            {
                var existingJucator = db.Jucatori.Where(j => j.Nume == nume && j.Prenume == prenume).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator cu acest nume !");

                return Ok(existingJucator);
            }

            else if (nume != null && prenume == null && numeTara == null && idTara == null && denumireEchipa == null && idEchipa == null && idPozitie == null)
            {
                var existingJucator = db.Jucatori.Where(j => j.Nume == nume).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator cu acest nume !");

                return Ok(existingJucator);
            }

            else if (nume == null && prenume != null && numeTara == null && idTara == null && denumireEchipa == null && idEchipa == null && idPozitie == null)
            {
                var existingJucator = db.Jucatori.Where(j => j.Prenume == prenume).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator cu acest prenume !");

                return Ok(existingJucator);
            }

            else if (nume == null && prenume == null && numeTara != null && idTara == null && denumireEchipa == null && idEchipa == null && idPozitie == null)
            {
                var existingTara = db.Tari.Where(t => t.Denumire == numeTara).SingleOrDefault();
                if (existingTara == null)
                    return NotFound("Nu exista nicio inregistrare cu o tara cu aceasta denumire !");
                int IdTara = existingTara.IdTara;

                var existingJucator = db.Jucatori.Where(j => j.IdTara == IdTara).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator care sa provina din tara introdusa !");

                return Ok(existingJucator);
            }

            else if (nume == null && prenume == null && numeTara == null && idTara != null && denumireEchipa == null && idEchipa == null && idPozitie == null)
            {
                var existingJucator = db.Jucatori.Where(j => j.IdTara == idTara).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator care sa provina din tara introdusa !");

                return Ok(existingJucator);
            }

            else if (nume == null && prenume == null && numeTara == null && idTara == null && denumireEchipa != null && idEchipa == null && idPozitie == null)
            {
                var existingEchipa = db.Echipe.Where(e => e.Nume == denumireEchipa).SingleOrDefault();
                if (existingEchipa == null)
                    return NotFound("Nu exista nicio inregistrare cu o echipa care sa aibe numele introdus!");

                int IdEchipa = existingEchipa.IdEchipa;

                var existingJucator = db.Jucatori.Where(j => j.IdEchipa == IdEchipa).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator care sa provina din tara introdusa !");

                return Ok(existingJucator);
            }

            else if (nume == null && prenume == null && numeTara == null && idTara == null && denumireEchipa == null && idEchipa != null && idPozitie == null)
            {
                var existingJucator = db.Jucatori.Where(j => j.IdEchipa == idEchipa).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator care sa joace la echipa introdusa !");

                return Ok(existingJucator);
            }

            else if (nume == null && prenume == null && numeTara == null && idTara == null && denumireEchipa == null && idEchipa == null && idPozitie != null)
            {
                var existingJucator = db.Jucatori.Where(j => j.IdPozitie == idPozitie).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator care sa joace in pozitia introdusa !");

                return Ok(existingJucator);
            }

            else if (nume == null && prenume == null && numeTara == null && idTara == null && denumireEchipa == null && idEchipa != null && idPozitie != null)
            {
                var existingJucator = db.Jucatori.Where(j => j.IdEchipa == idEchipa && j.IdPozitie == idPozitie).ToList();
                if (existingJucator == null)
                    return NotFound("Nu exista nicio inregistrare cu un jucator care sa joace la echipa introdusa in pozitia specificata !");

                return Ok(existingJucator);
            }


*/

            var jucatorii = db.Jucatori.ToList();
            var jucatoriReturn = mapper.Map<List<JucatorPozaDTO>>(jucatorii);
            return Ok(jucatoriReturn);

            //return getAllJucatori();
        }


    }
}


