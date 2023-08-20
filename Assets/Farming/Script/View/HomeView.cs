using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeView : BaseView
{
    // Start is called before the first frame update
    public override void Setup(ViewParam param)
    {
        base.Setup(param);
        Debug.LogError("Home View");
    }
    public void ShowIngameView()
    {
        ViewManage.instance.SwitchView(ViewIndex.IngameView);
    }
}
