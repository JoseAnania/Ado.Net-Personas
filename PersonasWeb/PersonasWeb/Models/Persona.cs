using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonasWeb.Models
{
    public class Persona
    {
        public int Documento { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(int documento, string nombre, int edad)
        {
            Documento = documento;
            Nombre = nombre;
            Edad = edad;
        }

        public Persona()
        {
        }
    }
}