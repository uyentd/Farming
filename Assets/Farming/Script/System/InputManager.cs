using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : BYSingletonMono<InputManager>
{
    public Vector3 move_dir;
    public bool isAttack;
    public bool isSwapChar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

    }
}
