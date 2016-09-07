using System;
using System.Text;

namespace Labs_1_QuickSort
{
  class Program
  {
    private struct CountCorrect
    {
      public int count;
      public bool isCorrect;
    }

    static void ShowAllValue(int[] values,string extraInformation)
    {
      StringBuilder message=new StringBuilder(String.Format("{0}\n", extraInformation));
      foreach (var value in values)
        message.Append(String.Format("{0} ", value));
      Console.WriteLine(message);
    }

    static int[] GenerateValues(int count)
    {
      int[] generateValues = RandomGenerator.Generate(count);
      ShowAllValue(generateValues, "Generate values:");
      return generateValues;
    }

    static void WorkSortedTesting(int count)
    {
      ISort<int> sort = new QuickSort<int>();
      int[] generateValues = GenerateValues(count);
      sort.Sort(generateValues, new ComparerBigger());
      ShowAllValue(generateValues,"Sorted Values:");
    }

    static void Main(string[] args)
    {
      if (args.Length>0)
      {
        EnteredCount(args[0]);
      }
      else
      {
        WorkWithUser();
      }
      Console.WriteLine("Press some to exit");
      Console.Read();
    }

    private static void WorkWithUser()
    {
      Console.WriteLine("Enter a count of array:");
      EnteredCount(Console.ReadLine());
    }

    private static void EnteredCount(string value)
    {
      CountCorrect countCorrent = isCorrectCount(value);
      if (countCorrent.isCorrect)
        WorkSortedTesting(countCorrent.count);
      else
        Console.WriteLine("Uncorrect value");
    }

    private static CountCorrect isCorrectCount(string checkingValue)
    {
      CountCorrect countCorrect = new CountCorrect();
      countCorrect.isCorrect = (int.TryParse(checkingValue, out countCorrect.count) && countCorrect.count > 0) ? true : false;
      return countCorrect;
    }
  }
}
