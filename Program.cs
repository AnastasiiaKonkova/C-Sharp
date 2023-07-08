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

// Задача 12: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* int level (int A, int B)
{
    int result = 1;
    for (int step = 1; step <= B; step++)
    {
        result *= A;
    }
    if (B == 0) result = 1;
    if (B == 1) result = A;
    return result;
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int numC = level(numA,numB);
Console.WriteLine($"{numA} в степени {numB} = {numC}");
*/

//Вариант 2 с отрицательной степенью 

/* void level (int A, int B)
{
    int result = 1;
    for (int step = 1; step <= Math.Abs(B); step++)
    {
        result *= A;
    }
    
    if (B > 1)
    {
        Console.WriteLine("$ Число А в степени В = {result}");
    }
    else if (B == 0) 
    {
        Console.WriteLine("$ Число А в степени В = 0");
    }
    else if (B == 1) 
        Console.WriteLine("$ Число А в степени В = {A}");
    else 
    {
        Console.WriteLine($" Число А в степени В = 1/{result}");
    }
}

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

level (numA,numB );
*/

// Задача 13: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/*
int summ(int num)
{
    int result = 0;
    int endNum = 0;
    while(Math.Abs(num) > 0)
    {
        endNum = num % 10;
        result += endNum;
        num /= 10;
    }
    return Math.Abs(result);
}

Console.Write("Введите число: ");
int newnum = Convert.ToInt32(Console.ReadLine());

int summNum = summ(newnum);
Console.WriteLine($"Сумма цифр в числe {newnum} = {summNum}");
*/

// Задача 14: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*
int[]CreateArray(int size)
{
    
    int[]array = new int[size];
    for (int i = 0; i < size; i++)
    {
    Console.Write($"Введите число №{i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}  
void ShowArray(int[] array)
{
   
    for (int i = 0;i<array.Length;i++)
    {
        if (i==0) Console.Write("[" + array[i] + ",");
        else if (i==array.Length-1) Console.Write(array[i]+"]");
        else
        Console.Write(+ array[i]+",");
    }
}
Console.Write("Введите размер массива: ");
int newnum = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(newnum);
ShowArray(myArray);
*/

// Создание рандомного массива. Общее для задач 15,16 и 17

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
         array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

// Вывод массива в терминал.
void ShowArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}
*/

// Задача 15: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
int CountArray(int[]array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if( array [i] % 2 == 0 )
            count++;
    return count;
}

int min = 100;
int max = 999;

Console.Write("Введите колличество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int countNum = CountArray(myArray);
Console.WriteLine($"Четных чисел в массиве - {countNum} шт.");
*/

// Задача 16: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int sumArray(int[]array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//         if( i % 2 == 1 )
//             sum+=array[i];
//     return sum;
// }

//Вариант 2
/* int sumArray(int[]array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
            sum+=array[i];
    return sum;
}


Console.Write("Введите колличество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int sumNum = sumArray(myArray);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumNum}");
*/

// Задача 17: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
double[] CreateRandomArrayDouble(int size)
{
    double[] array = new double[size];
    {
    for(int i = 0; i < size; i++)
       array[i] = new Random().Next(100) +  Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

double DeltaD(double[]array)
{
    double numMin = array[0];
    double numMax = array[0];
    double numDel = 0;
    for (int x = 0; x < array.Length; x++)
        if(array[x] < numMin) 
        numMin = array[x];
        else if(array[x] > numMax)
        numMax = array[x];
    numDel = numMax - numMin;
    return numDel;
}

void ShowArrayD(double[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write(array [i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите колличество элементов в массиве: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArrayDouble(sizeArray);
ShowArrayD(myArray);

double deltaNum = DeltaD(myArray);
Console.WriteLine($"Разница между максимальным значением и минимальным: {deltaNum}");
*/

//Задача 18: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//P.s. Без создания массива

/*
void CountNum(int size)
{
    int count = 0;
    for (int i = 0; i < size;i++ )
    {
        Console.Write($"Введите число №{i+1}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
    }
    Console.Write($"Чисел > 0 введено {count} шт.");
}

Console.Write("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
CountNum(M);
*/

//Задача 19: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/* 
Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = 0;
double y = 0;
if ((k1 == k2) && (b1 == b2))
{
Console.Write("Ошибка! Причина: Прямые совпадают.");
}
else if (k1==k2)  
{
Console.Write("Ошибка! Причина: Прямые параллельны.");
}
else
{
x=(b2-b1)/(k1-k2);  
y=(k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine($"Координаты пересечения прямых X: {Math.Round(x,2)}, Y: {Math.Round(y,2)}");
}
*/

// Задача 20. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
double[,] CreateArray()
{   
    Console.Write("Input a number of rows: ");
    int rowsM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columnsN = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input of min number: ");
    int minNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input of max number: ");
    int maxNum = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rowsM, columnsN];
    for(int i = 0; i < rowsM ; i++)
        for(int j = 0; j < columnsN; j++)
            array[i,j] = new Random().Next(minNum,maxNum+1) +  new Random().NextDouble();
    return array;
}

void Show2dArrayDouble(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j],2)+"  ");
        Console.WriteLine(" ");
    }
    Console.WriteLine();
}
double[,] myArray = CreateArray();
Show2dArrayDouble(myArray);
*/

// Задача 21. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)    
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1, 101);
    return array;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }

}

void IndexArray (int[,] array, int rowsIndex, int columnsIndex)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
            if (i == rowsIndex && j == columnsIndex)
            Console.Write($"Numder {array[rowsIndex,columnsIndex]} of index = [{rowsIndex},{columnsIndex}]");
        }
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index of row: ");
int rowsIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index of columns: ");
int columnsIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("");
Console.WriteLine("Random array from 1 to 100:"+"\t");
int[,] myArray = CreateRandom2DArray(rows, columns);
Show2DArray(myArray);
Console.WriteLine("");

if (rows-1 < rowsIndex||columns-1 < columnsIndex)
Console.Write($"Error! Index [{rowsIndex},{columnsIndex}] more array.");
else
IndexArray(myArray, rowsIndex, columnsIndex);
*/

// Задача 22. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/* 
int[,] CreateRandom2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)    
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(1, 11);        
    
    return array;

}   

void Show2DArray(int[,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)  
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void averageColumns(int[,] array, int rows)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double average = 0; 
        for(int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i,j];
        }
        average = Math.Round (average/rows,2);
        Console.Write(average + " ");
    }
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandom2DArray(rows, columns);
Show2DArray(myArray);
averageColumns(myArray,rows);
*/