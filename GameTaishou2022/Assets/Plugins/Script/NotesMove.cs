﻿//using UnityEngine;
//using System;

//public class NoteMove : MonoBehaviour {
//    [SerializeField]
//    private float notesSpeed;

//    [SerializeField]
//    private Vector2 startPos;//ノーツの開始位置
//    [SerializeField]
//    private Vector2 judgePos;//判定したい場所

//    public static float moveSpan = 0.01f;//回すスパン 

//    private float notesTime;

//    void Start() {
//        notesTime = (startPos.x - judgePos.x) / notesSpeed;
//        InvokeRepeating("NotesMove", 0, moveSpan);
//    }

//    void NotesMove() {
//        transform.position += new Vector3(-notesSpeed, 0f, 0f);
//        notesTime -= moveSpan;
//        NotesJudge();
//    }

//    void NotesJudge() {
//        if (Math.Abs(notesTime) < 0.5f) {
//            //判定した時の処理を書く 
//        }
//    }

//}