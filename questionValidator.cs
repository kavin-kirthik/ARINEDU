using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class questionValidator : MonoBehaviour
{
    public Button ans1;
     public Button ans2;
      public Button ans3;
       public Button ans4;
       public Text question;
       public Text q1;
       public Text q2;
       public Text q3;
       public Text q4;
     public static int mark;
        
       int q;
    void Start()
    {
        q=1;
        ans1.onClick.AddListener(ans1st);
        ans2.onClick.AddListener(ans2nd);
        ans3.onClick.AddListener(ans3rd);
        ans4.onClick.AddListener(ans4th);
    }
    void Update()
    {
        if(q==1)
        {
            question.text="1st MACINOTSH MODEL RELEASED IN?";
            q1.text="1984";
            q2.text="2000";
            q3.text="1947";
            q4.text="2004";
        }
        if(q==2)
        {
            question.text="WHO RELEASD FIRST GUI?";
            q1.text="ACER";
            q2.text="APPLE";
            q3.text="MICROSOFT";
            q4.text="LENEVO";
        }
        if(q==3)
        {
            question.text="PROCESSOR OF 1ST MACINTOSH?";
            q1.text="INTEL";
            q2.text="AMD";
            q3.text="MOTOROLA 68K";
            q4.text="RYZEN";
        }
        if(q==4)
        {
            question.text="WHAT YEARD DID IPHONE CAME OUT?";
            q1.text="1999";
            q2.text="2019";
            q3.text="2004";
            q4.text="2007";
        }
        
    }
   
     void ans1st()
     {
        if(q==1)
        {
            Debug.Log("correct");
           q+=1;
            mark+=1; 
        }
        else
        {
            q+=1;
            Debug.Log("wrong");
            
        }
     }
     void ans2nd()
     {
        if(q==2)
        {
          
            Debug.Log("correct");
            q+=1;
              mark+=1; 
        }
        else
        {
           
            Debug.Log("wrong");
            q+=1;
        }
     }
     void ans3rd()
     {
        if(q==3)
        {
           
            Debug.Log("correct");
            q+=1;
             mark+=1; 
        }
        else
        {
            
            Debug.Log("wrong");
            q+=1;
        }
     }
     void ans4th()
     {
        if(q==4)
        {
            q+=1;
            Debug.Log("correct");
             mark+=1;
             SceneManager.LoadScene(9);
        }
        else
        {
           q+=1;
            Debug.Log("wrong");
        }
     }
}
