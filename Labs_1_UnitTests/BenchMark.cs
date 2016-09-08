using BenchmarkDotNet.Attributes;
using Labs_1_QuickSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_1_UnitTests
{
  public class BenchMark
  {
    private int[] GenerateValue()
    {
      return RandomGenerator.Generate(10000);
    }

    [Benchmark(Description = "CustomSorted")]
    public void CustomSorted()
    {   
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Sort(GenerateValue()); 
    }

    [Benchmark(Description = "DefaultSorted")]
    public void DefaultSorted()
    {
      Array.Sort(GenerateValue());
    }
  }
}
