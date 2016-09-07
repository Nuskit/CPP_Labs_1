using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_1_QuickSort;
using System.Collections.Generic;
using System.Diagnostics;

namespace Labs_1_UnitTests
{
  [TestClass]
  public class QuickSortTest
  {
    private class QuickSortWithComparer<T>
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

    [TestMethod]
    public void TestCheckWhenZeroCountElements()
    {
      int[] testingArray = {};
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Sort(testingArray);
      CollectionAssert.AreEqual(new int[] {}, testingArray);
    }

    [TestMethod]
    public void TestWhenNullArray()
    {
      int[] testingArray = null;
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Sort(testingArray);
      Assert.IsNull(testingArray);
    }

    [TestMethod]
    public void TestSortedArray()
    {
      int[] testingArray = { 0, 1, 2, 3, 4, 5 };
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Sort(testingArray);
      CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5 }, testingArray);
    }

    [TestMethod]
    public void TestReversedSortedArray()
    {
      int[] testingArray = {6, 5, 4, 3, 2, 1, 0 };
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Sort(testingArray);
      CollectionAssert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5, 6 }, testingArray);
    }

    [TestMethod]
    public void TestDefaultArray()
    {
      int[] testingArray = { 7, 2, 4, -3, 15, 0, -10 };
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Sort(testingArray);
      CollectionAssert.AreEqual(new int[] { -10, -3 , 0, 2, 4, 7, 15 }, testingArray);
    }

    [TestMethod]
    public void TestWhenAllEqualValue()
    {
      int[] testingArray = { 1, 1, 1, 1, 1, 1 };
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Sort(testingArray);
      CollectionAssert.AreEqual(new int[] { 1, 1, 1, 1, 1, 1 }, testingArray);
    }

    [TestMethod]
    public void TestWhenArrayHaveNullPointer()
    {
      string[] testingArray = { "123", "afsdf", "a132rer", "adffdg", null, "124234", "adsfd" };
      var quickSort = new QuickSortWithComparer<string>();
      quickSort.Sort(testingArray);
      CollectionAssert.AreEqual(new string[] { null, "123", "124234", "a132rer", "adffdg", "adsfd", "afsdf" }, testingArray);
    }

    [TestMethod]
    public void TestDifferenceComparer()
    {
      int[] testingArrayBigger = { 7, 2, 4, -3, 15, 0, -10 };
      var quickSort = new QuickSortWithComparer<int>();
      quickSort.Comparer=new ComparerBigger();
      quickSort.Sort(testingArrayBigger);
      CollectionAssert.AreEqual(new int[] { -10, -3, 0, 2, 4, 7, 15 }, testingArrayBigger);

      int[] testingArrayLower = { 7, 2, 4, -3, 15, 0, -10 };
      quickSort.Comparer = new ComparerLower();
      quickSort.Sort(testingArrayLower);
      CollectionAssert.AreEqual(new int[] { 15, 7, 4, 2, 0, -3, -10 }, testingArrayLower);
    }
  }
}
