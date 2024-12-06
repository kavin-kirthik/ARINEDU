using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class descriptor : MonoBehaviour
{
    public Text t;
    int loopStop=0;
    int c=0;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0))
        {
            c+=1;
            if(c==1)
            {
                t.text="CREATED BY APPLE 1984";
            }
            if(c==2)
            {
                t.text="USES MOTOROLA 68K PROCESSOR";
            }
            if(c==3)
            {
                t.text="USES 1.0 OS";
            }
            if(c==4)
            {
                t.text="USES SINGLE MOUSE BUTTON MOUSE";
            }
            if(c==5)
            {
                t.text="FIRST GUI DEVICE";
            }
            if(c==6)
            {
                t.text="WITH THIS LETS START A TEST";
            }
            if(c==7)
            {
                SceneManager.LoadScene(8);
            }
        }
        else
        {
            loopStop=0;
        }
    }
}
