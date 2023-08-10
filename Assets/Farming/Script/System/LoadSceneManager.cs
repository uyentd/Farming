using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneManager : BYSingletonMono<LoadSceneManager>
{
    // Start is called before the first frame update
    public GameObject ui_object;
    public Image image_progress;
    public Text progress_lb;

    // Update is called once per frame

    /// <summary>
    /// Load new scene by name
    /// </summary>
    /// <param name="scene_name"> scene_name</param>
    /// <param name="callback"></param>
    public void LoadSceneByName( string scene_name, Action callback)
    {
        StartCoroutine(LoadSceneByNameProgress(scene_name, callback));
    }
    IEnumerator LoadSceneByNameProgress(string scene_name, Action callback) 
    {
        ui_object.SetActive(true);
        AsyncOperation async = SceneManager.LoadSceneAsync(scene_name, LoadSceneMode.Single);
        WaitForSeconds wait_s = new WaitForSeconds(0.1f);
        float count = 0;
        while ( count < 80)
        {
            yield return wait_s;
            count++;
            progress_lb.text = count.ToString() + "%";
            image_progress.fillAmount = (float)count / 100f; 
        }    
        while (!async.isDone)
        {
            yield return wait_s;
            progress_lb.text = ((int)(async.progress * 100)).ToString() + "%";
            image_progress.fillAmount = async.progress;
        }     
        callback?.Invoke();
        ui_object.SetActive(false);
    }
    public void LoadSceneByIndex(string scence_index, Action callback)
    {

    }
    IEnumerable Wait()// gọi cái này, thì nó sẽ kiểm tra bên trong có bao nhiêu câu lệnh yield
    {
        //1, trả về 1 đối tượng Ienumerable
        yield return new WaitForSeconds(1);

        //2 chạy hàm movenext ( là 1 funtion của IEnumerable) đến cái thứ 2m,, rồi cái thứ 3
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(1);
        // không còn câu lệnh thì kết thúc vòng lặp
        // cái quần này chạy ké trong hàm update


    }    
}
