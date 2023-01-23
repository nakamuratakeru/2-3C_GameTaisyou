using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    [SerializeField] private AudioSource sound1;

    void Start()
    {
        //Componentを取得
        //sound1 = GetComponent<AudioSource>();
    }

    public void BGMStart() //ボタンを押したら
    {
        sound1.Play();　//bgm再生
        Debug.Log("再生");
    }

    public void BGMPause()
    {
        sound1.Pause(); //bgm一時停止
        Debug.Log("中断");
    }

    public void BGMUnPause()
    {
        sound1.UnPause(); //bgm再開
        Debug.Log("再開");
    }

    void Update()
    {
        
    }
}
