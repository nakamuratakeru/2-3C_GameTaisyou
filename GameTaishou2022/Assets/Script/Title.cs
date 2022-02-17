using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    //public AudioClip kettei;
    //AudioSource audioSource;

    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (Input.GetKeyDown("joystick button 1"))
        {
            Application.Quit();

        }
        bool Startkettei = Input.GetKeyDown("joystick button 0");
        if (Startkettei == true)
        {
            /*GetComponent<AudioSource>().Play(); */    //音を再生
            SceneManager.LoadScene("Menu");
        }
    }
}