using Microsoft.AspNetCore.Http;
using API_Proyecto.Models;
using API_Proyecto.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Proyecto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController : Controller
    {
        private readonly ProductoService _service;
        
        public ProductosController(ProductoService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Producto> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Producto> GetById(int id)
        {
            var producto = _service.GetById(id);

            if (producto != null)
            {
                return producto;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}/updatedescription")]
        public IActionResult UpdateDescription(int id, string descr)
        {
            var productoActualizar = _service.GetById(id);

            if (productoActualizar != null) {
                _service.UpdateDescription(id, descr);
                return NoContent();
            } else
            {
                return NotFound();
            }
        }

        

    }
}
