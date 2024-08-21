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
            /*
            //Para crear un objeto NombreClase NombreInstancia = new NombreClase
            Persona persona = new Persona();
            //Para dar valores:
            persona.Nombres = "Delvin Onil";
            persona.Apellidos = "Larez Mauricioo";

            persona.AsignarNombresCompletos();

            Persona persona1 = new Persona("Reyna","Torrico");
            Persona persona2 = new Persona
            {
                Nombres = "Daniela",
                Apellidos = "Lopex",
                Edad = 21
            };


            Console.WriteLine(persona.NombresCompletos);


            Estudiante estudiante = new Estudiante
            {
                Nombres = "Dave",
                Apellidos = "Larez",
                Edad = 21,
                Nota = 20
            };

            Profesor profe = new Profesor();




            Triangulo triangulo = new Triangulo();
            triangulo.Altura = 5;
            triangulo.Base = 6;
            triangulo.CalcularAreaViejo();
            Console.WriteLine(triangulo.CalcularAreaViejo());




            Console.WriteLine("Hola Mundo");*/

            Triangulo triangulo = new Triangulo(1,2,3,4,5,6);
            triangulo.CalcularLados();
            Console.WriteLine($"Distancia a: {triangulo.a}");
            Console.WriteLine($"Distancia b: {triangulo.b}");
            Console.WriteLine($"Distancia c: {triangulo.c}");

        
            Console.WriteLine($"Perimetro s: {triangulo.perimetro}");
            Console.WriteLine($"Area s: {triangulo.area}");

       
            Console.Read(); //Este permite mantener la consola abierta, sin este no abre la consola
        }
    }
}
