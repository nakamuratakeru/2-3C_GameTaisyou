using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    int maxHp = 100;
    int currentHp;
    public Slider slider;
    bool pushFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;

    }

    // Update is called once per frame
    void Update()
    {

        int damage = 20;

        if (Input.GetKeyDown("space")) //スペースキーを押したら
        {

            currentHp = currentHp - damage;
            Debug.Log("ダメージ");

            slider.value = (float)currentHp / (float)maxHp; ;
        }

    }
}
