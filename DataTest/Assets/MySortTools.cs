using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 排序方法
/// </summary>
public static class MySortTools
{
    /// <summary>
    /// 升序冒泡
    /// </summary>
    /// <param name="nums"></param>
    public static void BubbleSort(this int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            bool orderly = true; //记录是否已经有序
            for (int j = 0; j < nums.Length - i; j++)
            {
                count++;
                if (nums[j] > nums[j + 1])
                {
                    nums.Swap(j, j + 1);
                    orderly = false;
                }
            }
            if (orderly)
            {
                break;
            }
        }
        Debug.Log("冒泡排序执行次数:" + count);
    }
    /// <summary>
    /// 交换数组中的两个元素
    /// </summary>
    public static void Swap(this int[] nums, int index1, int index2)
    {
        int temp = nums[index1];
        nums[index1] = nums[index2];
        nums[index2] = temp;
    }
    /// <summary>
    /// 输出数组中的元素
    /// </summary>
    /// <param name="nums"></param>
    public static void Logger(this int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Debug.Log("第" + i + "个元素:" + nums[i]);

        }
    }
    /// <summary>
    /// 插入排序
    /// </summary>
    public static void InsertSort(this int[] nums)
    {
        int count = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            int temp = nums[i];
            int j = i;
            for (; j > 0 && nums[j - 1] > temp; j--)
            {
                count++;
                //if ()
                //   {
                nums[j] = nums[j - 1];
                //}
                //else
                // {
                //   break;
                //  }
            }
            nums[j] = temp;
        }
        Debug.Log("插入排序执行次数：" + count);
    }

    /// <summary>
    /// 输出 相邻两个元素的乘积
    /// </summary>
    public static void LoggerNext(this int[] nums)
    {
        for(int i = 1; i < nums.Length; i++)
        {
            Debug.Log(nums[i]+"*"+nums[i-1]+"="+nums[i]*nums[i-1]);
        }

    }
    /// <summary>
    /// 数字的组合数量
    /// </summary>
    public static void Cnm(this int index,int n)
    {
        int di=1;
        int sum=1;
        for(int i = 1; i <= n; i++)
        {
            sum *= index - i + 1;
            di *= i;
        }
        Debug.Log(string.Format("在{0}个数中每{1}个组合，共有{2}种组合", index, n, sum / di));
    }
    /// <summary>
    ///将一个数组最大堆化
    /// </summary>
    public static void ToHeap(this int[] nums)
    {
        int count = 0;
        for(int i = 1; i < nums.Length; i++)
        {
            int index = i;
          //  int j = i / 2;
            for (; index >0; index/= 2)
            {
                count++;
                if( nums[index] > nums[index/2])
                {
                    nums.Swap(index, index/2);
                }
                else
                {
                    break;
                }
            }
        }
        Debug.Log("最大堆化的过程中执行的次数：" + count);
    }
    /// <summary>
    /// 堆排序
    /// </summary>
    public static void HeapSort(this int[] nums)
    {
        nums.ToHeap();//最大堆化
        for(int i = 1; i < nums.Length; i++)
        {
            nums.Swap(0, nums.Length  - i);
            nums.TopToHeap(nums.Length-i-1);
        }
    }
    /// <summary>
    /// 自上向下最大堆化 count 最后一位的下标
    /// </summary>
    public static void TopToHeap(this int[]nums,int count)
    {
        for (int index = 0; (index+1)*2-1 <= count;)//判断该节点是否有左孩子存在
        {
            int temp= nums.GetMax((index + 1) * 2 - 1, Mathf.Clamp((index + 1) * 2,0,count));
            if (nums[index] < nums[temp])
            {
                nums.Swap(index, temp);
                index = temp;
            }
            else
            {
                break;
            }
        }
    }
    /// <summary>
    /// 获取较大元素的下标
    /// </summary>
    public static int GetMax(this int[]nums,int left,int right)
    {
        if (nums[left] >= nums[right])
        {
            return left;
        }
        else
        {
            return right;
        }

    }
    /// <summary>
    /// 归并排序
    /// </summary>
    public static void MergeSort(this int[]nums)
    {
        for(int i = 1; i < nums.Length; )
        {
            i *= 2;
            int j = 0;
            for (; j < nums.Length; j += i)
            {

            }


        }
















    }

}
