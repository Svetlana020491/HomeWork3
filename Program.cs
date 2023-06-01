﻿int InputNumber(string text) // метод для ввода начальной информации 
        {
            Console.WriteLine(text);
            return Convert.ToInt32(Console.ReadLine());}

void Task19()
{
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
Console.WriteLine("Задача 19");
int number = InputNumber("Введите пятизначное число"); 

int numberA = number /10000; //1
int numberB = number /1000 % 10; //2
int numberC = number /100 % 10 *1; //5
int numberD = number /10 % 100 %10; //2
int numberE = number /10000 %10; //1
// Console.WriteLine($"{numberA} + {numberB} + {numberC} + {numberD} +{numberE}");
int coup = numberA*10000 + numberB*1000 + numberC*100 + numberD*10 + numberE;
if (number ==coup)
{
    Console.WriteLine($"{number} является палиндромом");
}
else
{
    Console.WriteLine($"{number} не палиндром");
    }
}

void Task21()
{
//Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Задача 21");

int x1 = InputNumber("Введите первое точки A");
int y1 = InputNumber("Введите второе точки A");
int z1 = InputNumber("Введите третье точки A");
int x2 = InputNumber("Введите первое точки A");
int y2 = InputNumber("Введите второй точки B");
int z2 = InputNumber("Введите третье точки B");

double coordinates = Math.Sqrt(Math.Pow(x2 - x1, 2 ) + Math.Pow(y2 - y1, 2 ) + (Math.Pow(z2 - z1, 2 )));
coordinates = Math.Round(coordinates, 2);

Console.WriteLine($"{coordinates}");
}

void Task23()
{
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Задача 23");
int number = InputNumber("Введите число");

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i}^3, {Math.Pow(i, 3)}");
}
}








