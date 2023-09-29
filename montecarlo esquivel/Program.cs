using System;

class Program
{
    static void Main()
    {
        Console.Title = "Estimación de Pi con Método de Montecarlo";
        Console.WriteLine("Presiona Enter para estimar Pi o Esc para salir.");

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var key = Console.ReadKey(intercept: true).Key;
                if (key == ConsoleKey.Enter)
                {
                    EstimarPi(); // Llama a la función para estimar Pi cuando se presiona Enter
                }
                else if (key == ConsoleKey.Escape)
                {
                    break; // Sale del programa si se presiona Esc
                }
            }
        }
    }

    static void EstimarPi()
    {
        Random random = new Random();
        int totalPuntos = 1000000; // Número total de puntos a generar
        int puntosDentroCirculo = 0; // Inicializa el contador de puntos dentro del círculo

        for (int i = 0; i < totalPuntos; i++)
        {
            double x = random.NextDouble(); // Genera una coordenada x aleatoria entre 0 y 1
            double y = random.NextDouble(); // Genera una coordenada y aleatoria entre 0 y 1

            // Comprueba si el punto (x, y) está dentro del círculo unitario
            if (x * x + y * y <= 1)
            {
                puntosDentroCirculo++; // Incrementa el contador si el punto está dentro del círculo
            }
        }

        double estimacionPi = 4.0 * puntosDentroCirculo / totalPuntos; // Calcula la estimación de Pi

        // Muestra los resultados con comentarios explicativos
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Puntos dentro del círculo: {puntosDentroCirculo}");
        Console.WriteLine($"Puntos fuera del círculo: {totalPuntos - puntosDentroCirculo}");
        Console.WriteLine($"Estimación de Pi: {estimacionPi}");
        Console.WriteLine("--------------------------------------------------");
    }
}



