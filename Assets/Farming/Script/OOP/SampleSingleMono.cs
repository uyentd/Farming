using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSingleMono : BYSingletonMono<SampleSingleMono>
{
   public void ShowLog()
    {
        Debug.LogError(" SampleSingleMono here!!!");
    }
}
