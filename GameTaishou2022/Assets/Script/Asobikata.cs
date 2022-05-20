using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Asobikata : MonoBehaviour
{
    private AudioSource audio3; //音を入れる関数

    [SerializeField]
    public AudioClip sound;　//ヒエラルキーに音を入れられるようにする関数
   
    void Start()
    {
        audio3 = gameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
       
        bool Startkettei = Input.GetKeyDown("joystick button 0");　//Ａボタンが押されると、StartKetteiをtrueにする
        if (Startkettei == true)//StartKetteiがtrueの場合、音を鳴らし、MenuBack()の処理へ移行する
        {
            audio3.PlayOneShot(sound); 
            StartCoroutine("MenuBack");
        }
    }
    IEnumerator MenuBack()
    {


        yield return new WaitForSecondsRealtime(0.5f);//0.5秒待つ
        SceneManager.LoadScene("MyMenu1");//MyMenu1(遊び方説明シーン)へ移行

    }
}