using UnityEngine;
using UnityEngine.UI;

public class Buttonclick : MonoBehaviour
{

    Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
    }

    public void OneClick()
    {
        btn.interactable = false;
    }
}