using System;
using System.Collections.Generic;
using System.Text;
using static ApiMundoDisney.Models.Enums;

namespace ApiMundoDisney.Models
{
    public class Pelicula : Entidad
    {
        //public int Id { get; set; }
        public string RutaImagen { get; set; }
        public string Titulo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public CalificacionPelicula Calificacion { get; set; }

        //public Genero Genero { get; set; }
        //public Genero GeneroId { get; set; }

        //public virtual ICollection<Personaje> Personajes { get; set; }
    }
}

