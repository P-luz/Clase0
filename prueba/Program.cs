using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int daysUntilExpiration;
        int discountPercentage;
        do
        {
            // Generar un número aleatorio entre 0 y 11
            daysUntilExpiration = random.Next(12);
            discountPercentage = 0;
            // Mostrar el número generado
            Console.WriteLine("\nNúmero generado: " + daysUntilExpiration);
            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("¡Tu suscripción ha expirado!");
            }
            else if (daysUntilExpiration == 1)
            {
                discountPercentage = 20;
                Console.WriteLine("¡Tu suscripción vence en un día!\n¡Renueva ahora y ahorra un " + discountPercentage + " %!");
            }
            else if (daysUntilExpiration <= 5)
            {
                discountPercentage = 10;
                Console.WriteLine("Tu suscripción vence en " + daysUntilExpiration + " días.\n¡Renueva ahora y ahorra un " + discountPercentage + " %!");
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Tu suscripción vencerá pronto. ¡Renueva ahora!");
            }
            else
            {
                Console.WriteLine("Tu suscripción está activa por un buen tiempo.");
            }
            // Pedir al usuario que presione una tecla para ejecutar de nuevo
            Console.WriteLine("\nPresiona una tecla para ejecutar de nuevo o 'Esc' para salir.");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);  // El programa se repite hasta que se presiona 'Esc'
    }
}
