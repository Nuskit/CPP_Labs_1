using System.Collections.Generic;

namespace Labs_1_QuickSort
{
  public interface ISort<T>
  {
    void Sort(T[] sortedArray, IComparer<T> comparer);
  }
}
