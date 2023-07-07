// Задача 1. 
// Необходимо создать два строковых массива (один заполнить, второй для заполнения).
// Написать цикличный метод, который проверяет каждый эллемент массива на соответствие условию (длинна элемента не более 3 символов), если условие выполняется то элемент вносится в массив 2. Цикл работает до тех пор, пока колличество элемментов в массиве не закончится.
// Написать метод для вывода полученного массива.

/*
string[] arrayOne = new string[6] {"530", "083", "end", "world", "hello" , ".,k"};
string[] arrayTwo = new string[arrayOne.Length];

void newArrayString3(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
        if(arrayOne[i].Length < 4)
        {
            arrayTwo[count] = arrayOne[i];
            count++;
        }
    }
}

void outputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
Console.WriteLine();
}

newArrayString3(arrayOne, arrayTwo);
outputArray(arrayTwo);
*/

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* 
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
  Console.WriteLine("Число большее " + num1 + ", а меньшее " + num2); 
}
else
{
    Console.WriteLine("Число большее " + num2 + ", а меньшее " + num1);
}
*/

//Задача 3: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/* 
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > num1) max = num2;
if (num3 > num2) max = num3;

Console.WriteLine("Максимальное число: " + max); */


// Задача 4: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/* 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
Console.WriteLine("Введенное число четное");
}
else
{
Console.WriteLine("Введенное число нечетное");
}
*/

// Задача 5: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/* 
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= num)
{
  Console.Write(current + " ");
  current+=2;
}
*/