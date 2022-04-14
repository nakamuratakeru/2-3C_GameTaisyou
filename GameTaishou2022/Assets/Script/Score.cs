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

  
    int score;
    int combo;


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {

        score = NotesRod.score;
        combo = NotesRod.combo;

        score_text = ScoreText.GetComponent<Text>();
        combo_text = ComboText.GetComponent<Text>();

        score_text.text = "Score:" + score;
        combo_text.text = "Combo:" + combo;

       
    }
}
