using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackanim : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {　//Aボタンを押すとAノーツの位置で剣攻撃のアニメーションが流れる
            animator.SetTrigger("Aslash");
            Debug.Log("A剣攻撃！");
        }
        if (Input.GetKeyDown("joystick button 1"))
        {　//Bボタンを押すとBノーツの位置で剣攻撃のアニメーションが流れる
            animator.SetTrigger("Bslash");
            Debug.Log("B剣攻撃！");
        }
        if (Input.GetKeyDown("joystick button 2"))
        {　//Xボタンを押すとXノーツの位置で魔法攻撃のアニメーションが流れる
            animator.SetTrigger("XBomb");
            Debug.Log("X魔法攻撃！");
        }
        if (Input.GetKeyDown("joystick button 3"))
        {　//Yボタンを押すとYノーツの位置で魔法攻撃のアニメーションが流れる
            animator.SetTrigger("YBomb");
            Debug.Log("Y魔法攻撃！");
        }
    }
}
