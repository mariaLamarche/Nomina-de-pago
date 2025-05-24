using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2.Class
{
    public class EmpleadoAsalariado : Empleado
    {
        public double SalarioSemanal { get; set; }

        public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string nss, double salarioSemanal)
            : base(primerNombre, apellidoPaterno, nss)
        {
            SalarioSemanal = salarioSemanal;
        }

        public override double CalcularPagoSemanal()
        {
            return SalarioSemanal;
        }
        public void actualizarSalario(double nuevoSalario)
        {
            SalarioSemanal = nuevoSalario;
        }

        


    }
}
