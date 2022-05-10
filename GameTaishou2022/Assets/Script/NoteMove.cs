using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteMove : MonoBehaviour {
    [SerializeField]
    private float notesSpeed;

    //public Vector2 Vector2;

    [SerializeField]
    private Vector2 startPos;//ノーツの開始位置
    [SerializeField]
    private Vector2 judgePos;//判定したい場所

    public static float moveSpan = 0.01f;//回すスパン 

    private float notesTime;




    void Start() {
        notesTime = (startPos.x - judgePos.x) / notesSpeed;
        InvokeRepeating("NotesMove", 0, moveSpan);
    }

    void NotesMove() {
        transform.position += new Vector3(-notesSpeed, 0f, 0f);
        notesTime -= moveSpan;
        //NotesJudge();
    }


    void NotesJudge() {

        if (Math.Abs(notesTime) < 0.5f) {
            //判定した時の処理を書く 

            Debug.Log("hit");
        }
        else if (this.gameObject.tag == "AudioPlay") {
            if (notesTime < 0) {    //判定位置に来たら
                NotesGenerator.isAudioPlay = true;
                Debug.Log("sfjkajjgpagj");
            }
        }

    }

}

