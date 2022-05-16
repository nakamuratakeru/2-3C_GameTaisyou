using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;//追加
using UnityEngine.SceneManagement;//追加

public class SceneController : MonoBehaviour
{
    public GameObject fadeCanvas;//操作するCanvas、タグで探す
    public GameObject fade;
    public float step_time;
    public int SceneCount = 0;

    void Start()
    {
        if (!FadeManager.isFadeInstance)//isFadeInstanceは後で用意する
        {
            Instantiate(fade);
        }
        Invoke("findFadeObject", 0.02f);//起動時用にCanvasの召喚をちょっと待つ

        step_time = 0.0f;
    }
    public void Update()
    {
        if (SceneCount == 1)
        {
            step_time += Time.deltaTime;
            Debug.Log("カウント");

        }
        if (step_time >= 3.0f)
        {
            SceneManager.LoadScene("KARIScene");
            Debug.Log("フェード");
        }
        
    }


    public void findFadeObject()
    {
        fadeCanvas = GameObject.FindGameObjectWithTag("Fade");//Canvasをみつける
        fadeCanvas.GetComponent<FadeManager>().fadeIn();//フェードインフラグを立てる
    }

    public async void sceneChange(string sceneName)//ボタン操作などで呼び出す
    {
        fadeCanvas.GetComponent<FadeManager>().fadeOut();//フェードアウトフラグを立てる
        await Task.Delay(200);//暗転するまで待つ
        SceneManager.LoadScene("EyeCatching");//シーンチェンジ

        SceneCount += 1;
    }
}