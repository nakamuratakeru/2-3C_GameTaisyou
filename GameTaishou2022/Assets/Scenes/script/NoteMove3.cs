using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteMove3 : MonoBehaviour {
    [SerializeField]
    private float notesSpeed;

    //public Vector2 Vector2;

    [SerializeField]
    private Vector2 startPos3;//ノーツの開始位置
    [SerializeField]
    private Vector2 judgePos3;//判定したい場所

    public static float moveSpan = 0.01f;//回すスパン 

    private float notesTime3;




    void Start() {
        notesTime3 = (startPos3.x - judgePos3.x) / notesSpeed;
        InvokeRepeating("NotesMove", 0, moveSpan);
    }

    void NotesMove() {
        transform.position += new Vector3(-notesSpeed, 0f, 0f);
        notesTime3 -= moveSpan;
        NotesJudge();
    }

    void NotesJudge() {

        if (Math.Abs(notesTime3) < 0.5f) {
            //判定した時の処理を書く 
            Debug.Log("hit3");
        }
        //else if (this.gameObject.tag == "AudioPlay") {
        //    if (notesTime < 0) {    //判定位置に来たら
        //        NotesGenerator.isAudioPlay = true;
        //        Debug.Log("sfjkajjgpagj");
        //    }
        //}

    }

}

