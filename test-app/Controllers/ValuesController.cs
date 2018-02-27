using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test_app.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Вроде", "всё", "работает" };
        }
        
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "Вот! глянь текущее время: " + DateTime.Now;
        }
    }
}
