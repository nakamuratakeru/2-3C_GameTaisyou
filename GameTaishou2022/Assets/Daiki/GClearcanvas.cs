//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GClearcanvas : MonoBehaviour
//{
//    [SerializeField] GameObject GameclearCanvas;　//ゲームクリア時に表示されるクリアパネルを入れる
//    private float step_time; //ゲームプレイ中の経過時間をカウントする
//    public static bool clearflg = false;
//    int gc = 0;
//    // Start is called before the first frame update
//    void Start()
//    {
//        step_time = 0.0f;       // 経過時間初期化
//        GameclearCanvas.SetActive(false);
//    }

//    // Update is called once per frame
//    void Update()
//    {
       
//          step_time += Time.deltaTime;
//            //Debug.Log("計測中");
//            if (step_time >=110.0f && gc < 1)　//プレイ開始から30秒経過するとゲームクリアパネルが表示される。
//            {
//                Debug.Log("ゲームクリア！");
//                clearflg = true;
//                GameclearCanvas.SetActive(true);
//                gc += 1;
//            }
//        }
//    }

