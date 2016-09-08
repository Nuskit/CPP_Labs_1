using Labs_1_QuickSort;
using System.Collections.Generic;

namespace Labs_1_UnitTests
{
  class QuickSortWithComparer<T>
  {
    public QuickSortWithComparer(IComparer<T> comparer = null)
    {
      Comparer = (comparer == null) ? Comparer<T>.Default : comparer;
    }

    public ISort<T> QuickSort
    {
      get
      {
        return new QuickSort<T>();
      }
      set
      {
        QuickSort = value;
      }
    }

    public IComparer<T> Comparer
    {
      get; set;
    }

    public void Sort(T[] array)
    {
      QuickSort.Sort(array, Comparer);
    }
  }
}
