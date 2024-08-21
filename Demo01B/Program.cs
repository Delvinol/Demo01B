using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Para crear un objeto NombreClase NombreInstancia = new NombreClase
            Persona persona = new Persona();
            //Para dar valores:
            persona.Nombres = "Delvin Onil";
            persona.Apellidos = "Larez Mauricio";

            persona.AsignarNombresCompletos();

            Persona persona1 = new Persona("Reyna","Torrico");
            Persona persona2 = new Persona
            {
                Nombres = "Daniela",
                Apellidos = "Lopex",
                Edad = 21
            };


            Console.WriteLine(persona.NombresCompletos);
           Triangulo triangulo = new Triangulo();
            triangulo.Altura = 5;
            triangulo.Base = 6;
            triangulo.CalcularArea();
            Console.WriteLine(triangulo.CalcularArea());




            Console.WriteLine("Hola Mundo");
            Console.Read(); //Este permite mantener la consola abierta, sin este no abre la consola
        }
    }
}
