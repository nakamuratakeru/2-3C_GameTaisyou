using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboReset : MonoBehaviour
{
    public static bool comboreset;

    // Start is called before the first frame update
    void Start()
    {
        comboreset = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        comboreset=true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
