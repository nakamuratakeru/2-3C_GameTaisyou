using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{


    public int maxHp = 100;
    [SerializeField] GameObject GameclearCanvas;　//ゲームクリア時に表示されるクリアパネルを入れる
    [SerializeField] GameObject overPanel;
    private float step_time; //ゲームプレイ中の経過時間をカウントする
    //public int currentHp;
    Slider slider;
    public int dPoint = 0;
    public int gc = 0;
    public static bool clearflg = false;
    //bool pushFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;       // 経過時間初期化
        GameclearCanvas.SetActive(false);
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

        if (Title.Startkettei == true)
        {
            clearflg = false;
        }

        int damage = 10;
        step_time += Time.deltaTime;
        if (clearflg == true)
        {
            Debug.Log("trueのまま");
        }
        if (Input.GetKeyDown("space")) //スペースキーを押したら
        {

            slider.value = slider.value - damage;
            Debug.Log("ダメージ");

            //slider.value = (float)currentHp / (float)maxHp;

        }
        if (gc<=0&&slider.value == 0 && dPoint<=1)
        {
            
            dPoint += 1;
            overPanel.SetActive(true);
            Debug.Log("ゲームオーバー");

           

        }
        if (dPoint<=0&&step_time >= 10.0f && gc < 1) //プレイ開始から30秒経過するとゲームクリアパネルが表示される。
        {
            Debug.Log("ゲームクリア！");
            clearflg = true;
            GameclearCanvas.SetActive(true);
            gc += 1;
           

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
