﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
   

    public static bool Startkettei=false;
    public static bool resetflg = false; //スコアをリセットするために必要な関数resetflgを定義
    private AudioSource audio2;
    public static int mms = 0;
    [SerializeField]
    public AudioClip sound;
    void Start()
    {
        resetflg = true;　//タイトル画面に移るとresetflgをtrueにする
        if (StageSentaku.S1flag == true)
        {
            Debug.Log("S1フラグfalse");
            StageSentaku.S1flag = false;
        }
        if (StageSentaku.S2flag == true) {
            Debug.Log("S2フラグfalse");
            StageSentaku.S2flag = false;
        }
        if (StageSentaku.S3flag == true)
        {
            Debug.Log("S3フラグfalse");
            StageSentaku.S3flag = false;
        }

        //DontDestroyOnLoad(gameObject);
        audio2 = gameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
        //Startkettei = Input.GetKeyDown("joystick button 0");
        //if (Startkettei == true)
        if (Input.GetKeyDown("joystick button 0"))
        {
            
                Startkettei = true;

                audio2.PlayOneShot(sound);
                //mms += 1;
                //SceneManager.LoadScene("MyMenu1");
                Debug.Log("タイトルからメニューへ");
                StartCoroutine("TitleSE");
            
        }

        else if (Input.GetKeyDown("joystick button 1"))
        {
            audio2.PlayOneShot(sound);
            StartCoroutine("TitleSE2");
        }
    }

    IEnumerator TitleSE()
    {


        yield return new WaitForSecondsRealtime(0.5f);
        mms += 1;
        SceneManager.LoadScene("MyMenu1");

    }
    IEnumerator TitleSE2()
    {
       yield return new WaitForSecondsRealtime(0.5f);
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        UnityEngine.Application.Quit();
#endif


    }
}
