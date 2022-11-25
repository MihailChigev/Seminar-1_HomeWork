//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите три числа:  ");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());

if (numberA > numberB)
if (numberA > numberC)
{
    Console.WriteLine("максимальное из этих чисел " + numberA);
}
if (numberB > numberC)
if (numberB > numberA)
{
    Console.WriteLine("максимальное из этих чисел " + numberB);
}
if (numberC > numberA)
if (numberC > numberB)
{
    Console.WriteLine(" максимальное из этих чисел " + numberC);

}



