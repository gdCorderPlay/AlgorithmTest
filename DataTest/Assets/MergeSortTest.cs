using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 归并排序测试
/// </summary>
public class MergeSortTest  {




    /// <summary>
    ///  
    /// </summary>
    void Test(int[] test ,int count)
    {



    }
    void  test2(int[] test,int[] temp,int left,int index,int right)
    {
        int leftIndex = left;
        int rightIndex = index;
        int insert = left;

        while (insert <= right)
        {

            if (test[leftIndex] > test[rightIndex])
            {
                temp[insert] = test[rightIndex];
                rightIndex++;
            }else
            {
                temp[insert] = test[leftIndex];
                leftIndex++;
            }
            insert++;
        }
    }






	
}
