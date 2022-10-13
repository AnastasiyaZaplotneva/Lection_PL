// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//Console.WriteLine("Введите число: ");
//int number = int.Parse(Console.ReadLine());
//int square = number * number;
//Console.WriteLine("Квадрат числа равен ");
//Console.Write(square);

//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
	
//Console.WriteLine("Введите первое число: ");
//int numberA = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int numberB = int.Parse(Console.ReadLine());
//int sqr = numberB * numberB;
//if(sqr == numberA)
//{
//    Console.WriteLine("Верно");
//}
//else
//{
//    Console.WriteLine("Ложь");
//}

//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//Console.Clear();
//Console.WriteLine("Введите число от 1 до 7: ");
//int number = int.Parse(Console.ReadLine());
//if(number == 1)
//{
//    Console.WriteLine("Сегодня понедельник");
//}
//if(number == 2)
//{
//  Console.WriteLine("Сегодня вторник");
//}
//if(number == 3)
//{
//    Console.WriteLine("Сегодня среда");
//}
//if(number == 4)
//{
//    Console.WriteLine("Сегодня четверг");
//}
//if(number == 5)
//{
//    Console.WriteLine("Сегодня пятница");
//}
//if(number == 6)
//{
//    Console.WriteLine("Сегодня суббота");
//}
//if(number == 7)
//{
//    Console.WriteLine("Сегодня воскресенье");
//}
//if(number > 7 || number < 1)
//{
//    Console.WriteLine("Вы ввели неверное число");
//}

//ВВедите число N и выведите все числа от -N до N
Console.Clear();
Console.WriteLine("Введите положительное целое число: ");
int number = int.Parse(Console.ReadLine());
int count = number * -1;
while(count <= number)
{
    Console.Write($"{count}, ");
    count++;
}