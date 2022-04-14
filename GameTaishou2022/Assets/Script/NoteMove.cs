using UnityEngine;
using System;

public class NoteMove : MonoBehaviour {
    [SerializeField]
    private float notesSpeed;

    [SerializeField]
    private Vector2 startPos;//ノーツの開始位置
    [SerializeField]
    private Vector2 judgePos;//判定したい場所
    //[SerializeField]
    //private Vector2 startPos2;//ノーツの開始位置
    //[SerializeField]
    //private Vector2 judgePos2;//判定したい場所
    //[SerializeField]
    //private Vector2 startPos3;//ノーツの開始位置
    //[SerializeField]
    //private Vector2 judgePos3;//判定したい場所

    public static float moveSpan = 0.01f;//回すスパン 

    private float notesTime;
    //private float notesTime2;
    //private float notesTime3;
   
    void Start() {
        notesTime = (startPos.x - judgePos.x) / notesSpeed;
        //notesTime2 = (startPos2.x - judgePos2.x) / notesSpeed;
        //notesTime3 = (startPos3.x - judgePos3.x) / notesSpeed;
        InvokeRepeating("NotesMove", 0, moveSpan);
    }

    void NotesMove() {
        transform.position += new Vector3(-notesSpeed, 0f, 0f);
        notesTime -= moveSpan;
        NotesJudge();
    }

    void NotesJudge() {
        if (this.gameObject.tag == "AudioPlay") {

            if (Math.Abs(notesTime) < 0.5f) {
                //判定した時の処理を書く 
            }
            if (notesTime <= 0)//判定位置に来たら
            {
                NotesGenerator.isAudioPlay = true;
            }

        }

    }
}
