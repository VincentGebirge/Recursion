// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.




Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

CreateArray();

int[] CreateArray()
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(10, 101);
    System.Console.Write(array[i] + " ");
  }

  return array;
}

System.Console.WriteLine();

PrintNewArray(array, array.Length - 1);


void PrintNewArray(int[] array, int index)
{

  if (index < 0)
  {
    return;
  }


  Console.Write(array[index] + " ");


  PrintNewArray(array, index - 1);
}
