using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comman : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.touchCount>0)
        {
            transform.Rotate(0,0,1);
        }
    }
}
