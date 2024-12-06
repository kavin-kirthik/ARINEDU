using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AR : MonoBehaviour
{
    [SerializeField] GameObject ar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.touchCount>0)
         {
            ar.SetActive(false);
            SceneManager.LoadScene(7);
         }
    }
}
