Console.WriteLine("Сделайте выбор task:");
bool isWork = true;
while (isWork)
{
	string command = Console.ReadLine()!;
	switch (command)
	{
		case "task64": Task64(); break;
		case "task66": Task66(); break;
		case "task68": Task68(); break;
    	case "exit": isWork = false; break;
	}
}

int ReadLineInt(string p) // Ввод числа int
{
    Console.WriteLine($"Введите {p}");
    int n = int.Parse(Console.ReadLine()!);
    return n;
}



void Task64() //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
{

int n = ReadLineInt("Число N");
PrintNumbersToN(n);


void PrintNumbersToN(int n)
{ int one = 1;
  if(n >= one)
  { 
    Console.WriteLine(n);
    PrintNumbersToN(n - 1);

  }
}

}

void Task66() //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
{
  int m = ReadLineInt("число M");
  int n = ReadLineInt("число N");
 Sum(m, n);

  void Sum(int m, int n, int sum = 0)
  { 
    if (m > n)
   {  
     Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}"); 
     return;
   } 
    sum = sum + (m++);
    Sum(m, n, sum);
  }
}


void Task68() //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
{

  int m = ReadLineInt("начальное число M");
  int n = ReadLineInt("начальное число N");

int AckerFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckerFunction(m - 1, 1);
    if (m > 0 &&  n > 0) return AckerFunction(m - 1, AckerFunction(m, n - 1));
return AckerFunction(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AckerFunction(m, n)}");









}