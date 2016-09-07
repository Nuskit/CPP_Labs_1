using System.Collections.Generic;

namespace Labs_1_QuickSort
{
  public class ComparerBigger : IComparer<int>
  {
    public int Compare(int left, int right)
    {
      return left > right ? 
        1 : 
        left < right ? 
        -1 : 
        0;
    }
  }

  public class ComparerLower : IComparer<int>
  {
    public int Compare(int left, int right)
    {
      return left > right ?
        -1 :
        left < right ?
        1 :
        0;
    }
  }
}
