using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Áreas
{
    public class Procesos
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }
        public double radio { get; set; }
        public decimal cuadrado()
        {
            return numero1 * numero1;
        }
        public decimal triangulo()
        {
            return (numero1 * numero2) / 2;
        }
        public double circulo()
        {
            return (radio * radio) * 3.1416;
        }
    }
}