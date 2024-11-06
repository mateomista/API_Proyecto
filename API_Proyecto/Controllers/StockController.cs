using API_Proyecto.Models;
using API_Proyecto.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Proyecto.Controllers
{
    public class StockController : Controller
    {
        private readonly StockService _service;

        public StockController (StockService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Posicion> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{posicion}")]
        public ActionResult<Posicion> GetByPosition(string posicion)
        {

            var objetoPosicion = _service.ConvertToPosicion(posicion);
            var pos = _service.GetByPosition(objetoPosicion);

            if (pos != null)
            {
                return pos;
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        public IActionResult agregarPosicion(Posicion nuevaPosicion)
        {
            var posicionAgregada = _service.AgregarPosicion(nuevaPosicion);
            return CreatedAtAction(nameof(GetByPosition), new
            {
                Pasillo = posicionAgregada.Pasillo,
                Seccion = posicionAgregada.Seccion,
                Estanteria = posicionAgregada.Estanteria,
                Nivel = posicionAgregada.Nivel
            }, posicionAgregada);
        }

        [HttpPut("{posicion}/ActualizarPasillo")]
        public IActionResult ActualizarPasillo(string posicion, char pasillo)
        {
            var pos = _service.ConvertToPosicion(posicion);
            var posicionActualizar = _service.GetByPosition(pos);

            if (posicionActualizar != null)
            {
                _service.ActualizarPasillo(posicionActualizar, pasillo);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{posicion}/ActualizarSeccion")]
        public IActionResult ActualizarSeccion(string posicion, ushort seccion)
        {
            var pos = _service.ConvertToPosicion(posicion);
            var posicionActualizar = _service.GetByPosition(pos);

            if (posicionActualizar != null)
            {
                _service.ActualizarSeccion(posicionActualizar, seccion);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{posicion}/ActualizarEstanteria")]
        public IActionResult ActualizarEstanteria(string posicion, ushort estanteria)
        {
            var pos = _service.ConvertToPosicion(posicion);
            var posicionActualizar = _service.GetByPosition(pos);

            if (posicionActualizar != null)
            {
                _service.ActualizarEstanteria(posicionActualizar, estanteria);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{posicion}/ActualizarNivel")]
        public IActionResult ActualizarNivel(string posicion, ushort nivel)
        {
            var pos = _service.ConvertToPosicion(posicion);
            var posicionActualizar = _service.GetByPosition(pos);

            if (posicionActualizar != null)
            {
                _service.ActualizarNivel(posicionActualizar, nivel);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{posicion}")]
        public IActionResult EliminarPosicion(string posicion)
        {

            var posicionEliminar = GetByPosition(posicion);

            if (posicionEliminar != null)
            {

                var pos = _service.ConvertToPosicion(posicion);
                _service.EliminarPosicion(pos);
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }    
    }
}
