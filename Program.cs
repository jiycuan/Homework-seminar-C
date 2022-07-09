// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

/*
Console.Write ("Введите цифру: ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите ещё одну цифру: ");
int number_b = Convert.ToInt32(Console.ReadLine());
int max, min;

if (number_a == number_b)
    {
        Console.WriteLine("Числа равны");
    }
else 
    {
    if (number_a > number_b)
    {
        max = (number_a);
        min = (number_b);
    }
    else 
    {
        max = (number_b);
        min = (number_a);
    }
    
    Console.Write("Максимальное число: " + max + ", ");
    Console.Write("Минимальное число: " + min);
    Console.WriteLine();
    }
*/



// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write ("Введите цифру: ");
int number_a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите ещё одну цифру: ");
int number_b = Convert.ToInt32(Console.ReadLine());
Console.Write ("И введите последнюю цифру: ");
int number_c = Convert.ToInt32(Console.ReadLine());
int max;

if (number_a > number_b)
    {
        max = number_a;
    }
else 
    {
        max = number_b;
    }
    if (max > number_c)
        {
        }
    else
        {
            max = number_c;
        }
Console.WriteLine("Максимальное число: " + max);
*/



// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write ("Введите цифру: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number % 2) == 0)
    {
        Console.WriteLine("Число чётное");
    }
else
    {
        Console.WriteLine("Число нечётное");
    }
*/



// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
/*
Console.Write ("Введите цифру: ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 2;

if (N < 1)
    {
        Console.WriteLine("В условии же написано - от 1 до N, а значит N не может быть меньше единицы, умник!");
    }
else
    {

     while (N > temp)
     {
        Console.Write(temp + ", ");
        temp = (temp + 2);
     }
    }
Console.WriteLine();
*/