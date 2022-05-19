using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Asobikata : MonoBehaviour
{
    private AudioSource audio3;

    [SerializeField]
    public AudioClip sound;
   
    void Start()
    {
        audio3 = gameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
       
        bool Startkettei = Input.GetKeyDown("joystick button 0");
        if (Startkettei == true)
        {
            audio3.PlayOneShot(sound);
            StartCoroutine("MenuBack");
        }
    }
    IEnumerator MenuBack()
    {


        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("MyMenu1");

    }
}