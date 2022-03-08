﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesRod : MonoBehaviour
{
    GameObject Y;
    GameObject X;
    GameObject B;
    GameObject A;

    GameObject notes;
    bool ynotes=false;
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
                notes.SetActive(false);
                Destroy(notes.gameObject.transform.root.gameObject);
            }
        }
        else if(Input.GetButtonUp("joystick button 3"))
        {
            Y.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetButtonDown("joystick button 2"))
        {
            X.GetComponent<Renderer>().material.color = Color.red;
            if (ynotes == true)
            {
                ynotes = false;
                notes.SetActive(false);
                Destroy(notes.gameObject.transform.root.gameObject);
            }
        }
        else if (Input.GetButtonUp("joystick button 2"))
        {
            X.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetButtonDown("joystick button 1"))
        {
            B.GetComponent<Renderer>().material.color = Color.red;
            if (ynotes == true)
            {
                ynotes = false;
                notes.SetActive(false);
                Destroy(notes.gameObject.transform.root.gameObject);
            }
        }
        else if (Input.GetButtonUp("joystick button 1"))
        {
            B.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetButtonDown("joystick button 0"))
        {
            A.GetComponent<Renderer>().material.color = Color.red;
            if (ynotes == true)
            {
                ynotes = false;
                notes.SetActive(false);
                Destroy(notes.gameObject.transform.root.gameObject);
            }
        }
        else if (Input.GetButtonUp("joystick button 0"))
        {
            A.GetComponent<Renderer>().material.color = Color.blue;
        }



    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("notes"))
        {
            notes = other.gameObject;
            ynotes = true;
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
