using System;
using System.Collections.Generic;

namespace trabajo_semana_2;

internal class Program
{
	private static void Main(string[] args)
	{
		List<string> nombres = new List<string>();
		List<string> cedulas = new List<string>();
		List<string> sueldos = new List<string>();
		int opcion;
		do
		{
			MostrarMenu();
			opcion = Convert.ToInt32(Console.ReadLine());
			switch (opcion)
			{
			case 1:
				Console.Clear();
				AgregarEmpleado(nombres, cedulas, sueldos);
				break;
			case 2:
				MostrarRegistros(nombres, cedulas, sueldos);
				break;
			case 3:
				Console.WriteLine("Saliendo del programa.");
				break;
			default:
				Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
				break;
			}
		}
		while (opcion != 3);
	}

	private static void MostrarMenu()
	{
		Console.WriteLine("Bienvenido al sistema de aumento salarial de empleados");
		Console.WriteLine("1. Agregar empleado");
		Console.WriteLine("2. Mostrar registros");
		Console.WriteLine("3. Salir");
	}

	private static void AgregarEmpleado(List<string> nombres, List<string> cedulas, List<string> sueldos)
	{
		Console.WriteLine("Ingrese los datos para un nuevo empleado:");
		Console.Write("Nombre: ");
		string nombre = Console.ReadLine();
		nombres.Add(nombre);
		Console.Write("Número de cédula: ");
		string cedula = Console.ReadLine();
		cedulas.Add(cedula);
		Console.Write("Sueldo: ");
		double sueldo = Convert.ToDouble(Console.ReadLine());
		Console.Clear();
		Console.WriteLine("Elige la ocupación:");
		Console.WriteLine("1. Operario");
		Console.WriteLine("2. Técnico");
		Console.WriteLine("3. Profesional");
		int trabajo = Convert.ToInt32(Console.ReadLine());
		Console.Clear();
		double impuestoARestar = 0.0;
		double sueldoAumento = 0.0;
		double sueldoAumentado = 0.0;
		double sueldoTotal = 0.0;
		switch (trabajo)
		{
		case 1:
			sueldoAumento = sueldo * 0.15;
			sueldoAumentado = sueldo + sueldoAumento;
			impuestoARestar = sueldoAumentado * 0.13;
			sueldos.Add((sueldoAumentado - impuestoARestar).ToString());
			break;
		case 2:
			sueldoAumento = sueldo * 0.1;
			sueldoAumentado = sueldo + sueldoAumento;
			impuestoARestar = sueldoAumentado * 0.13;
			sueldos.Add((sueldoAumentado - impuestoARestar).ToString());
			break;
		case 3:
			sueldoAumento = sueldo * 0.5;
			sueldoAumentado = sueldo + sueldoAumento;
			impuestoARestar = sueldoAumentado * 0.13;
			sueldos.Add((sueldoAumentado - impuestoARestar).ToString());
			break;
		default:
			Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
			break;
		}
	}

	private static void MostrarRegistros(List<string> nombres, List<string> cedulas, List<string> sueldos)
	{
		Console.WriteLine("Registros:");
		for (int i = 0; i < nombres.Count; i++)
		{
			Console.WriteLine("Nombre: " + nombres[i] + ", Cédula: " + cedulas[i] + ", Sueldo: " + sueldos[i]);
		}
	}
}
