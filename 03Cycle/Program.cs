// С помощью цикла for (или while) выведите первые 10 чисел Фиббоначи

int n0 = 0;
int n1 = 1;
int n2;
Console.WriteLine(n0 + "\n" + n1);
for (int i = 2; i < 10; i++)
{
    n2 = n0 + n1;
    Console.WriteLine(n2 + " ");
    n0 = n1;
    n1 = n2;
}
Console.WriteLine("----\n");

// Используя цикл for, выведите все чётные числа от 2 до 20

for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}
Console.WriteLine("----\n");

// С помощью вложенных циклов for выведите таблицу умножения от 1 до 5
// Вывел два варианта таблицы 

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i * j}\t");
    }
    Console.WriteLine();
}
Console.WriteLine("----\n");

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}
Console.WriteLine("----\n");

// Задание 4

string password = "qwerty";
int result = 0;

do
{
    Console.WriteLine("Enter a password of 6 characters:");
    string checkPassword = Console.ReadLine();
    if ( checkPassword == password)
    {
        Console.WriteLine("Welcome!");
        Console.ReadLine();
        break;
    }
    Console.WriteLine("The password was entered incorrectly");
    //Console.ReadLine();

} while (++result < 6);



