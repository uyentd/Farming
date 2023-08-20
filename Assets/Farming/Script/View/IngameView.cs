using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngameView : BaseView
{
    // Start is called before the first frame update
    public override void Setup(ViewParam param)
    {
        base.Setup(param);
        Debug.LogError("Ingame View");
    }
    public void ShowHomeView()
    {
        ViewManage.instance.SwitchView(ViewIndex.HomeView);
    }
}
