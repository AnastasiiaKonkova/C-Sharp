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

Console.WriteLine("Максимальное число: " + max); 
*/


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

// Задача 6: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int Threenum(int num)
{
    int des = num % 100 /10;
    return des;
}
Console.Write("Введите трехзначное число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
int res = Threenum(newnum);
if (newnum > 99 && newnum < 1000)
{
  Console.WriteLine(res); 
}
else
{
    Console.WriteLine("Ошибка, условие введено не верно!");
}
*/

//Без проверки

/*
int Threenum(int num)
{
    int des = num % 100 /10;
    return des;
}
Console.Write("Введите трехзначное число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
int res = Threenum(newnum);
Console.WriteLine(res); 
*/

//Задача 7.1: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Без функции
/*Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());

if (newnum > 99)
{
  string str = newnum.ToString();
    Console.WriteLine(str[2]); 
}
else
{
    Console.WriteLine("Нет третьего числа!");
}
*/

//Задача 7.2:C функцией

/* 
int Posnum(int num)
{   
    int minus = -1;
    string str = num.ToString();
    if (num > 99)
        Console.WriteLine(str[2]);
    else
        Console.WriteLine(minus);
    return num;
}
Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
Posnum(newnum);
*/

//Задача 8: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
void Day(int num)
{
    if ((num <= 8 &&num == 6)||(num <= 8 &&num == 7) )
        Console.WriteLine("Ура, этот день выходной!");
    else if (num >=1 && num <=5)
        Console.WriteLine("Будний день.");
    else 
        Console.WriteLine("Введено не верное число!");
}
Console.Write("Введите число (от 1 до 7): ");
int newnum = Convert.ToInt32(Console.ReadLine());
Day(newnum);
*/

// Задача 9. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* 
void palindrom (int num)
{
    int PerNum = 0;
    int delta = Math.Abs(num);
    while(delta > 0)
    {
        PerNum = PerNum * 10 + delta % 10;
        delta = delta/10;
    }
    if (Math.Abs(num) == PerNum)
    {
        Console.WriteLine("Введенное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Введенное число не является палиндромом.");
    }    
}

Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
palindrom(newnum);
*/

// Задача 10. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double Distance(double xA, double yA, double zA,double xB, double yB, double zB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)+ Math.Pow(zB - zA, 2));
    return length;
}
Console.Write("Введите х - координаты точки А: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите у - координаты точки А: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите z - координаты точки А: ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите х - координаты точки B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите y - координаты точки B: ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите z - координаты точки B: ");
double zB = Convert.ToDouble(Console.ReadLine());

double distanceBetweenAB = Distance(xA, yA,zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками в 3D пространстве составляет {distanceBetweenAB}.");
*/

// Задача 11. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void kyb ( int num)
{
    int temp = 1;
    while (temp <= num)
    {
    Console.Write(Math.Pow(temp,3) + " ");
    temp ++;
    }
}

Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Кубы от 1 до "+ newnum + ": ");
kyb (newnum);
*/