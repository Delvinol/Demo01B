using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Triangulo
    {//para crear una propiedad solo escribir "prop" y clic en tab
        public int Base { get; set; }
        public int Altura { get; set; }


        //Creación de métodos
        public int CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
