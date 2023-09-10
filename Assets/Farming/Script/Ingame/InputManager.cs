using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : BYSingletonMono<InputManager>
{
    public static Vector3 delta_mouse; // dùng chuột 
    private Vector3 ogrinal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* bài trước
          float x = Input.GetAxis("Horizontal");// 0->1-1
          float z = Input.GetAxis("Vertical");
          move_dir = new Vector3(x, 0, z);
          if (Input.GetKeyDown(KeyCode.K))
          {
              isAttack = true;
          }
          else
          {
              isAttack = false;
          }

          isSwapChar = Input.GetKeyDown(KeyCode.Space);
        */

        // dùng chuột kéo thả character

        delta_mouse = Vector3.zero; // gán deltamouse = 0
      if (Input.GetMouseButtonDown(0))// chuột trái, nhấn
        {
            ogrinal = Input.mousePosition;
        }
      else if(Input.GetMouseButton(0)) // nhấn trượt thả
        { 
            delta_mouse = Input.mousePosition - ogrinal;
            ogrinal = Input.mousePosition;
        }
      else  //thả
        {
            delta_mouse = Vector3.zero;
            ogrinal = Vector3.zero;
        }

    }
}
