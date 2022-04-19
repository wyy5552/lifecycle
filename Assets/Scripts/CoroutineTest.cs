using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("开始协程");
        Test();
        Debug.Log("结束协程");
    }
    //通过迭代器定义一个方法
    IEnumerator Demo(int i)
    {
        //代码块

        Debug.Log("Demo begin");
        Debug.Log("Demo begin2");
        yield return i;
        yield return i;
        //代码块
        Debug.Log("Demo end");


    }

    //在程序种调用协程
    public void Test()
    {
        //第一种与第二种调用方式,通过方法名与参数调用
        StartCoroutine("Demo", 0);

        //第三种调用方式， 通过调用方法直接调用
        StartCoroutine(Demo(1));
        StartCoroutine(Demo(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
