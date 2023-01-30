using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackanim : MonoBehaviour
{

    float Xtate_old;
    float Xyoko_old;
    Animator animator;
    private AudioSource audio;
   

    [SerializeField]
    public AudioClip sound;
    public AudioClip sound2;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audio = gameObject.AddComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {　//Aボタンを押すとAノーツの位置で剣攻撃のアニメーションが流れる
            animator.SetTrigger("Aslash");
            audio.PlayOneShot(sound);
        }
        if (Input.GetKeyDown("joystick button 1"))
        {　//Bボタンを押すとBノーツの位置で剣攻撃のアニメーションが流れる
            animator.SetTrigger("Bslash");
            audio.PlayOneShot(sound);
        }
        if (Input.GetKeyDown("joystick button 2"))
        {　//Xボタンを押すとXノーツの位置で魔法攻撃のアニメーションが流れる
            animator.SetTrigger("XBomb");
            audio.PlayOneShot(sound2);
        }
        //if (Input.GetKeyDown("joystick button 3"))
        //{　//Yボタンを押すとYノーツの位置で魔法攻撃のアニメーションが流れる
        //    animator.SetTrigger("YBomb");
        //    Debug.Log("Y魔法攻撃！");
        //}

        if (Input.GetKeyDown("joystick button 5"))
        {　//RBボタンを押すと魔法の杖のアニメーションが流れる
            animator.SetTrigger("XBomb");
            audio.PlayOneShot(sound2);
        }

        if (enemydamage.atk == true)
        {
            animator.SetTrigger("damage");
            Debug.Log("プレイヤーにダメージ！");
            

        }

        float Xyoko_new = Input.GetAxisRaw("LT");
        float Xtate_new = Input.GetAxisRaw("RT");

       
        if (Xtate_new == -1 && Xtate_old==0)
        { //Aボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("Aslash");
            Debug.Log("RTキー");
            audio.PlayOneShot(sound);
        }

        if (Xyoko_new == -1 && Xyoko_old==0)
        {　//Bボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("Bslash");
            Debug.Log("LTキー");
            audio.PlayOneShot(sound);
        }
        // Xtate == -1
        Xtate_old = Xtate_new;
        Xyoko_old = Xyoko_new;
    }
}


