using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//написать методы добавления элемента в начало, конец и по указанному индексу 
namespace Homework_13
{
  class Program
  {
    static void addToEnd(ref int[] array)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      array = new int[array.Length + 1];
      for (int i = 0; i < currArray.Length; i++)
      {
        array[i] = currArray[i];
      }
      Console.Write("Введите значение для элемента: ");
      array[array.Length - 1] = int.Parse(Console.ReadLine());

    }

    static void addToStart(ref int[] array)
    {
      int[] currArray = new int[array.Length];
      for (int i = 0; i < array.Length; i++)
      {
        currArray[i] = array[i];
      }
      array = new int[array.Length + 1];
      for (int i = 0; i < currArray.Length; i++)
      {
        array[i + 1] = currArray[i];
      }
      Console.Write("Введите значение для элемента: ");
      array[0] = int.Parse(Console.ReadLine());
    }

    static void addByIndex(ref int[] array, int index)
    {
      if (index == 0)
      {
        addToStart(ref array);
      }
      else if(index == array.Length - 1)
      {
        addToEnd(ref array);
      }
      else
      {
        int[] currArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
          currArray[i] = array[i];
        }
        array = new int[array.Length + 1];
        for (int i = 0; i < index; i++)
        {
          array[i] = currArray[i];
        }
        Console.Write("Введите значение для элемента: ");
        array[index] = int.Parse(Console.ReadLine());
        for (int i = index + 1, j = index; i < array.Length && j < currArray.Length; i++, j++)
        {
          array[i] = currArray[j];
        }
      }
    }

    static void Main(string[] args)
    {
      int[] myArrray = new int[] { 1, 2, 3, 4 };
      foreach (var item in myArrray)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
      Console.Write("Введите, как вы хотите добавить элемент в массив(в начало/ в конец/ по индексу): ");
      string identificator = Console.ReadLine();
      if (identificator == "в начало")
      {
        addToStart(ref myArrray);
      }
      else if(identificator == "в конец")
      {
        addToEnd(ref myArrray);
      }
      else if(identificator == "по индексу")
      {
        Console.Write("Введите индекс, куда добавить элемент: ");
        addByIndex(ref myArrray, int.Parse(Console.ReadLine()));
      }
      foreach (var item in myArrray)
      {
        Console.Write(item + " ");
      }
      Console.WriteLine();
      Console.ReadLine();
    }
  }
}
