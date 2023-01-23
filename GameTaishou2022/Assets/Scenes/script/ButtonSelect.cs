using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelect : MonoBehaviour
{
    Button button;
    void OnEnable()
    {
        button = GameObject.Find("GameclearCanvas/Panel/Result").GetComponent<Button>();
        //ボタンが選択された状態になる
        button.Select();

    }

}