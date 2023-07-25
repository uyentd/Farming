using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform player;
    public Transform trans;
    private void Awake()
    {
        GameManager.instance.ShowMess();
    }
    // Start is called before the first frame update
    void Start()
    {
        trans = transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        trans.position = player.position;
    }

    // funtion thay đổi vị trí mới của camera theo newtaget
    public void ChangeTaget( Transform new_taget) // sẽ có 1 hoặc nhiều tham số, hoặc ko có 
    {
        player = new_taget;
    }
}
