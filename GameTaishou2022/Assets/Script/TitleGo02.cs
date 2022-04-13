using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGo02: MonoBehaviour
{
    public static bool t = false;
    public void Title()
    {
        SceneManager.LoadScene("Title");

        t = true;
    }
}

