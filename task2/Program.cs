// Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

switch(number) // передаем переменную ту, по которой мы сравниваем
{
  case 1: // если 1
  {
    Console.WriteLine(" X > 0 и Y > 0 ");
    break;
  }
  case 2:
  {
    Console.WriteLine(" X < 0 и Y > 0 ");
    break;
  }
  case 3:
  {
    Console.WriteLine(" X < 0 и Y < 0 ");
    break;
  }
  case 4:
  {
    Console.WriteLine(" X > 0 и Y > 0 ");
    break;
  }

  default:
  {
    Console.WriteLine("Такой четверти нет ");
    break;
  }
}