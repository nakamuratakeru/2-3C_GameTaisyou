using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//スクリプトでUI(テキストなど)扱うときはこれ必須！！
using UnityEngine.SceneManagement;


public class cursorselectmenu : MonoBehaviour
{
    public int Iz = 0;
    public int i = 0;


    private AudioSource audio; 

    [SerializeField]
    public AudioClip sound; //ボタン決定音を入れる関数
    public AudioClip sound2;//カーソル決定音を入れる

    
    //スタート関数
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }

    //アップデート関数
    void Update()
    {
        
        float x = Input.GetAxisRaw("Horizontal");

        if (x == -1 || x == +1)
        {
            if (i == 0)
            {
                Puro();
                i++;
            }
        }
        else
        {
            i = 0;
        }

        if (Input.GetKeyDown("joystick button 0") && Iz == 0)
        {
            //ゲームシーンへ移動
          
            audio.PlayOneShot(sound);
            SceneManager.LoadScene("SampleScene");
            Debug.Log("ゲームへ");
            if (Title.resetflg == true)//resetflgがtrueなら
            {
                NotesRod.score = 0;//scoreの数を0にする
                NotesRod.combo = 0;//comboの数を0にする
                NotesRod.maxcombo = 0;//maxcomboの数を0にする
               
                
            }
           

        }
        else if (Input.GetKeyDown("joystick button 0") && Iz == 1)
        {
            
            audio.PlayOneShot(sound);
            StartCoroutine("Asobikata");


        }
        else if (Input.GetKeyDown("joystick button 0") && Iz == 2)
        {
            
            audio.PlayOneShot(sound);
            StartCoroutine("Titlego");
          
        }

    }

    //IEnumerator GameStart()
    //{


    //    yield return new WaitForSecondsRealtime(0.5f);
    //    SceneManager.LoadScene("SampleScene");

    //}
    IEnumerator Asobikata()
    {


        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("Menu");

    }
    IEnumerator Titlego()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("Title");
    }

    public void Puro()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if (x == +1 && Iz == 0)
        {
            transform.position += new Vector3(264, 0, 0);
            Iz = 1;
            audio.PlayOneShot(sound2);
        }
        else if (x == +1 && Iz == 1)
        {
            transform.position += new Vector3(232, 0, 0);
            Iz = 2;
            audio.PlayOneShot(sound2);
        }
        else if (x == -1 && Iz == 2)
        {
            transform.position += new Vector3(-232, 0, 0);
            Iz = 1;
            audio.PlayOneShot(sound2);
        }
        else if (x == -1 && Iz == 1)
        {
            transform.position += new Vector3(-264, 0, 0);
            Iz = 0;
            audio.PlayOneShot(sound2);
        }
    }
}