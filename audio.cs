using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class audio : MonoBehaviour
{
    public static int route1=1;
    public AudioSource aus;
     public void begin()
     {
        aus.Play();
         StartCoroutine("start");
     }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator start()
    {
        yield return new WaitForSeconds(15f);
         
         
        SceneManager.LoadScene(9);
    }
}
