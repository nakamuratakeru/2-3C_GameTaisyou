using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//スクリプトでUI(テキストなど)扱うときはこれ必須！！
using UnityEngine.SceneManagement;


public class cursorselectmenu : MonoBehaviour
{
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
            //Stage1へ移動
            SceneManager.LoadScene("SampleScene");
            //Time.timeScale = 1;

            //audio.PlayOneShot(sound2);

        }
        else if (Input.GetKeyDown("joystick button 0") && Iz == 1)
        {
            //Stage2へ移動
            SceneManager.LoadScene("Menu");

            //Time.timeScale = 1;

            //audio.PlayOneShot(sound2);

        }
        else if (Input.GetKeyDown("joystick button 0") && Iz == 2)
        {
            //Stage4へ移動
            SceneManager.LoadScene("Title");
            //audio.PlayOneShot(sound2);
        }

    }

    public void Puro()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if (x == +1 && Iz == 0)
        {
            transform.position += new Vector3(264, 0, 0);
            Iz = 1;
            //audio.PlayOneShot(sound);
        }
        else if (x == +1 && Iz == 1)
        {
            transform.position += new Vector3(232, 0, 0);
            Iz = 2;
            //audio.PlayOneShot(sound);
        }
        else if (x == -1 && Iz == 2)
        {
            transform.position += new Vector3(-232, 0, 0);
            Iz = 1;
            //audio.PlayOneShot(sound);
        }
        else if (x == -1 && Iz == 1)
        {
            transform.position += new Vector3(-264, 0, 0);
            Iz = 0;
            //audio.PlayOneShot(sound);
        }
    }
}