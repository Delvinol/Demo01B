using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Persona
    {
        //Constructores
        public Persona() { 
        }
     
        public Persona(string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
        }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        //Función
        public String MayorEdad()
        {
            string mensaje = "";
            if (Edad > 18)
                mensaje = "Es mayor de edad";
            return mensaje;
        
        }
        //Las funciones tienen un return pero los procedimientos no

        //Procedimiento
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
    }
}
