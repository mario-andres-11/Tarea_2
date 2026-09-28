using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("   CÁLCULO DE AUMENTO SALARIAL");
            Console.WriteLine("========================================\n");

            Console.Write("Ingrese la cédula del empleado: ");
            string cedula = Console.ReadLine();

            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            int tipoEmpleado;
            while (true)
            {
                Console.Write("Ingrese el tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
                if (int.TryParse(Console.ReadLine(), out tipoEmpleado) && tipoEmpleado >= 1 && tipoEmpleado <= 3)
                {
                    break;
                }
                Console.WriteLine("Opción inválida. Debe ser 1, 2 o 3.");
            }

            double horasLaboradas;
            while (true)
            {
                Console.Write("Ingrese la cantidad de horas laboradas: ");
                if (double.TryParse(Console.ReadLine(), out horasLaboradas) && horasLaboradas >= 0)
                {
                    break;
                }
                Console.WriteLine("Por favor ingrese un número válido mayor o igual a 0.");
            }

            double precioHora;
            while (true)
            {
                Console.Write("Ingrese el precio por hora: ");
                if (double.TryParse(Console.ReadLine(), out precioHora) && precioHora >= 0)
                {
                    break;
                }
                Console.WriteLine("Por favor ingrese un monto válido mayor o igual a 0.");
            }

            double salarioOrdinario = horasLaboradas * precioHora;
            double porcentajeAumento = 0;
            string nombreTipoEmpleado = "";

            switch (tipoEmpleado)
            {
                case 1:
                    porcentajeAumento = 0.15;
                    nombreTipoEmpleado = "Operario";
                    break;
                case 2:
                    porcentajeAumento = 0.10;
                    nombreTipoEmpleado = "Técnico";
                    break;
                case 3:
                    porcentajeAumento = 0.05;
                    nombreTipoEmpleado = "Profesional";
                    break;
            }

            double aumento = salarioOrdinario * porcentajeAumento;
            double salarioBruto = salarioOrdinario + aumento;
            double deduccionCCSS = salarioBruto * 0.0917;
            double salarioNeto = salarioBruto - deduccionCCSS;

            Console.WriteLine("\n========================================");
            Console.WriteLine("        DETALLE DE LA TRANSACCIÓN");
            Console.WriteLine("========================================");
            Console.WriteLine($"Cedula: {cedula}");
            Console.WriteLine($"Nombre Empleado: {nombre}");
            Console.WriteLine($"Tipo Empleado: {nombreTipoEmpleado}");
            Console.WriteLine($"Salario por Hora: {precioHora:C2}");
            Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
            Console.WriteLine($"Salario Ordinario: {salarioOrdinario:C2}");
            Console.WriteLine($"Aumento: {aumento:C2}");
            Console.WriteLine($"Salario Bruto: {salarioBruto:C2}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS:C2}");
            Console.WriteLine($"Salario Neto: {salarioNeto:C2}");
            Console.WriteLine("========================================\n");


            Console.Write("¿Desea procesar otro empleado? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToUpper();
            if (respuesta != "S" && respuesta != "SI")
            {
                continuar = false;
            }
        }

        Console.WriteLine("\nPrograma finalizado. Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}