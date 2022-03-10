using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesRod : MonoBehaviour
{
    GameObject Y;
    GameObject X;
    GameObject B;
    GameObject A;

    GameObject Ynotes;
    GameObject Xnotes;
    GameObject Bnotes;
    GameObject Anotes;

    bool ynotes=false;
    bool xnotes = false;
    bool bnotes = false;
    bool anotes = false;
    bool niceflg = false;

    float x_val;
    public float speed;

    Color Ycolor;

    // Start is called before the first frame update
    void Start()
    {
        bool Yflg =false;
        bool Xflg =false;
        bool Bflg =false;
        bool Aflg =false;

        //Ycolor = Y.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {

        Y = GameObject.Find("/NotesRod/Y");
        X = GameObject.Find("/NotesRod/X");
        B = GameObject.Find("/NotesRod/B");
        A = GameObject.Find("/NotesRod/A");

        if (Input.GetButtonDown("joystick button 3")){
            Y.GetComponent<Renderer>().material.color = Color.red;
            if (ynotes == true)
            {
                ynotes = false;
                Ynotes.SetActive(false);
                Destroy(Ynotes.gameObject.transform.root.gameObject);
            }
        }
        else if(Input.GetButtonUp("joystick button 3"))
        {
            Y.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetButtonDown("joystick button 2"))
        {
            X.GetComponent<Renderer>().material.color = Color.red;
            if (xnotes == true)
            {
                xnotes = false;
                Xnotes.SetActive(false);
                Destroy(Xnotes.gameObject.transform.root.gameObject);
            }
        }
        else if (Input.GetButtonUp("joystick button 2"))
        {
            X.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetButtonDown("joystick button 1"))
        {
            B.GetComponent<Renderer>().material.color = Color.red;
            if (bnotes == true)
            {
                bnotes = false;
                Bnotes.SetActive(false);
                Destroy(Bnotes.gameObject.transform.root.gameObject);
            }
        }
        else if (Input.GetButtonUp("joystick button 1"))
        {
            B.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetButtonDown("joystick button 0"))
        {
            A.GetComponent<Renderer>().material.color = Color.red;
            if (anotes == true)
            {
                anotes = false;
                Anotes.SetActive(false);
                Destroy(Anotes.gameObject.transform.root.gameObject);
            }
        }
        else if (Input.GetButtonUp("joystick button 0"))
        {
            A.GetComponent<Renderer>().material.color = Color.blue;
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Ynotes"))
        {
            Ynotes = other.gameObject;
            ynotes = true;
            Debug.Log("atari");
        }

        if (other.gameObject.CompareTag("Xnotes"))
        {
            Xnotes = other.gameObject;
            xnotes = true;
            Debug.Log("atari");
        }

        if (other.gameObject.CompareTag("Bnotes"))
        {
            Bnotes = other.gameObject;
            bnotes = true;
            Debug.Log("atari");
        }

        if (other.gameObject.CompareTag("Anotes"))
        {
            Anotes = other.gameObject;
            anotes = true;
            Debug.Log("atari");
        }

        if (other.gameObject.CompareTag("nice"))
        {
            Debug.Log("nice");
            niceflg = true;
            //perfect(red)  good(green) nice(bule) miss(white)
        }
    }
}
