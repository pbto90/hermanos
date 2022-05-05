using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGIT
{
    public class Persona
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public void NombreCompleto() 
        {
            Console.WriteLine(string.Format("{0} {1}", Nombre, Apellidos));
        }
    }
}
