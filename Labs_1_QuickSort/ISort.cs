using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs_1_QuickSort
{
  public interface ISort<T>
  {
    void Sort(T[] sortedArray, IComparer<T> comparer);
  }
}
