using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
   
    [SerializeField] private float speed;

    void Update()
    {
        transform.position -= new Vector3(Time.deltaTime * speed, 0);
        if (transform.position.x <= -5.5f)
        {
            transform.position = new Vector3(5.5f, 0);
        }
    }
}
