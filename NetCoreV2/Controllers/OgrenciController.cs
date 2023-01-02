using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreV2.DataAccesLayer;

namespace NetCoreV2.Controllers
{
    // https://www.roketnot.com/not/1624-net-6-core-web-api-basit-kullanimi
    [Route("api/[controller]")]
    [ApiController]
    public class OgrenciController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Ogrenci.ToList();
            return Ok(values);
        }


        [HttpPost]
        public IActionResult EmployeeAdd(Ogrenci employee)
        {
            using var c = new Context();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }
    }
}
