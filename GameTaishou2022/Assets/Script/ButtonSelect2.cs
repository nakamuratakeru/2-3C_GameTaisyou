using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelect2: MonoBehaviour
{
    Button button;
    void OnEnable()
    {
        button = GameObject.Find("GameOverCanvas/Panel/TitleButton").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();

    }

}