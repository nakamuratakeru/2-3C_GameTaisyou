using UnityEngine;

public class Destroy : MonoBehaviour
{
    //InspectorにGameObjectをここに設定して消せるようにするよ！
    public GameObject newgameObject;//newgameObjectの部分は自分が好きな名前をつけてね！
    public GameObject t;
    public AudioClip explosionSE;


    void Start()
    {
        //Start関数も今回使わないので何も書かないよ！ 
    }

    // Update is called once per frame
    void Update()
    {
        //もしマウスをGameObjectに設定した物をクリックしたら消すよ！
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(newgameObject);
            AudioSource.PlayClipAtPoint(explosionSE, transform.position);
            Instantiate(t, this.transform.position, Quaternion.identity);
        }
    }
}