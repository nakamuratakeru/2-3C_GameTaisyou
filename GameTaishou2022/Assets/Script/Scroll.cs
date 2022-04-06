using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scroll: MonoBehaviour
{
    void Update()
    {
        transform.Translate(-0.05f, 0, 0);
        if (transform.position.x < -63.8f)
        {
            transform.position = new Vector3(63.8f, 0, 0);
        }
    }
}