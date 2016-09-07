﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_1_QuickSort
{
  class RandomGenerator
  {
    private static void FillValues(int[] values,int count)
    {
      Random random = new Random();
      for (int i = 0; i < count; i++)
        values[i] = random.Next();
    }

    public static int[] Generate(int count)
    {
      var randomValues = new int[count];
      FillValues(randomValues, count);
      return randomValues;
    }
  }
}
