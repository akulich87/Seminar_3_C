// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Алгоритм решения, (xB - xA) в квадрате + (yB - yA) в квадрате , и из получившейся суммы находим корень 

// double number = Math.Sqrt(49); // встроенный метод Math работает только с переменной типа double(числа с плавающей запятой)

// Console.Write(number); // выводим результат

// double number = Math.Pow(); // Pow - подкоманда, которая возводит нашу переменную в любую степень
// к примеру у нас есть переменная int number = 5; 
// - тогда double number = Math.Pow(number, 2) - число 5 во второй степени


Console.Write("Введи X точки B ");
int XB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи Y точки B ");
int YB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи X точки A ");
int XA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи Y точки A ");
int YA = Convert.ToInt32(Console.ReadLine());

double number =Math.Sqrt((Math.Pow ((XB-XA),2))+(Math.Pow((YB-YA),2)));

 Console.WriteLine(number);
