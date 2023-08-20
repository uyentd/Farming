using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseView : MonoBehaviour
{
    public ViewIndex viewIndex;
    // Start is called before the first frame update
    public virtual void Setup(ViewParam param)
    {

    }
    public void HideView(Action callback) // ẩn view
    {
        gameObject.SetActive(false);
        callback?.Invoke();
    }
    public void ShowView(Action callback) // hiện view
    {
        gameObject.SetActive(true);
        callback?.Invoke();
    }
}
