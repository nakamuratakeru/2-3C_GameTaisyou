using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect : MonoBehaviour
{

    bool nice;
    bool good;
    bool great;


    int time;

    public Text nicetx;
    public Text goodtx;
    public Text greattx;

    // Start is called before the first frame update
    void Start()
    {
        nicetx.enabled = false;
        goodtx.enabled = false;
        greattx.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        nice = NotesRod.nicetxflg;
        good = NotesRod.goodtxflg;
        great = NotesRod.greattxflg;

        if (nice == true)
        {
            nicetx.enabled = true;
            StartCoroutine("TextSet");

        }

        if (good == true)
        {
            goodtx.enabled = true;
        }

        else if(good==false)
        {
            goodtx.enabled = false;
        }

        if (great == true)
        {
            greattx.enabled = true;
        }

        else if(great==false)
        {
            greattx.enabled = false;
        }



    }


    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        nicetx.enabled = false;
    }
}
