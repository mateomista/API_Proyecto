using API_Proyecto.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Proyecto.Services
{
    public class StockService
    {
        private List<Posicion> _posiciones = new List<Posicion>
        {
            new Posicion { Pasillo = 'A', Seccion = 1, Estanteria = 3, Nivel = 1, Cantidad = 15 },
            new Posicion { Pasillo = 'B', Seccion = 2, Estanteria = 5, Nivel = 3, Cantidad = 20 },
            new Posicion { Pasillo = 'C', Seccion = 1, Estanteria = 2, Nivel = 4, Cantidad = 12 },
            new Posicion { Pasillo = 'D', Seccion = 3, Estanteria = 7, Nivel = 2, Cantidad = 8 },
            new Posicion { Pasillo = 'E', Seccion = 1, Estanteria = 6, Nivel = 1, Cantidad = 25 },
            new Posicion { Pasillo = 'F', Seccion = 2, Estanteria = 3, Nivel = 3, Cantidad = 30 },
            new Posicion { Pasillo = 'G', Seccion = 4, Estanteria = 8, Nivel = 2, Cantidad = 10 },
            new Posicion { Pasillo = 'H', Seccion = 3, Estanteria = 2, Nivel = 1, Cantidad = 5 },
            new Posicion { Pasillo = 'I', Seccion = 2, Estanteria = 1, Nivel = 4, Cantidad = 18 },
            new Posicion { Pasillo = 'J', Seccion = 1, Estanteria = 5, Nivel = 3, Cantidad = 22 },
            new Posicion { Pasillo = 'K', Seccion = 5, Estanteria = 1, Nivel = 2, Cantidad = 35 },
            new Posicion { Pasillo = 'L', Seccion = 4, Estanteria = 2, Nivel = 3, Cantidad = 27 },
            new Posicion { Pasillo = 'M', Seccion = 6, Estanteria = 4, Nivel = 1, Cantidad = 40 },
            new Posicion { Pasillo = 'N', Seccion = 3, Estanteria = 3, Nivel = 4, Cantidad = 19 },
            new Posicion { Pasillo = 'O', Seccion = 2, Estanteria = 6, Nivel = 2, Cantidad = 13 }
        };


        public IEnumerable<Posicion> GetAll()
        {
            return _posiciones; 
        }

        public Posicion? GetByPosition(Posicion pos)
        {
            var posicionEncontrada = _posiciones.FirstOrDefault(p =>
                p.Pasillo == pos.Pasillo &&
                p.Nivel == pos.Nivel &&
                p.Seccion == pos.Seccion &&
                p.Estanteria == pos.Estanteria
            );

            return posicionEncontrada; 
            
        }

        public Posicion? AgregarPosicion(Posicion pos)
        {
            _posiciones.Add( pos );

            return pos;
        }

        public Posicion ConvertToPosicion(string input)
        {
            if (string.IsNullOrWhiteSpace(input) || input.Length < 4)
            {
                throw new ArgumentException("El formato del string es incorrecto. Debe ser de al menos 4 caracteres.");
            }

            char pasillo = input[0]; 
            ushort seccion = (ushort)char.GetNumericValue(input[1]); 
            ushort estanteria = (ushort)char.GetNumericValue(input[2]); 
            ushort nivel = (ushort)char.GetNumericValue(input[3]); 

            return new Posicion
            {
                Pasillo = pasillo,
                Seccion = seccion,
                Estanteria = estanteria,
                Nivel = nivel,
            };
        }

        public void ActualizarPasillo(Posicion posicion, char nuevoPasillo)
        {
            posicion.Pasillo = nuevoPasillo;
            _posiciones.Add(posicion);

        }

        public void ActualizarSeccion(Posicion posicion, ushort nuevaSeccion)
        {
            posicion.Seccion = nuevaSeccion;
            _posiciones.Add(posicion);

        }

        public void ActualizarEstanteria(Posicion posicion, ushort nuevaEstanteria)
        {
            posicion.Estanteria = nuevaEstanteria;
            _posiciones.Add(posicion);

        }

        public void ActualizarNivel(Posicion posicion, ushort nuevoNivel)
        {
            posicion.Nivel = nuevoNivel;
            _posiciones.Add(posicion);  
        }

        public void ActualizarCantidad(Posicion posicion, ushort nuevaCantidad)
        {
            posicion.Cantidad = nuevaCantidad;
            _posiciones.Add(posicion);
        }

        public void EliminarPosicion(Posicion posicion)
        {
            var objetoEliminar = GetByPosition(posicion);
            _posiciones.RemoveAll(p =>
                    p.Pasillo == objetoEliminar.Pasillo &&
                    p.Seccion == objetoEliminar.Seccion &&
                    p.Estanteria == objetoEliminar.Estanteria &&
                    p.Nivel == objetoEliminar.Nivel
             );
        }
    }
}
