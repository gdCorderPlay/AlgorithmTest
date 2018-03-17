using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 归并排序测试
/// </summary>
public class MergeSortTest :MonoBehaviour  {

    public int[] nums;

    private void Start()
    {
        MergeSort(nums, nums.Length);
        
    }
    /// <summary>
    ///  供外部调用的方法
    /// </summary>
    void MergeSort(int[] test ,int count)
    {

        int[] temp = new int[count];

        DiGui(test, temp, 0, (count - 1) / 2, count - 1);


    }
    /// <summary>
    /// 主体的递归程序
    /// </summary>
    
    void DiGui(int[] test, int[] temp,int left, int index, int right)
    {
        if(left<index)
        DiGui(test,temp,left,(left+index)/2,index);  //左边部分
        if(index+1<right)
        DiGui(test, temp, index+1, (right + index+1) / 2, right); //右边部分
        //归并
        test2(test, temp, left, index, right);


    }
    /// <summary>
    /// 归并两个有序的数组
    /// </summary>
    void  test2(int[] test,int[] temp,int left,int index,int right)
    {
        int leftIndex = left;
        int rightIndex = index+1;
        int insert = left;
        while (insert <= right)
        {
            if (leftIndex <= index && rightIndex <= right)
            {
                if (test[leftIndex] > test[rightIndex])
                {
                    temp[insert] = test[rightIndex];
                    rightIndex++;
                }
                else
                {
                    temp[insert] = test[leftIndex];
                    leftIndex++;
                }
            }
            else
            {
                if(leftIndex <= index)
                {
                    temp[insert] = test[leftIndex];
                    leftIndex++;
                }
                else
                {
                    temp[insert] = test[rightIndex];
                    rightIndex++;
                }
            }
            insert++;
        }
        for (; left <= right; left++)
        {
            test[left] = temp[left];
        }

    }

	
}
