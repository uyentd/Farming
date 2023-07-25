using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SampleGeneric : MonoBehaviour
{
    public List<string> names;
    public List<GameObject> collections;
    // field

    // Start is called before the first frame update
    void Start()
    {
        // instance 
        MathMode<string> a = new MathMode<string>();
        a.ShowInfo("Helo");
        MathMode<int> b = new MathMode<int>();
        b.ShowInfo(5);

        SampleStatic.number = 4;
        Debug.LogError("@@@@@@@@@@@@@@@ sample" + SampleStatic.number);
        SampleSingleton.instance.age = 5;
        SampleSingleton.instance.ShowAge();
        SampleSingleton_2.instance.ShowInfo(" helo co ba");

        SampleProperties sampleProperties = new SampleProperties();

        sampleProperties.Count = 4;
        sampleProperties.Count++;
        Debug.LogError(" Count: " + sampleProperties.Count);
      //  sampleProperties.Count = sampleProperties.Count + 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
public class SampleProperties
{
    // field 
    private int count_;
    // properties 
    public int Count
    {
        set
        {
            if (value > 0)
                count_ = value;
        }
        get
        {
            return count_*2;
        }
    }
}
// Type
public class MathMode<T>
{
    public void ShowInfo(T a)
    {
        Debug.LogError(a.ToString());
    }
}
public static class SampleStatic
{
    public static int number = 2;
    private static int age;
    public static void ShowMess(string mess)
    {
        Debug.LogError(" show: " + mess);
    }
    private static void ConvertMess(string mess)
    {

    }
}