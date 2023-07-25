using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSingleton : Singleton<SampleSingleton>
{
    public int age;
    public void ShowAge()
    {
        Debug.LogError(" @@@@@@@@@@@@@@@@@@@ Age: " + age);
    }
}
public class SampleSingleton_2:Singleton<SampleSingleton_2>
{
    public void ShowInfo(string mess)
    {
        Debug.LogError("########### Mess:" + mess);
    }
}