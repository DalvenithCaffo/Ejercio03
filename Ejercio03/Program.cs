// See https://aka.ms/new-console-template for more information

#region Calculadora
/*
 * string operacion = "";
int resultado = 0;
Console.WriteLine("Ingrese la operación a ejecutar");
Console.WriteLine("* Sumar (+): ");
Console.WriteLine("* Restar (-): ");
Console.WriteLine("* Multiplicar (x): ");
Console.WriteLine("* Dividir (/): ");

operacion = Console.ReadLine();

Console.WriteLine("Ingrese primer numero:");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese Segundo numero:");
int numero2 = Convert.ToInt32(Console.ReadLine());

switch (operacion) {
    case "+": 
        resultado = numero1 + numero2;
        Console.WriteLine("El resultado de la suma es: "+ resultado);
        break;
    case "-":
        resultado = numero1 - numero2;
        Console.WriteLine("El resultado de la resta es: " + resultado);
        break;
    case "/":
        if (numero2 == 0) {
            Console.WriteLine("No se puede dividir entre Cero");
        }else {
            resultado = numero1 / numero2;
            Console.WriteLine("El resultado de la division es: " + resultado);
        }
        
        break;
    case "x":
        resultado = numero1 * numero2;
        Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
        break;
    default:
        Console.WriteLine("Error datos");
        break;           
}
*/
#endregion

#region EstacionMes
/*int numMes = 0;
String estacionMes = "";

Console.WriteLine("Ingrese mes (1-12):");
numMes = Convert.ToInt32(Console.ReadLine());

switch (numMes)
{
    case 1:
    case 2:
    case 3:
        estacionMes = "Verano";
        break;
    case 4:
    case 5:
    case 6:
        estacionMes = "Otoño";
        break;
    case 7:
    case 8:
    case 9:
        estacionMes = "Invierno";
        break;
    case 10:
    case 11:
    case 12:
        estacionMes = "Primavera";
        break;
    default:
        estacionMes = "No existe el mes";
        break;
}
Console.WriteLine("la estacion del mes "+numMes+" es " + estacionMes);
*/
#endregion

Console.WriteLine("****************** MENU ************");
Console.WriteLine("\n");
Console.WriteLine("1. Calcular el área");
Console.WriteLine("2. Calcular el volumen");
Console.WriteLine("3. Salir");

int opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");
Console.WriteLine("Ingrese el lado del cuadrado:");
int lado = Convert.ToInt32(Console.ReadLine());

switch (opcion) { 
    case 1:
        int area = lado * lado;
        Console.WriteLine("El área del cuadro es: " + area);
        break;
    case 2:
        int volumen = lado * lado * lado;
        Console.WriteLine("El volumen del cuadro es: " + volumen);
        break;
    case 3:
        Console.WriteLine("Saliendo!");
        break; 
    default:
        Console.WriteLine("Opcion incorrecta!");
        break;
}

Console.WriteLine("Hello, World!!!!");

