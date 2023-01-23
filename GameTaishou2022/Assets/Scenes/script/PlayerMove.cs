using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float Xtate_old;
    float Xyoko_old;
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
            
        }

   
        if (Input.GetKeyDown("joystick button 1")){　//Bボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("sword");
           
        }
        if (Input.GetKeyDown("joystick button 2")){　//Xボタンを押すと魔法の杖のアニメーションが流れる
            animator.SetTrigger("magic");
           
        }
        if (Input.GetKeyDown("joystick button 5"))
        {　//RBボタンを押すと魔法の杖のアニメーションが流れる
            animator.SetTrigger("magic");
            
        }
       



        float Xyoko_new = Input.GetAxisRaw("LT");
        float Xtate_new = Input.GetAxisRaw("RT");






        if (Xtate_new == -1 && Xtate_old == 0)
        { //Aボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("sword");
            
           
           
        }

        if (Xyoko_new == -1 && Xyoko_old == 0)
        {　//Bボタンを押すと剣のアニメーションが流れる
            animator.SetTrigger("sword");
           
          
        }
        
        Xtate_old = Xtate_new;
        Xyoko_old = Xyoko_new;
    }
}
