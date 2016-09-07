using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labs_1_QuickSort;

namespace Labs_1_UnitTests
{
  [TestClass]
  public class QuickSortTest
  {
    private ISort<int> QuickSortInt
    {
      get
      {
        return new QuickSort<int>();
      }
    }

    [TestMethod]
    public void TestCheckWhenZeroCountElements()
    {
      int[] testingArray = {};
      QuickSortInt.Sort(testingArray);
      Assert.AreEqual<int[]>(new int[] {}, );
    }

    [TestMethod]
    public void TestWhenNullArray()
    {
      int[] testingArray = null;      
      Assert.IsNull(QuickSortInt.sort(testingArray));
    }

    [TestMethod]
    public void TestSortedArray()
    {
      int[] testingArray = { 0, 1, 2, 3, 4, 5 };
      Assert.AreEqual<int[]>(new int[] { 0, 1, 2, 3, 4, 5 }, QuickSortInt.sort(testingArray));
    }

    [TestMethod]
    public void TestReversedSortedArray()
    {
      int[] testingArray = {6, 5, 4, 3, 2, 1, 0 };
      QuickSortInt.sort(testingArray);
      Assert.AreEqual<int[]>(new int[] { 0, 1, 2, 3, 4, 5, 6 }, testingArray);
    }

    [TestMethod]
    public void TestDefaultArray()
    {
      int[] testingArray = { 7, 2, 4, -3, 15, 0, -10 };
      QuickSortInt.sort(testingArray);
      Assert.AreEqual(new int[] { -10, -3 , 0, 2, 4, 7, 15 }, testingArray);
    }

    [TestMethod]
    public void TestWhenAllEqualValue()
    {
      int[] testingArray = { 1, 1, 1, 1, 1, 1 };
      QuickSortInt.sort(testingArray);
      Assert.AreEqual(new int[] { 1, 1, 1, 1, 1, 1 }, testingArray);
    }

    [TestMethod]
    public void TestWhenArrayHaveNullPointer()
    {
      
    }
  }
}
