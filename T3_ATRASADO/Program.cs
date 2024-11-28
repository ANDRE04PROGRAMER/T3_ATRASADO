using T3_ATRASADO;
using System.ComponentModel.Design;
string option, enfermedad = "";
int menu_option, x = 0, precio = 0;
Estudiante e = new Estudiante();
Console.WriteLine("Inserte nombre del Estudiante: ");
e.nombre = Console.ReadLine();
Console.WriteLine("Inserte codigo del Estudiante: ");
e.codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserte Universidad del Estudiante");
e.universidad = Console.ReadLine();
Cita c = new Cita();
c.estudiante = e;
c.numero = x;
c.enfermedad = enfermedad; c.precio = precio;
do
{
    do
    {
        Console.Clear();
        Console.WriteLine(e.ToString());
        Console.WriteLine("MENU:");
        Console.WriteLine("1. Crear Cita");
        Console.WriteLine("2. Listar Citas");
        Console.WriteLine("3. Modificar Citas");
        Console.WriteLine("0. Salir");
        Console.Write("Seleccione una opción: ");
        option = Console.ReadLine();
        if (int.TryParse(option, out menu_option)) ;
    } while (false);
    switch (menu_option)
    {
        case 1:
            Console.Clear();
            x++;
            c.estudiante = e;
            Console.WriteLine($"Cita creada, {e.nombre}");
            Console.WriteLine($"N° de cita: {x}");
            c.numero = x;
            Console.WriteLine("Inserte los siguienes datos: ");
            Console.Write("Enfermedad: ");
            enfermedad = Console.ReadLine();
            c.enfermedad = enfermedad;
            Console.Write("Monto a pagar: ");
            precio = int.Parse(Console.ReadLine());
            c.precio = precio;
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine(c.ToString());
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        case 0:
            Console.Clear();
            Console.WriteLine("El programa ha terminado...");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opción no válida.");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
    }

} while (menu_option != 0);

