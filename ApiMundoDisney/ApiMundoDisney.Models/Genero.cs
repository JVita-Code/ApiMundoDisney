using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiMundoDisney.Models
{
    public class Genero : Entidad
    {
        [Key]
        //public int Id { get; set; }
        public string Nombre { get; set; }
        public int RutaImagen { get; set; }
        //public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
