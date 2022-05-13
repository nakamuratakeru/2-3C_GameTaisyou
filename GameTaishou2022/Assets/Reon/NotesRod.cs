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
    public static bool niceflg = false;
    bool niceflg2 = false;
    public static bool goodflg = false;
    public static bool greatflg = false;

    public static bool Aflg;
    public static bool Bflg;
    public static bool Xflg;

    float Xtatebefor;
    float Xyokobefor;

    float x_val;
    public float speed;

    Color Ycolor;

    public static int score;
    public static int combo;
    public static int maxcombo;
    bool comboreset;

    bool ariasuflg = false;

    public static bool nicetxflg;
    public static bool goodtxflg;
    public static bool greattxflg;

    bool greattrueflg = false;

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
        if (niceflg || niceflg2 == true && goodflg  == false)
        {
            if (greattrueflg == false&&goodflg==false)
            {
                nicetxflg = true;
                score += 100;
                Debug.Log("NICE");
            }
        }
        else
        {
            nicetxflg = false;
        }

        if (goodflg == true&&greattrueflg==false)
        {
            goodtxflg = true;
            score += 200;
            Debug.Log("good");
        }

        else
        {
            goodtxflg = false;
        }

  

        if (greatflg&&niceflg && niceflg2 == true&& goodflg==false)
        {
            greattrueflg = true;
            if (greattrueflg == true)
            {
                greattxflg = true;
                score += 300;
                Debug.Log("great");
            }
        }

        else
        {
            greattrueflg = false;
            greattxflg = false;
        }


    }

    private void Combo()
    {
        combo += 1;

        if (combo >= maxcombo)
        {
            maxcombo = combo;
        }

        if (GClearcanvas.clearflg == true)
        {
            score = 0;
            combo = 0;
        }
    }

    private void rotate()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f,0.5f));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("AudioPlay"))
        {
            ariasuflg = true;
        }
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
            niceflg = true;
           
        }

        if (other.gameObject.CompareTag("nice2"))
        {
            
                niceflg2 = true;
            
        }

        if (other.gameObject.CompareTag("good"))
        {
            goodflg = true;
        }

        if (other.gameObject.CompareTag("great"))
        {
            greatflg = true;
            goodflg = false;
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
            nicetxflg = false;
            

        }

        if (other.gameObject.CompareTag("nice2"))
        {

            niceflg2 = false;
            nicetxflg = false;

 
        }

        if (other.gameObject.CompareTag("good"))
        {
           
             goodflg = false;
            goodtxflg = false;
   
        }

        if (other.gameObject.CompareTag("great"))
        {
            greatflg = false;
            greattxflg = false;

        }



    }

    // Update is called once per frame
    void Update()
    {
        if (niceflg == true)
        {
            Debug.Log("nice");
        }
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

        if (Xyoko<0&&Xyokobefor==0.0f)
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

        if (Xtate==-1&&Xtatebefor==0)
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

        Xtatebefor = Xtate;
        Xyokobefor = Xyoko;
    }
}
