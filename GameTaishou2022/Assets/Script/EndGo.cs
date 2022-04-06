using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGo : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClickStartButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        UnityEngine.Application.Quit();
#endif
        }
}
