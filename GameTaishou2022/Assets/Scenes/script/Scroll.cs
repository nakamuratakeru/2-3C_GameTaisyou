using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scroll: MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(-2.7f*Time.deltaTime, 0, 0);
        //if (transform.position.x < -62.8f
            if (transform.position.x < -40.8f)
            {
            transform.position = new Vector3(12.8f, 0, 0);
        }
    }
}