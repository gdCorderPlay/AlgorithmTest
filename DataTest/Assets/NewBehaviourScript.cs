using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript: MonoBehaviour {

    public int[] nums;
    public string[] strs;
	void Start () {
        // nums.BubbleSort();
        // nums.InsertSort();
        //nums.ToHeap();
        // nums.Logger();
        nums.HeapSort();
       // nums.LoggerNext();
       // int num = 20;
       // num.Cnm(3);
	}
	
}
