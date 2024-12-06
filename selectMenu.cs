using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class selectMenu : MonoBehaviour
{
    [SerializeField] Button bt1;
    [SerializeField] Button bt2;
    [SerializeField] Button bt3;
    [SerializeField] Button bt4;
    void Start()
    {
        bt1.onClick.AddListener(Desktop);
        bt2.onClick.AddListener(Tv);
        bt3.onClick.AddListener(GhandhiJi);
        bt4.onClick.AddListener(MotherBoard);
    }

    
    void Desktop()
    {
        SceneManager.LoadScene(2);
    }
    void Tv()
    {
         SceneManager.LoadScene(5);
    }
    void GhandhiJi()
    {
         SceneManager.LoadScene(4);
    }
    void MotherBoard()
    {
        SceneManager.LoadScene(3);
    }
}
