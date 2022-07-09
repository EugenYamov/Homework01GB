//Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Число А больше, чем B");
}

if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}

else
{
    Console.WriteLine("Число B больше, чем А");
}