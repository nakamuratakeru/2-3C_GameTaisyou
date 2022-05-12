using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;//追加
using UnityEngine.SceneManagement;//追加

public class SceneController : MonoBehaviour
{
    public GameObject fadeCanvas;//操作するCanvas、タグで探す
    public GameObject fade;
    private float step_time;

    void Start()
    {
        if (!FadeManager.isFadeInstance)//isFadeInstanceは後で用意する
        {
            Instantiate(fade);
        }
        Invoke("findFadeObject", 0.02f);//起動時用にCanvasの召喚をちょっと待つ

        step_time = 0.0f;
    }
    void Update()
    {
        step_time += Time.deltaTime;

        if (step_time >= 5.0f)
        {
            SceneManager.LoadScene("KARIScene");
        }
    }

    void findFadeObject()
    {
        fadeCanvas = GameObject.FindGameObjectWithTag("Fade");//Canvasをみつける
        fadeCanvas.GetComponent<FadeManager>().fadeIn();//フェードインフラグを立てる
    }

    public async void sceneChange(string sceneName)//ボタン操作などで呼び出す
    {
        fadeCanvas.GetComponent<FadeManager>().fadeOut();//フェードアウトフラグを立てる
        await Task.Delay(200);//暗転するまで待つ
        SceneManager.LoadScene("EyeCatching");//シーンチェンジ

    }
}