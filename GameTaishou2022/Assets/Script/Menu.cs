//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.EventSystems;
//using System.Collections;
//using System.Collections.Generic;

//public class Menu : MonoBehaviour
//{
//    //[SerializeField] private Button pauseButton;
//    [SerializeField] private GameObject pausePanel;
//    [SerializeField] private Button resumeButton;
//    [SerializeField] private GameObject button1, button2, button3;
//    int startflag = 0;
//    public bool Opeflg;

//    //public Button FirstSelectButton;
//    Button Restart;
//    Button Title;
//    Button Exit;

//    void Awake()
//    {
//        Restart = GameObject.Find("/Menu/exit").GetComponent<Button>();
//        Title = GameObject.Find("/Menu/title").GetComponent<Button>();
//        Exit = GameObject.Find("/Menu/Restart").GetComponent<Button>();

//        pausePanel.SetActive(false);
//        button1.SetActive(false);
//        button2.SetActive(false);
//        button3.SetActive(false);
//        Opeflg = true;

//        //pauseButton.onClick.AddListener(Pause);
//        //resumeButton.onClick.AddListener(Resume);

//    }

//    void Update()
//    {
//        bool start = Input.GetButtonDown("Pause");


//        if (start == true && startflag == 0)
//        {

//            Time.timeScale = 0f;//時間停止
//            pausePanel.SetActive(true);
//            button1.SetActive(true);
//            button2.SetActive(true);
//            button3.SetActive(true);
//            Opeflg = false;
//            Restart.Select();
//            startflag = 1;

//            Debug.Log("START");
//            Debug.Log(startflag);
//        }

//        else if (start == true && startflag == 1)
//        {
//            Time.timeScale = 1f;//戻る
//            pausePanel.SetActive(false);
//            button1.SetActive(false);
//            button2.SetActive(false);
//            button3.SetActive(false);
//            Opeflg = true;
//            EventSystem.current.SetSelectedGameObject(null);
//            startflag = 0;


//            Debug.Log("START");
//            Debug.Log(startflag);

//        }
//        //Debug.Log(startflag);

//    }

//    //        Time.timeScale = 1;//再開
//    //        pausePanel.SetActive(false);
//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{

    // ボタンが押された場合、今回呼び出される関数
    void Update()
    {
        //if (Input.GetKeyDown("joystick button 1"))
        //{
        //    Debug.Log("button1");
        //}
        bool Startkettei = Input.GetKeyDown("joystick button 0");
        if (Startkettei == true)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}