using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_1_QuickSort
{
  class Program
  {
    static void Main(string[] args)
    {
      int count;
      if (args.Length>2&&int.TryParse(args[1],out count)&&count>0)
      {
        ISort<int> sort = new QuickSort<int>();
        int[] generateValues = RandomGenerator.Generate(count);
        //sort.Sort(generateValues,);
      }
    }
  }
}
