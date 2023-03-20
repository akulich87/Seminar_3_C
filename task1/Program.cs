// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X не=0 и Y не=0 и выдает номер четверти плоскости, в которой 
// находится эта точка.

Console.WriteLine("Введите координаты X ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y ");
int y = Convert.ToInt32(Console.ReadLine());

{
if(( x > 0 ) && ( y > 0 ))
 {
  Console.WriteLine("Точка находится в первой четверти ");
 }
 else if(( x < 0 ) && ( y > 0 ))
 {
  Console.WriteLine("Точка находится во второй четверти ");
 }
 else if(( x < 0 ) && ( y < 0 ))
 {
  Console.WriteLine("Точка находится в третьей четверти ");
 }
else
 {
  Console.WriteLine("Точка находится в четвертой четверти ");
 }
}
