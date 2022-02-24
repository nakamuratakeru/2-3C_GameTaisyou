using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = -1;

    Vector3 cameraRectmin;

    private void Start()
    {
        cameraRectmin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));

    }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);

        if (transform.position.x < (cameraRectmin.x - Camera.main.transform.position.x) * 2)
        {
            transform.position = new Vector2((Camera.main.transform.position.x - cameraRectmin.x) * 2, transform.position.y);
        }
    }

   
}
