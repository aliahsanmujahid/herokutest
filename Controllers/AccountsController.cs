using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApi.Data;
using WebApi.Dtos;
using WebApi.Entities;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : BaseController
    {
         private DataContext _db;

        public AccountsController(DataContext db)
        {
            _db = db;
        }
        [HttpGet()]
        public ActionResult get()
        {

            return Ok(new {
                name = "wefwe",
                password = "wefwefwe"
            });

        }
        [HttpGet("getcolor")]
        public IEnumerable<Colors> getcolor()
        {

            return _db.Colors.ToList();

        }
        
        [HttpPost("create")]
        public IActionResult create(ColorDto colorDto)
        {

            var color = new Colors()
                {
                    Name = colorDto.Name,
                    ColorCode = colorDto.ColorCode,
                    Quantity = colorDto.Quantity
                };

           _db.Colors.Add(color);
           _db.SaveChanges();
           return Ok(color);

        }
        [HttpPost("delete/{id}")]
        public IActionResult delete(int id)
        {

           var color = _db.Colors.Find(id);
           _db.Colors.Remove(color);

           _db.SaveChanges();
           return Ok(color);

        }

        
    }
}
