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

    public static bool ynotes;
    public static bool xnotes;
    public static bool bnotes;
    public static bool anotes;
    bool niceflg = false;

    public static bool Aflg;
    public static bool Bflg;
    public static bool Xflg;

    float x_val;
    public float speed;

    Color Ycolor;

    // Start is called before the first frame update
    void Start()
    {
    ynotes = false;
    xnotes = false;
    bnotes = false;
    anotes = false;


        bool Yflg =false;
        bool Bflg =false;
        Aflg =false;
        Bflg = false;
        Xflg = false;

        //Ycolor = Y.GetComponent<Renderer>().material.color;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Ynotes"))
        {
            Ynotes = other.gameObject;
            ynotes = true;
        }

        if (other.gameObject.CompareTag("Xnotes"))
        {
            Xnotes = other.gameObject;
            xnotes = true;
        }

        if (other.gameObject.CompareTag("Bnotes"))
        {
            Bnotes = other.gameObject;
            bnotes = true;
        }

        if (other.gameObject.CompareTag("Anotes"))
        {
            Anotes = other.gameObject;
            anotes = true;
        }

        if (other.gameObject.CompareTag("nice"))
        {
            niceflg = true;
            //perfect(red)  good(green) nice(bule) miss(white)
        }
    }

    // Update is called once per frame
    void Update()
    {

        float Xyoko = Input.GetAxisRaw("LT");
        float Xtate = Input.GetAxisRaw("RT");

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

        if (Input.GetButtonDown("LB"))
        {
            Debug.Log("LB");
            Y.GetComponent<Renderer>().material.color = Color.red;
            if (ynotes == true)
            {
                ynotes = false;
                Ynotes.SetActive(false);
                Destroy(Ynotes.gameObject.transform.root.gameObject);
            }
        }
        else if (Input.GetButtonUp("LB"))
        {
            Y.GetComponent<Renderer>().material.color = Color.blue;
        }

        if (Input.GetButtonDown("joystick button 2"))
        {
            Xflg = true;
            X.GetComponent<Renderer>().material.color = Color.red;
            if (xnotes == true)
            {
                
                //Xnotes.SetActive(false);
                Destroy(Xnotes.gameObject.transform.root.gameObject);
                xnotes = false;
            }
        }
        else if (Input.GetButtonUp("joystick button 2"))
        {
            X.GetComponent<Renderer>().material.color = Color.blue;
            Xflg = false;
        }

        if (Input.GetButtonDown("RB"))
        {
            Xflg = true;
            X.GetComponent<Renderer>().material.color = Color.red;
            if (xnotes == true)
            {
                
                //Xnotes.SetActive(false);
                Destroy(Xnotes.gameObject.transform.root.gameObject);
                xnotes = false;
            }
        }
        else if (Input.GetButtonUp("RB"))
        {
            X.GetComponent<Renderer>().material.color = Color.blue;
            Xflg = false;
        }

        if (Input.GetButtonDown("joystick button 1"))
        {
            Bflg = true;
      
            B.GetComponent<Renderer>().material.color = Color.red;
            if (bnotes == true)
            {
                
                //Bnotes.SetActive(false);
                Destroy(Bnotes.gameObject.transform.root.gameObject);
                bnotes = false;
            }
        }
        else if (Input.GetButtonUp("joystick button 1"))
        {
            B.GetComponent<Renderer>().material.color = Color.blue;
            Bflg = false;
        }

        if (Xyoko==-1)
        {
            Bflg = true;
            B.GetComponent<Renderer>().material.color = Color.red;
            if (bnotes == true)
            {
                
              
                //Bnotes.SetActive(false);
                Destroy(Bnotes.gameObject.transform.root.gameObject);
                bnotes = false;
            }
        }
        else if (Xyoko==0)
        {
            B.GetComponent<Renderer>().material.color = Color.blue;
            Bflg = false;
        }

        if (Input.GetButtonDown("joystick button 0"))
        {
            Aflg = true;
            A.GetComponent<Renderer>().material.color = Color.red;
            if (anotes == true)
            {
                
                //Anotes.SetActive(false);
                Destroy(Anotes.gameObject.transform.root.gameObject);
                anotes = false;

            }
        }
        else if (Input.GetButtonUp("joystick button 0"))
        {
            A.GetComponent<Renderer>().material.color = Color.blue;
            Aflg = false;
        }

        if (Xtate==-1)
        {
            Aflg = true;
            A.GetComponent<Renderer>().material.color = Color.red;
            if (anotes == true)
            {
                
                //Anotes.SetActive(false);
                Destroy(Anotes.gameObject.transform.root.gameObject);
                anotes = false;

            }
        }
        else if (Xtate==0)
        {
            A.GetComponent<Renderer>().material.color = Color.blue;
            Aflg = false;
        }
    }
}
