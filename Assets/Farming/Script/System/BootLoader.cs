using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootLoader : MonoBehaviour
{
    public event Action<int> OnsampleEventLamda;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        DontDestroyOnLoad(gameObject);// sẽ luôn tồn tại, ko huỷ đi khi chuyển scene
        yield return new WaitForSeconds(1);
        // LoadSceneManager.instance.LoadSceneByName("Buffer", LoadSceneDone);
        LoadSceneManager.instance.LoadSceneByIndex(1, () =>
        {
            Debug.LogError(" Load scene by index done");
        });
        SampleLamda((s, a) =>
        {
            Debug.LogError("log:" + s + " " + a.ToString());
        });
        OnsampleEventLamda += BootLoader_OnsampleEventLamda;// thêm sự kiện
        OnsampleEventLamda -= BootLoader_OnsampleEventLamda; // huỷ sự kiện
    }

    private void BootLoader_OnsampleEventLamda(int obj)
    {
        throw new NotImplementedException();
    }

    public void LoadSceneDone()
    {
        Debug.LogError(" Load Scene Done");
    }

    public void SampleLamda(Action<string, int> callBack)
    {
        callBack("Lamda", 3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
