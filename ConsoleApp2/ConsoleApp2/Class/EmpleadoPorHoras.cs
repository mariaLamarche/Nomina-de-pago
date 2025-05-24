using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Class
{
    public class EmpleadoPorHoras : Empleado
    {
        public double SueldoPorHora { get; set; }
        public double HorasTrabajadas { get; set; }

        public EmpleadoPorHoras(string apellidoPaterno, string nss, double sueldoPorHora, double horasTrabajadas)
            : base("SinNombre", apellidoPaterno, nss)
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override double CalcularPagoSemanal()
        {
            if (HorasTrabajadas <= 40)
                return SueldoPorHora * HorasTrabajadas;
            else
                return (SueldoPorHora * 40) + (SueldoPorHora * 1.5 * (HorasTrabajadas - 40));
        }
        public void actualizarSueldo( double nuevoPorHora, int nuevasHorasTrabajadas)
        {
            SueldoPorHora = nuevoPorHora;
            HorasTrabajadas = nuevasHorasTrabajadas;
        }


    }
}
