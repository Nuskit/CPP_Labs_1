using System;

namespace Labs_1_QuickSort
{
  class RandomGenerator
  {
    private static void FillValues(int[] values,int count)
    {
      Random random = new Random();
      for (int i = 0; i < count; i++)
        values[i] = random.Next(-10000,10000);
    }

    public static int[] Generate(int count)
    {
      var randomValues = new int[count];
      FillValues(randomValues, count);
      return randomValues;
    }
  }
}
