using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CHATbOT : MonoBehaviour
{
    public Text user;
   public Button b1;
    public AudioSource aus;
    void Start()
    {
        b1.onClick.AddListener(validate);
    }

    
     
    void validate()
    {
         if(user.text.ToUpper()=="HELP")
        {
            aus.Play();
        }
       else if(user.text.ToUpper()=="EXIT")
        {
            SceneManager.LoadScene(0);
        }
    }
}
