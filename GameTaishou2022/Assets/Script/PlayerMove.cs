using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
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

       


        if (Input.GetKeyDown("joystick button 0")){ //Aボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("sword");
            Debug.Log("Aで攻撃！");
        }

   
        if (Input.GetKeyDown("joystick button 1")){　//Bボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("sword");
            Debug.Log("Bで攻撃！");
        }
        if (Input.GetKeyDown("joystick button 2")){　//Xボタンを押すと魔法の杖のアニメーションが流れる
            animator.SetTrigger("magic");
            Debug.Log("Xで攻撃！");
        }
        if (Input.GetKeyDown("joystick button 5"))
        {　//RBボタンを押すと魔法の杖のアニメーションが流れる
            animator.SetTrigger("magic");
            Debug.Log("RB(X)で攻撃！");
        }
        if (Input.GetKeyDown("joystick button 3")){　//Yボタンを押すと魔法の杖のアニメーションが流れる
            animator.SetTrigger("magic");
            Debug.Log("Yで攻撃！");
        }



        float Xyoko_new = Input.GetAxisRaw("LT");
        float Xtate_new = Input.GetAxisRaw("RT");






        if (Xtate_new == -1)
        { //Aボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("sword");
            Debug.Log("下キー(A)で攻撃！");
           
           
        }

        if (Xyoko_new == -1)
        {　//Bボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("sword");
            Debug.Log("左キー(B)で攻撃！");
          
        }
        // Xtate == -1
    }
}
