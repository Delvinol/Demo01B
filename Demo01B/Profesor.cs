using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
   
    public class Profesor : Persona
    {
        public double Sueldo { get; set; }

        public double SueldoNeto(double sueldo)
        {
            double dcto = 0;
            double SueldoNeto = 0;
            if (sueldo > 0 & sueldo <= 2000)
            {
                dcto = 0.08 * sueldo;
                SueldoNeto = sueldo - dcto;
                return SueldoNeto;
            }
            else if (sueldo > 2000 & sueldo < 5000)
            {
                dcto = 0.14 * sueldo;
                SueldoNeto = sueldo - dcto;
                return SueldoNeto;
            }
            else
            {
                dcto = 0.3 * sueldo;
                SueldoNeto = sueldo - dcto;
                return SueldoNeto;
            }
        }


    }

 


}
