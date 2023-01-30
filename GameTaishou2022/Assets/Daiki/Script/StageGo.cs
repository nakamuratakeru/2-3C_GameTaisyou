using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageGo : MonoBehaviour
{
    private float go_time;    // 経過時間カウント用
    // Start is called before the first frame update
    void Start()
    {
        go_time = 0.0f;       // 経過時間初期化
    }

    // Update is called once per frame
    void Update()
    {
        // 経過時間をカウント
        go_time += Time.deltaTime;

        // 3秒後に画面遷移（scene2へ移動）
        if (go_time >= 6.0f&&StageSentaku.S1flag)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if(go_time >= 6.0f && StageSentaku.S2flag)
        {
            SceneManager.LoadScene("NewSong");
        }
    }
}
