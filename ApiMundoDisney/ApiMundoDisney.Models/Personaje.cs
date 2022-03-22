using System;
using System.Collections.Generic;
using System.Text;

namespace ApiMundoDisney.Models
{
    public class Personaje : Entidad
    {
        //public int Id { get; set; }
        public string RutaImagen { get; set; }
        public string Nombre { get; set; }        
        public int Edad { get; set; }
        public int Peso { get; set; }
        public string Historia { get; set; }
        //public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
