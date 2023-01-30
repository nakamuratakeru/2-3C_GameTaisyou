using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydamage : MonoBehaviour
{
   
    private AudioSource audio;

    [SerializeField]
    private int damagePoint = 5;
    private bool isDamaged;
    public static bool atk;
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
       
        audio = gameObject.AddComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        atk = false;
        if (!isDamaged && collision.tag== "Atarihan")
       
        {
            var playerScript = collision.gameObject.GetComponent<HPbar>();
            playerScript.SetHp(playerScript.GetHp() - damagePoint);
            isDamaged = true;
            atk = true;
            audio.PlayOneShot(sound);
            Debug.Log(damagePoint + "ダメージを受けた");
            
            //gameObject.SetActive(false);
        }
       
    }
}