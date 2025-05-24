using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Class
{
    public abstract class Empleado
    {
        public string PrimerNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string NumeroSeguroSocial { get; set; }

        public Empleado(string primerNombre, string apellidoPaterno, string nss)
        {
            PrimerNombre = primerNombre;
            ApellidoPaterno = apellidoPaterno;
            NumeroSeguroSocial = nss;
        }

        public abstract double CalcularPagoSemanal();

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Empleado: {PrimerNombre} {ApellidoPaterno}, SeguroSocial {NumeroSeguroSocial} " );
            
        }

     }
 }
