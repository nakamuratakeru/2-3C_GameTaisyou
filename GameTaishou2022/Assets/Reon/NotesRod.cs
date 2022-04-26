using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NotesRod : MonoBehaviour
{

    GameObject X;
    GameObject B;
    GameObject A;

 
    GameObject Xnotes;
    GameObject Bnotes;
    GameObject Anotes;

    public static bool xnotes;
    public static bool bnotes;
    public static bool anotes;
    bool niceflg = false;
    bool goodflg = false;
    bool greatflg = false;

    public static bool Aflg;
    public static bool Bflg;
    public static bool Xflg;

    float x_val;
    public float speed;

    Color Ycolor;

    public static int score;
    public static int combo;
    bool comboreset;

    // Start is called before the first frame update
    void Start()
    {

    xnotes = false;
    bnotes = false;
    anotes = false;


 
        bool Bflg =false;
        Aflg =false;
        Bflg = false;
        Xflg = false;

        comboreset = false;

        //Ycolor = Y.GetComponent<Renderer>().material.color;
    }

    private void Score()
    {
        if (niceflg == true)
        {
            score += 100;
        }

        if (goodflg == true)
        {
            score += 1000;
        }

        if (greatflg == true)
        {
            score += 10000;
        }


    }

    private void Combo()
    {
        combo += 1;
    }

    private void rotate()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f,0.5f));
    }

    private void OnTriggerStay2D(Collider2D other)
    {

       

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
            if (goodflg || greatflg == false)
            {
                niceflg = true;
            }
            //perfect(red)  good(green) nice(bule) miss(white)
        }

        if (other.gameObject.CompareTag("good"))
        {
            if (greatflg == false)
            {
                goodflg = true;
            }
            //perfect(red)  good(green) nice(bule) miss(white)
        }

        if (other.gameObject.CompareTag("great"))
        {
            greatflg = true;
            //perfect(red)  good(green) nice(bule) miss(white)
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Xnotes"))
        {
            Xnotes = null;
            xnotes = false;

        }

        if (other.gameObject.CompareTag("Bnotes"))
        {
            Bnotes = null;
            bnotes = false;

        }

        if (other.gameObject.CompareTag("Anotes"))
        {
            Anotes = null;
            anotes = false;

        }

        if (other.gameObject.CompareTag("nice"))
        {
          
                niceflg = false;
            
            //perfect(red)  good(green) nice(bule) miss(white)
        }

        if (other.gameObject.CompareTag("good"))
        {
           
                goodflg = false;
            
            //perfect(red)  good(green) nice(bule) miss(white)
        }

        if (other.gameObject.CompareTag("great"))
        {
            greatflg = false;
            //perfect(red)  good(green) nice(bule) miss(white)
        }



    }

    // Update is called once per frame
    void Update()
    {

        Debug.LogFormat("nice",niceflg);
        Debug.LogFormat("good", goodflg);
        Debug.LogFormat("great", greatflg);

        rotate();

        comboreset = ComboReset.comboreset;

        if (comboreset == true)
        {
            combo = 0;
        }

        float Xyoko = Input.GetAxisRaw("LT");
        float Xtate = Input.GetAxisRaw("RT");

        X = GameObject.Find("/NotesRod/X");
        B = GameObject.Find("/NotesRod/B");
        A = GameObject.Find("/NotesRod/A");

        if (Input.GetButtonDown("joystick button 2"))
        {
            Xflg = true;
            X.GetComponent<Renderer>().material.color = Color.red;
            if (xnotes == true)
            {
                Destroy(Xnotes.gameObject.transform.root.gameObject);
                xnotes = false;
                Score();
                Combo();
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
                Debug.Log("aaaaa");
                Destroy(Xnotes.gameObject.transform.root.gameObject);
                xnotes = false;
                Score();
                Combo();
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
                Score();
                Combo();
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
                Score();
                Combo();
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
                Score();
                Combo();

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
                Score();
                Combo();

            }
        }
        else if (Xtate==0)
        {
            A.GetComponent<Renderer>().material.color = Color.blue;
            Aflg = false;
        }
    }
}
