using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydamage : MonoBehaviour
{
    [SerializeField]
    private int damagePoint = 5;
    private bool isDamaged;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isDamaged && collision.tag== "Atarihan")
       
        {
            var playerScript = collision.gameObject.GetComponent<HPbar>();
            playerScript.SetHp(playerScript.GetHp() - damagePoint);
            isDamaged = true;
            Debug.Log(damagePoint + "ダメージを受けた");
            
            //gameObject.SetActive(false);
        }
    }
}