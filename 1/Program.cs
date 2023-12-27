// Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.



System.Console.WriteLine("Введите первое число");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());

PrintNums(firstNum, secondNum);


void PrintNums(int startNum, int lastNum)
{

  if (startNum > lastNum)
  {
    return;
  }


  Console.WriteLine(startNum);


  PrintNums(startNum + 1, lastNum);
}
