using System.Collections;
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

        x_val = Input.GetAxis("Horizontal");

        if (x_val > 0)
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }

        if (x_val < 0)
        {
            transform.position = new Vector2(transform.position.x - speed , transform.position.y);
        }

        Y = GameObject.Find("/NotesRod/Y");
        X = GameObject.Find("/NotesRod/Y");
        B = GameObject.Find("/NotesRod/Y");
        A = GameObject.Find("/NotesRod/Y");

        if (Input.GetButtonDown("joystick button 3")){
            Y.GetComponent<Renderer>().material.color = Color.red;
            if (ynotes == true)
            {
                notes.SetActive(false);
            }
        }
        else if(Input.GetButtonUp("joystick button 3"))
        {
            Y.GetComponent<Renderer>().material.color = Color.blue;
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
    }
}
