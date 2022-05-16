using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScore : MonoBehaviour
{

    public GameObject resultscore;
    public GameObject MaxCombo;

    Text resultscore_text;
    Text maxcombo_text;

    int TotalPoint;
    int score;

    int combo;
    int maxcombo;

    // Start is called before the first frame update
    void Start()
    {
        TotalPoint = NotesRod.score;
        maxcombo = NotesRod.maxcombo;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(TotalPoint);
        resultscore_text = resultscore.GetComponent<Text>();
        maxcombo_text = MaxCombo.GetComponent<Text>();

        if (TotalPoint >= score)
        {
            score+=50;
            resultscore_text.text= "Score:" + score;
        }

        if (maxcombo >= combo)
        {
            combo++;
            maxcombo_text.text = "Combo:" + combo;
        }

    }
}
