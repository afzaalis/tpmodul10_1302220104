using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302220104.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Afzaal isnaufal", "1302220104"),
        new Mahasiswa(" Salman hamala rizky", "130222219"),
        new Mahasiswa(" Muhammad rizki", "12312321"),
        new Mahasiswa(" Athalla abdul" , "31231"),

    };
        [HttpGet]

        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return listMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            listMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMahasiswa.RemoveAt(id);
        }
    }
}