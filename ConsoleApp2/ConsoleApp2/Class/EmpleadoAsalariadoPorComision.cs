using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Class
{
    public class EmpleadoAsalariadoPorComision : Empleado
    {
        public double SalarioBase { get; set; }
        public double VentasBrutas { get; set; }
        public double TarifaComision { get; set; }

        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string nss, double ventasBrutas, double tarifaComision, double salarioBase)
            : base(primerNombre, apellidoPaterno, nss)
        {
            SalarioBase = salarioBase;
        }

        public override double CalcularPagoSemanal()
        {
            return (VentasBrutas * TarifaComision) + SalarioBase + (SalarioBase * 0.10);
        }
        public void actualizarSalario(double nuevasVentasA, double nuevaTarifaA, double nuevoSalarioBase)
        {
            VentasBrutas = nuevasVentasA;
            TarifaComision = nuevaTarifaA;
            SalarioBase = nuevoSalarioBase;
        }


    }
}
