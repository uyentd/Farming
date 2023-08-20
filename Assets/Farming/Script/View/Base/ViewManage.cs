using System;
using System.Collections.Generic;
using UnityEngine;

public class ViewManage : BYSingletonMono<ViewManage>
{
    public RectTransform anchor_view; // kế thừa từ tranform trên unity
    // Quản lý view, chỉ quản lý view, gom nhóm lại 
    private Dictionary<ViewIndex, BaseView> dic_View = new Dictionary<ViewIndex, BaseView>();
    public BaseView cur_view;

    // Start is called before the first frame update
    void Start()
    {
        foreach (ViewIndex view_index in ViewConfig.viewIndices)
        {
            string name_v = view_index.ToString();
            GameObject go_view = Instantiate(Resources.Load("View/" + name_v, typeof(GameObject))) as GameObject;
            // tạo 1 GO từ thư mục réource, load thư mục view và view name
            go_view.transform.SetParent(anchor_view, false);// reset về mặc định, nếu ko reset thì để true
            go_view.SetActive(false);
            BaseView view = go_view.GetComponent<BaseView>();// trong trường hợp này, đang tao ra 3 view, nhưng đều thừa kế từ base view => gom nhóm
            dic_View.Add(view.viewIndex, view);  // add phần tử vào
        }
        SwitchView(ViewIndex.EmptyView); 
    }

    // Update is called once per frame
    public void SwitchView(ViewIndex viewIndex, ViewParam param = null, Action callback = null)
    {
        if (cur_view != null)
        {
            cur_view.HideView(() =>
            {
                //show view
                cur_view = dic_View[viewIndex];
                ShowNewView(param, callback);
            });
        }
        else
        {
            cur_view = dic_View[viewIndex];
            ShowNewView(param, callback);
        }    
    }
    private void ShowNewView(ViewParam param = null, Action callback = null)
    {
        cur_view.Setup(param);
        //cur_view.gameObject.SetActive(true);
        //cur_view.SendMessage("ShowView", callback, SendMessageOptions.RequireReceiver);
        cur_view.ShowView(callback);
    }    
}
