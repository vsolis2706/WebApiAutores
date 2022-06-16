using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [ApiController]
    [Route("api/Autores")]

    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>()
            {
                new Autor()               {
                    Id=1,
                    Nombre="Camila"
                },

                 new Autor()               {
                    Id=2,
                    Nombre="Koo"
                }

            };
        }

    }
}
