using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class titlego03 : MonoBehaviour
{
    private AudioSource audio4;
    [SerializeField]
    public AudioClip sound;
    // ボタンが押された場合、今回呼び出される関数

    void Start()
    {
       
        audio4 = gameObject.AddComponent<AudioSource>();
    }
    void Update()
    {
        //if (Input.GetKeyDown("joystick button 1"))
        //{
        //    Debug.Log("button1");
        //}
        
        if (Input.GetKeyDown("joystick button 0"))
        {
            audio4.PlayOneShot(sound);
            StartCoroutine("Titlego");
        }
    }
    IEnumerator Titlego()
    {


        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("Title");

    }
}