using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseViewAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Reset()
    {
        gameObject.name = this.GetType().ToString();
    }

}
