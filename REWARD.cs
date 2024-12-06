using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class REWARD : MonoBehaviour
{
     questionValidator qv;
     public Animator anim;
     public GameObject text;
     public Text t;
     
     
    void Start()
    {
        Debug.Log(questionValidator.mark);
        text.SetActive(false);
        StartCoroutine("start");
      
    }

    // Update is called once per frame
    void Update()
    {
        if(questionValidator.mark==4)
        {
            Debug.Log("50 points");
        }
        if(questionValidator.mark==3)
        {
            Debug.Log("40 points");
        }
        if(questionValidator.mark==2)
        {
            Debug.Log("20 points");
        }
        if(questionValidator.mark==1)
        {
            Debug.Log("10 points");
        }
        if(Input.touchCount>0)
        {
            
            anim.SetBool("open",true);
        }
    }
    IEnumerator start()
    {
        yield return new WaitForSeconds(4f);
        text.SetActive(true);
        t.text="YOU EARN:"+"4";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
