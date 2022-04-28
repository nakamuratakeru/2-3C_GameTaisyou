using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteMove2 : MonoBehaviour {
    [SerializeField]
    private float notesSpeed;

    //public Vector2 Vector2;

    [SerializeField]
    private Vector2 startPos2;//ノーツの開始位置
    [SerializeField]
    private Vector2 judgePos2;//判定したい場所

    public static float moveSpan2 = 0.01f;//回すスパン 

    private float notesTime2;



    void Start() {
        notesTime2 = (startPos2.x - judgePos2.x) / notesSpeed;
        InvokeRepeating("NotesMove", 0, moveSpan2);
    }

    void NotesMove() {
        transform.position += new Vector3(-notesSpeed, 0f, 0f);
        notesTime2 -= moveSpan2;
        NotesJudge();
    }

    void NotesJudge() {

        if (Math.Abs(notesTime2) < 0.5f) {
            //判定した時の処理を書く 
            Debug.Log("hit2");
        }
        //else if (this.gameObject.tag == "AudioPlay") {
        //    if (notesTime < 0) {    //判定位置に来たら
        //        NotesGenerator.isAudioPlay = true;
        //        Debug.Log("sfjkajjgpagj");
        //    }
        //}

    }

}

