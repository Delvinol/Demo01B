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



        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }


        public int x1 { get; set; }
        public int x2 { get; set; }

        public int x3 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }
        public int y3 { get; set; }
        public double perimetro { get; set; }
        public double area { get; set; }

        public Triangulo(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        //Creación de métodos
        public int CalcularAreaViejo()
        {
            return (Base * Altura) / 2;
        }

       public void CalcularLados()
        {
            a = CalcularDistancia(x1, y1, x2, y2);
            b = CalcularDistancia(x2, y2, x3, y3);
            c = CalcularDistancia(x3, y3, x1, y1);
            perimetro = CalcularPerimetro(a,b,c);
            area = CalcularArea(a,b,c, perimetro);

        }
        private double CalcularPerimetro(double a, double b, double c)
        {
            return a+b+c ;
        }

        private double CalcularDistancia(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public double CalcularArea(double a, double b, double c, double perimetro)
        {
       
            
            return Math.Sqrt(perimetro * (perimetro - a) * (perimetro - b) * (perimetro - c));
            
        }
    }
}
