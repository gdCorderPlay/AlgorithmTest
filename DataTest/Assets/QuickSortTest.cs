using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 快速排序练习
/// </summary>
public class QuickSortTest : MonoBehaviour {

    public int[] nums;

    private void Start()
    {
        Sort(nums, 0, nums.Length - 1);
    }
    void Sort(int[]nums,int start,int end)
    {
        if (start >= end)
        {
            return;
        }
        int left = start;
        int right = end;
        int temp;
        while (left < right)
        {
           
            while (nums[left]<nums[end]&& left <= right)
            {
                left++;
            }
            while (nums[right] >=nums[end]&& left <= right)
            {
                right--;
            }
            //交换位置
            if (left < right)
            {
                temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left++;
                right--;
            }
            
        }
        temp = nums[end];
        nums[end] = nums[left];
        nums[left ] = temp;

        Sort(nums, start,left-1);//左边部分
        Sort(nums, left+1,end);//右边部分

    }
	


}
