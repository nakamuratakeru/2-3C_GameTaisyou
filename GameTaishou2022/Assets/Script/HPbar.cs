using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{


    public int maxHp = 100;
    [SerializeField] GameObject overPanel;
    //public int currentHp;
    Slider slider;
    public int dPoint = 0;
    //bool pushFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        overPanel.SetActive(false);
        //slider = GameObject.FindWithTag("HPslider").GetComponent<Slider>();
        slider = GameObject.Find("Slider").GetComponent<Slider>();




        //現在のHPを最大HPと同じに。
        slider.maxValue= maxHp;

        slider.value = 100;
       

    }

    //Update is called once per frame
    void Update()
    {

        int damage = 10;

        if (Input.GetKeyDown("space")) //スペースキーを押したら
        {

            slider.value = slider.value - damage;
            Debug.Log("ダメージ");

            //slider.value = (float)currentHp / (float)maxHp;

        }
        if (slider.value == 0 && dPoint<1)
        {
            
            dPoint += 1;
            overPanel.SetActive(true);
            Debug.Log("ゲームオーバー");

           

        }


    }
    public void SetHp(int HP)
    {
        slider.value =HP;
       
    }

    public int GetHp()
    {
        return (int)this.slider.value;
    }
}
