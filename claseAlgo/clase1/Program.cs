// See https://aka.ms/new-console-template for more information
int v1, v2;
string fig;
double area;
Console.WriteLine("Selecciona la figura que deseas en el area (circulo, cuadrado, triangulo, rectangulo)");

fig = Console.ReadLine()!;

if(fig == "circulo")
{
    Console.WriteLine("Ingresa el valor del radio");
    v1 = int.Parse(Console.ReadLine()!);

    area = Math.PI * Math.Pow(v1, 2);
    Console.WriteLine($"El area es {area}");


} else if (fig == "triangulo")
{
    Console.WriteLine("Ingresa el valor de la base");
    v1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Ingresa el valor de la altura");
    v2 = int.Parse(Console.ReadLine()!);

    area = (v1 * v2) / 2;
    Console.WriteLine($"El area es: {area}");
    
} else if (fig=="cuadrado")
{
    Console.WriteLine("Ingresa el valor del lado");
    v1 = int.Parse(Console.ReadLine()!);

    area = Math.Pow(v1, 2);
    Console.WriteLine($"El area es: {area}");

} else if (fig == "rectangulo")
{
    Console.WriteLine("Ingresa el valor de la base");
    v1 = int.Parse(Console.ReadLine()!);

    Console.WriteLine("Ingresa el valor de la altura");
    v2 = int.Parse(Console.ReadLine()!);

    area = (v1 * v2);
    Console.WriteLine($"El area es: {area}");

}
{
    Console.WriteLine("Ingresa otra figura");
}

