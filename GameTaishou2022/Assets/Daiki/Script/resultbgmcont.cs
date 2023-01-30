using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class resultbgmcont : MonoBehaviour
{
    private AudioSource audio5;
    [SerializeField]
    public AudioClip sound;
    public AudioClip sound2;
    public static int gCsound = 0;
    public static int gOsound = 0;
    // ボタンが押された場合、今回呼び出される関数

    void Start()
    {

        audio5 = gameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
        //if (Input.GetKeyDown("joystick button 1"))
        //{
        //    Debug.Log("button1");
        //}


        if (HPbar.clearflg == true && gCsound < 1)
        {
            audio5.PlayOneShot(sound2);
            gCsound += 1;
        }
        if (HPbar.overflg == true && gOsound < 1)
        {
            audio5.PlayOneShot(sound);
            gOsound += 1;

        }
       


    }

}