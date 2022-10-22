double a, b, c, delta, x1, x2;

    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("-- equação do segundo grau --"); 
    Console.ResetColor();

     Console.ForegroundColor = ConsoleColor.Cyan;
     Console.Write("(a): ");
     a = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
     Console.Write("(b): ");
    b = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

     Console.ForegroundColor = ConsoleColor.Cyan;
     Console.Write("(c): ");
    c = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

Console.WriteLine();

if (a == 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Não é uma equação de segundo grau!");
    Console.ResetColor();
}

else
{
    delta = b * b - 4 * a * c;

    if (delta < 0)

    { 
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine ($"Como delta = {delta:N2}, a equação não possui raízes reais!");
        Console.ResetColor();
    }

    else

    {
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

        Console.WriteLine($"x1 = {x1:n2} e x2 = {x2:n2}");
    }

}
