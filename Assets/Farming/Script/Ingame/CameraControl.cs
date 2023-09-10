using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform Limit_left;
    public Transform Limit_right;
    public Transform trans_cam;
    private float pos_x;
    public float sensity = 1;
    public float speed;
    private void Awake()
    {
        //GameManager.instance.ShowMess();
    }
    // Start is called before the first frame update
    void Start()
    {
       //trans_cam = transform;
    }

    void Update()
    {

    }
    // Update is called once per frame
    private void LateUpdate()
    {
        //Debug.LogError(" đã chạy vào late update");
        //trans.position = player.position;
        /* Vector3 delta_move = InputManager.delta_mouse;
         pos_x = trans_cam.localPosition.x;
         pos_x = Mathf.Lerp(pos_x, pos_x - delta_move.x * sensity, Time.deltaTime * speed);
         pos_x = Mathf.Clamp(pos_x, Limit_left.localPosition.x, Limit_right.localPosition.x);
         trans_cam.localPosition = new Vector3(pos_x ,trans_cam.localPosition.y, trans_cam.localPosition.z);*/
        //Debug.LogError("đã chạy hết late update"); 

        Vector3 delta_move = InputManager.delta_mouse;
        pos_x = trans_cam.localPosition.x;
        pos_x = Mathf.Lerp(pos_x, pos_x - delta_move.x * sensity, Time.deltaTime * speed); // set speed và sensity của input
        pos_x = Mathf.Clamp(pos_x, Limit_left.localPosition.x, Limit_right.localPosition.x);// set limit 2 đầu
        trans_cam.localPosition = new Vector3(pos_x, trans_cam.localPosition.y, trans_cam.localPosition.z);
    }

    // funtion thay đổi vị trí mới của camera theo newtaget
    public void ChangeTaget( Transform new_taget) // sẽ có 1 hoặc nhiều tham số, hoặc ko có 
    {
       // player = new_taget;
    }
}
