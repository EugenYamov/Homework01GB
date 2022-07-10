//Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число С");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA >= numberB && numberA >= numberC)
    Console.WriteLine($"Число {numberA} больше");

else if (numberB >= numberA && numberB >= numberC)
    Console.WriteLine($"Число {numberB} больше");

else if (numberC >= numberB && numberC >= numberA)
    Console.WriteLine($"Число {numberC} больше");

