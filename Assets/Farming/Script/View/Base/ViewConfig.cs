using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ViewIndex
{
    EmptyView = 1,
    HomeView = 2,
    IngameView = 3
}
public class ViewParam
{

}

public class ViewConfig
{
    /* ví dụ cho enum
     * private void Sample ()
      {
          // truyền enum vào switch case
          ViewIndex v =ViewIndex.EmptyView;
          switch (v) // thường chỉ nhận int or byte. Enum đại diện cho kiểu int
          {
              case ViewIndex.EmptyView:
                  Debug.LogError("");
                  break;
              case ViewIndex.HomeView:
                  break;
              default:
                  break;
          }

          if (v == ViewIndex.EmptyView)// kiểm tra những điều kiện khác: 1 chuỗi, hoặc v..v...
          {

          }
          else if (v == ViewIndex.HomeView)
          {

          }    
          else
          {

          }   */
    public static ViewIndex[] viewIndices = { ViewIndex.EmptyView, ViewIndex.HomeView, ViewIndex.IngameView };
}
