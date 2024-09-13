Console.WriteLine("\n*******Aleatorio*******");
/*Este código simula el lanzamiento de un dado, generando un número aleatorio entre 1 y 6 y luego lo muestra en la consola.*/
var dados = new Random();
int roll = dados.Next(1, 7);
Console.WriteLine(roll);
/* otra manera con un for*/
/* otra manera en una sola linea, feractorizacion*/
Console.WriteLine(new Random().Next(1, 7));
Console.WriteLine("\n*******Clase Math*******"); 
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue); 
Console.Clear();
Console.WriteLine("\n*******Lógica de decisión con instrucciones if*******");
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
Console.WriteLine("\n******* otra forma Lógica de decisión con instrucciones if*******");

/*
var total = 0;
var tirada = 1;
Console.WriteLine("Dice roll:");
for (int i = 0; i<2; i++)
{
    tirada = dice.Next(1,7);
    Console.Write ($" {tirada}+");
    total = total+tirada;
}
Console.Write($"Total: {total}");
*/
if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
// otra forma //
if (total > 14)
    Console.WriteLine("You win!");
else
    Console.WriteLine("Sorry, you lose.");
Console.WriteLine('a'!='b');
// otra forma //
total = 0;
int [] tirada1 = new int [3];
for (int i = 0;i<3;i++)
{
    tirada1[i]= dice.Next(1,7);
    Console.Write($"{tirada1[i]} {(i<2? "+":"")}");
    total = total + tirada1[i];
}
// otra forma //
Console.WriteLine("Aqui vamos por otro");
if ((tirada1[0] == tirada1[1]) || (tirada1[1] == tirada1[2]) || (tirada1[2] == tirada1[0]))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
// otra forma //
