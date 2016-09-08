using System.Collections.Generic;

namespace Labs_1_QuickSort
{
  public class QuickSort<T> : ISort<T>
  {
    public void Sort(T[] sortingArray, IComparer<T> comparer)
    {
      if ((sortingArray != null && sortingArray.Length > 0) && comparer != null)
        SortedArrayRecurcive(sortingArray, comparer, 0, sortingArray.Length-1);
    }

    private void SortedArrayRecurcive(T[] sortingArray, IComparer<T> comparer, int startPosition, int endPosition)
    {
      if (startPosition < endPosition)
      {
        int median = PartitionSorted(sortingArray, comparer, startPosition, endPosition);
        SortedArrayRecurcive(sortingArray, comparer, startPosition, median - 1);
        SortedArrayRecurcive(sortingArray, comparer, median + 1, endPosition);
      }
    }

    int PartitionSorted<T>(T[] sortingArray, IComparer<T> comparer, int startPosition, int endPosition)
    {
      int i = startPosition;
      for (int j = startPosition; j <= endPosition; j++)
      {
        if (CompareValueLowerOrEquial(comparer,sortingArray[j], sortingArray[endPosition]))  
        {
          Swap(ref sortingArray[i], ref sortingArray[j]);
          i++;                         
        }
      }
      return --i;                        
    }

    private bool CompareValueLowerOrEquial<T>(IComparer<T> comparer,T first,T second)
    {
      return comparer.Compare(first, second) <= 0;
    }

    private void Swap<T>(ref T left,ref T right)
    {
      T temp = left;              
      left = right;                 
      right = temp;
    }
  }
}
