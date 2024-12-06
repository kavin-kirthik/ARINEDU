using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    [SerializeField] Button start;
    [SerializeField] Button chatBot;
    [SerializeField] Button quit;
    void Start()
    {
        start.onClick.AddListener(begin);
        chatBot.onClick.AddListener(chatBots);
        quit.onClick.AddListener(quits);
    }
    void begin()
    {
        SceneManager.LoadScene(1);
    }
    void chatBots()
    {
        SceneManager.LoadScene(6);
    }
    void quits()
    {
        Application.Quit();
    }
    
     
     
}
