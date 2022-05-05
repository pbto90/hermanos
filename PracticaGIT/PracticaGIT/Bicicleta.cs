using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGIT
{
    public class Bicicleta
    {
        public string marca;
        public string modelo;
        public int rodada;
        public int velocidades;
        public string color;

        public void informacion()
        {
            Console.WriteLine("\nInformacion de la bicicleta");
            Console.WriteLine("\tMarca: {0}", marca);
            Console.WriteLine("\tModelo: {0}", modelo);
            Console.WriteLine("\tRodada: {0}", rodada);
            Console.WriteLine("\tVelocidades: {0}", velocidades);
            Console.WriteLine("\tColor: {0}", color);
        }
    }

}
