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
    public static  int dPoint = 0;
    public static  int gc = 0;
    public static int rf = 0; //リセットフラグをfalseにする処理が複数起こるのを防ぐ為作成した関数
    public static bool clearflg = false;
    public static bool overflg = false;
   
    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;
        Debug.Log("経過時間初期化");// 経過時間初期化
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
            overflg = false;
            dPoint = 0;
            gc = 0;
            resultbgmcont.gCsound = 0;
            resultbgmcont.gOsound = 0;
            Debug.Log("リセット");
        }
        if (rf<1&&step_time >= 1.0f)
        {
            Title.resetflg = false;
            Debug.Log("リセットフラグ発動");
            rf += 1;
        }
        
        
        step_time += Time.deltaTime;
        
        if (gc<=0&&slider.value == 0 && dPoint<=1)//hpが0になるとゲームオーバーパネルが表示される
        {
            
            dPoint += 1;
            overflg = true;
            overPanel.SetActive(true);
            Debug.Log("ゲームオーバー");

           

        }
        if (dPoint<=0&&step_time >=105.0f && gc < 1) //プレイ開始から105秒経過するとゲームクリアパネルが表示される。
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
