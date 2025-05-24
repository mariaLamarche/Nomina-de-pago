using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Class
{
    public class EmpleadoPorComision : Empleado
    {
        public double VentasBrutas { get; set; }
        public double TarifaComision { get; set; }

        public EmpleadoPorComision(string primerNombre, string apellidoPaterno, string nss, double ventasBrutas, double tarifaComision)
            : base(primerNombre, apellidoPaterno, nss)
        {
            VentasBrutas = ventasBrutas;
            TarifaComision = tarifaComision;
        }

        public override double CalcularPagoSemanal()
        {
            return VentasBrutas * TarifaComision;
        }

        public void actualizarSalario(double nuevasVentas, double nuevaTarifa)
        {
            VentasBrutas = nuevasVentas;
            TarifaComision = nuevaTarifa;
        }


    }
}
