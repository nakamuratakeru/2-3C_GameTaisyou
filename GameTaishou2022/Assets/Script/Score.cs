using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject ScoreText;
    public GameObject ComboText;

    Text score_text;
    Text combo_text;

    bool anotes;
    bool bnotes;
    bool xnotes;
    bool Aflg;
    bool Bflg;
    bool Xflg;
    int score;
    int combo;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        anotes = NotesRod.anotes;
        bnotes= NotesRod.bnotes;
        xnotes = NotesRod.xnotes;
        Aflg = NotesRod.Aflg;
        Bflg = NotesRod.Bflg;
        Xflg = NotesRod.Xflg;

        score_text = ScoreText.GetComponent<Text>();
        combo_text = ComboText.GetComponent<Text>();

        score_text.text = "Score:" + score;
        combo_text.text = "Combo:" + combo;

        if (anotes == true && Aflg == true)
        {
            score += 100;
            combo += 1;
        }

        if (bnotes==true&&Bflg == true)
        {
            score +=100;
            combo +=1;
        }

        if (xnotes == true && Xflg == true)
        {
            score += 100;
            combo += 1;
        }
    }
}
