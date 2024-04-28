using Microsoft.AspNetCore.Mvc;
using TPMOD10;

namespace TPMOD10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
    {
        new Mahasiswa(" Muhammad Rizki", "1302220128"),
        new Mahasiswa(" Salman Hamala Rizky", "1302220122"),
        new Mahasiswa(" Afzaal Isnaufal", "1302220104"),
        new Mahasiswa(" Athallah Muhammad Abdul Aziz", "1302223125")
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
