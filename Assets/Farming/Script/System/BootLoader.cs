﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootLoader : MonoBehaviour
{
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        DontDestroyOnLoad(gameObject);// sẽ luôn tồn tại, ko huỷ đi khi chuyển scene
        yield return new WaitForSeconds(1);
        LoadSceneManager.instance.LoadSceneByName("Buffer", LoadSceneDone);
       
    }



    public void LoadSceneDone()
    {
        Debug.LogError(" Load Scene Done");
        ViewManage.instance.SwitchView(ViewIndex.HomeView);// load xong scene thì load home view
    }


    void Update()
    {
        
    }
}
