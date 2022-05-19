using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resultchange : MonoBehaviour
{
    
    public void result()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}

