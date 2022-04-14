using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//スクリプトでUI(テキストなど)扱うときはこれ必須！！
using UnityEngine.SceneManagement;


public class cursorselectmenu : MonoBehaviour
{
    public int It = 0;
    public int Iz = 0;
    public int i = 0;

    //private AudioSource audio;

    //[SerializeField]
    //public AudioClip sound;
    //public AudioClip sound2;

    //スタート関数
    void Start()
    {
        //audio = gameObject.AddComponent<AudioSource>();
    }

    //アップデート関数
    void Update()
    {
        float y = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");

        if (y == +1 || y == -1 || x == +1 || x == -1)
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

        if (Input.GetKeyDown("joystick button 0") && It == 0 && Iz == 0)
        {
            //Stage1へ移動
            SceneManager.LoadScene("SampleScene");
            //Time.timeScale = 1;

            //audio.PlayOneShot(sound2);

        }
        else if (Input.GetKeyDown("joystick button 0") && It == 0 && Iz == 1)
        {
            //Stage2へ移動
            SceneManager.LoadScene("Asobikata");

            //Time.timeScale = 1;

            //audio.PlayOneShot(sound2);

        }
        else if (Input.GetKeyDown("joystick button 0") && It == 1 && Iz == 0)
        {
            //Stage3へ移動
            //SceneManager.LoadScene("stage3");

            //audio.PlayOneShot(sound2);
        }
        else if (Input.GetKeyDown("joystick button 0") && It == 1 && Iz == 1)
        {
            //Stage4へ移動
            SceneManager.LoadScene("Title");
            //audio.PlayOneShot(sound2);
        }

    }

    public void Puro()
    {
        float y = Input.GetAxisRaw("Vertical");
        float x = Input.GetAxisRaw("Horizontal");

        if (y == -1 && It == 0)
        {
            transform.position += new Vector3(0, -151, 0);
            It = 1;
            //audio.PlayOneShot(sound);
        }
        else if (y == +1 && It == 1)
        {
            transform.position += new Vector3(0,151, 0);
            It = 0;
            //audio.PlayOneShot(sound);
        }

        if (x == +1 && Iz == 0)
        {
            transform.position += new Vector3(370, 0, 0);
            Iz = 1;
            //audio.PlayOneShot(sound);
        }
        else if (x == -1 && Iz == 1)
        {
            transform.position += new Vector3(-370, 0, 0);
            Iz = 0;
            //audio.PlayOneShot(sound);
        }
    }
}