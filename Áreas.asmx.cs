using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Áreas
{
    /// <summary>
    /// Descripción breve de Áreas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Áreas : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal cuadrado(decimal lado)
        {
            Procesos p = new Procesos();
            p.numero1 = lado;
            return p.cuadrado();
        }
        [WebMethod]
        public decimal triangulo(decimal bas, decimal alt)
        {
            Procesos p = new Procesos();
            p.numero1 = bas;
            p.numero2 = alt;
            return p.triangulo();
        }
        [WebMethod]
        public double circulo(double radio)
        {
            Procesos p = new Procesos();
            p.radio = radio;
            return p.circulo();
        }
    }
}