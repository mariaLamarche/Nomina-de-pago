// See https://aka.ms/new-console-template for more information

using ConsoleApp2.Class;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Empleado> empleadoss = new List<Empleado>()
        {
         new EmpleadoAsalariado("Carlos", "Ramírez", "12345", 5000),
         new EmpleadoPorHoras("Pérez", "23456", 200, 42),
          new EmpleadoPorComision("Ana", "Gómez", "34567", 10000, 0.05),
          new EmpleadoAsalariadoPorComision("Luis", "Fernández", "45678", 8000, 0.07, 3000)
        };

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("SISTEMA DE GESTIÓN DE PAGOS DE EMPLEADOS");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1. Agregar empleado asalariado");
            Console.WriteLine("2. Mostrar información de empleados");
            Console.WriteLine("3. Actulizar Salario/Sueldo");
            Console.WriteLine("4. Salir");
            
            Console.Write("Seleccione una opción: ");
            string opcion =Console.ReadLine();
             Console.WriteLine($"Su opcion fue:{opcion}");

          switch (opcion)
          {
            case "1":
                    empleadoss.Add(new EmpleadoAsalariado("María", "López", "56789", 6000));
                    Console.WriteLine($"Nuevo empleado agregado con exito {empleadoss.Last()}");
                  
                    break;
            case "2":
                    VerEmpleados(empleadoss);
                break;
            case "3":
                    ActualizarEmpleado(empleadoss);
                break;
            case "4":
                salir = true;
                break;
            default:
                Console.WriteLine("Opción no válida. Intente nuevamente."); break;
          }
        }
    }

    static void VerEmpleados(List<Empleado> empleadoss) 
    {
        Console.WriteLine("=== LISTA DE EMPLEADOS ===");
        Console.WriteLine("-------------------------");

        foreach (Empleado emp in empleadoss)
        {
            emp.MostrarInformacion();

            // Mostrar información específica según el tipo de empleado
            if (emp is EmpleadoAsalariado asalariado)
            {
                Console.WriteLine($"Pago semanal: {emp.CalcularPagoSemanal():C2}\n");
            }
            else if (emp is EmpleadoPorHoras porHoras)
            {
                Console.WriteLine($"Pago semanal: {emp.CalcularPagoSemanal():C2}\n");
            }
            else if (emp is EmpleadoPorComision porComision)
            {
                Console.WriteLine($"Pago semanal: {emp.CalcularPagoSemanal():C2}\n");
            }
            else if (emp is EmpleadoAsalariadoPorComision asalariadoComision)
            {
                Console.WriteLine($"Pago semanal: {emp.CalcularPagoSemanal():C2}\n");
            }

            Console.WriteLine("-------------------------");
        }
    }


    static void ActualizarEmpleado(List<Empleado> empleadoss) 
    {

        Console.Clear();
        Console.WriteLine("=== MODIFICAR SALARIO ===");

        // 1. Mostrar lista numerada de empleados
        for (int i = 0; i < empleadoss.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {empleadoss[i].PrimerNombre} {empleadoss[i].ApellidoPaterno} - {empleadoss[i].GetType().Name}");
        }

        Console.Write("\nSeleccione el empleado (número): ");
        if (!int.TryParse(Console.ReadLine(), out int seleccion) || seleccion < 1 || seleccion > empleadoss.Count)
        {
            Console.WriteLine("Selección inválida!");
            return;
        }

        var empleado = empleadoss[seleccion - 1];

        // 2. Mostrar información actual
        Console.WriteLine("\nEmpleado seleccionado:");
        empleado.MostrarInformacion();
        Console.WriteLine($"Salario actual: {empleado.CalcularPagoSemanal():C2}");

        // 3. Pedir nuevo valor según tipo de empleado
        try
        {
            switch (empleado)
            {
                case EmpleadoAsalariado asalariado:
                    Console.Write("\nIngrese nuevo salario semanal: ");
                    if (double.TryParse(Console.ReadLine(), out double salarioSemanal))
                    {
                        asalariado.actualizarSalario(salarioSemanal);
                    }
                    break;

                case EmpleadoPorHoras porHoras:
                    Console.Write("\nIngrese nuevo sueldo por hora: ");
                    if (double.TryParse(Console.ReadLine(), out double nuevoSueldoHora))
                    {
                        porHoras.SueldoPorHora = nuevoSueldoHora;
                    }

                    Console.Write("Ingrese horas trabajadas: ");
                    if (int.TryParse(Console.ReadLine(), out int nuevasHorasTrabajadas))
                    {
                        porHoras.HorasTrabajadas = nuevasHorasTrabajadas;
                    }
                    break;

                case EmpleadoPorComision porComision:
                    Console.Write("\nIngrese nuevo porcentaje de comisión (ej. 0.05 para 5%): ");
                    if (double.TryParse(Console.ReadLine(), out double nuevaTarifa))
                    {
                        porComision.TarifaComision = nuevaTarifa;
                    }

                    Console.Write("Ingrese ventas brutas: ");
                    if (double.TryParse(Console.ReadLine(), out double nuevasVentas))
                    {
                        porComision.VentasBrutas = nuevasVentas;
                    }
                    break;

                case EmpleadoAsalariadoPorComision asalComision:
                    Console.Write("\nIngrese nuevo salario base: ");
                    if (double.TryParse(Console.ReadLine(), out double nuevoSalarioBase))
                    {
                        asalComision.SalarioBase = nuevoSalarioBase;
                    }

                    Console.Write("Ingrese nuevo porcentaje de comisión: ");
                    if (double.TryParse(Console.ReadLine(), out double nuevaTarifaA))
                    {
                        asalComision.TarifaComision = nuevaTarifaA;
                    }

                    Console.Write("Ingrese ventas brutas: ");
                    if (double.TryParse(Console.ReadLine(), out double nuevasVentasA))
                    {
                        asalComision.VentasBrutas = nuevasVentasA;
                    }
                    break;
            }

            Console.WriteLine("\n¡Salario actualizado con éxito!");
            Console.WriteLine($"Nuevo salario: {empleado.CalcularPagoSemanal():C2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido");
        }







    }
} 











