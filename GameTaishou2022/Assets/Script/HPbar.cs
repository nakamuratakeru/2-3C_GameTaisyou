using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{


    public int maxHp = 100;
    //public int currentHp;
    Slider slider;
    //bool pushFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        //slider = GameObject.FindWithTag("HPslider").GetComponent<Slider>();
        slider = GameObject.Find("Slider").GetComponent<Slider>();




        //現在のHPを最大HPと同じに。
        slider.maxValue= maxHp;

        slider.value = 100;
       

    }

    // Update is called once per frame
    //void Update()
    //{

    //    int damage = 20;

    //    if (Input.GetKeyDown("space")) //スペースキーを押したら
    //    {

    //        slider.value = slider.value - damage;
    //        Debug.Log("ダメージ");

    //        //slider.value = (float)currentHp / (float)maxHp;
           
    //    }

    //}
    public void SetHp(int HP)
    {
        slider.value =HP;
       
    }

    public int GetHp()
    {
        return (int)this.slider.value;
    }
}
