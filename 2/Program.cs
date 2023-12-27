// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


System.Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermansFunction(m, n);
Console.WriteLine($"Значение фунуции Аккермана({m}, {n}) = {result}");

int AckermansFunction(int m, int n)
{

  if (m == 0)
  {
    return n + 1;
  }

  else if (n == 0)
  {
    return AckermansFunction(m - 1, 1);
  }

  else
  {
    return AckermansFunction(m - 1, AckermansFunction(m, n - 1));
  }
}

