using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300004.Models;

namespace tpmodul10_103022300004.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> _mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa ("Deswita Syaharani", "103022300004" ),
            new Mahasiswa ("Carlos Sainz","103022300055" )
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return Ok(_mahasiswaList);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= _mahasiswaList.Count)
            {
                return NotFound();
            }
            return Ok(_mahasiswaList[index]);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mahasiswaBaru)
        {
            _mahasiswaList.Add(mahasiswaBaru);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= _mahasiswaList.Count)
            {
                return NotFound();
            }
            _mahasiswaList.RemoveAt(index);
            return Ok();
        }
    }
}
