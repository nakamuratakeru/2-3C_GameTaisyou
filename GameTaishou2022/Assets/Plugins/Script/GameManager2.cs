﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;

public class GameManager2 : MonoBehaviour
{
    [SerializeField] GameObject GameclearCanvas;　//ゲームクリア時に表示されるクリアパネルを入れる
    private float step_time; //ゲームプレイ中の経過時間をカウントする
    public static bool clearflg = false;
    [SerializeField] string FilePath;

    [SerializeField] Button Play;
    [SerializeField] Button SetChart;

    [SerializeField] GameObject Ynotes;
    [SerializeField] GameObject Xnotes;
    [SerializeField] GameObject Bnotes;
    [SerializeField] GameObject Anotes;

    [SerializeField] Transform YSpawnPoint;
    [SerializeField] Transform XSpawnPoint;
    [SerializeField] Transform BSpawnPoint;
    [SerializeField] Transform ASpawnPoint;
    [SerializeField] Transform BeatPoint;

    //　ノーツを動かすために必要になる変数を追加
  
   
    float PlayTime;
    float Distance;
    float During;
    bool isPlaying;
    int GoIndex;
    public AudioClip explosionSE;
    int mstop = 0; //mstopの数値が１以上になるとplayボタンを押しても音楽が流れなくなる。
    int gc = 0;
    string Title;
    int BPM;
    List<GameObject> Notes;

    void Start()
    {
        step_time = 0.0f;       // 経過時間初期化
        GameclearCanvas.SetActive(false);

    }

    void OnEnable()
    {
        // 追加した変数に値をセット
        Distance = Math.Abs(BeatPoint.position.x - YSpawnPoint.position.x);
        During = 4 * 1000;
        isPlaying = false;
        GoIndex = 0;

        Debug.Log(Distance);

        Play.onClick
          .AsObservable()
          .Subscribe(_ => play());


        SetChart.onClick
          .AsObservable()
          .Subscribe(_ => loadChart());

        // ノーツを発射するタイミングかチェックし、go関数を発火
        this.UpdateAsObservable()
          .Where(_ => isPlaying)
          .Where(_ => Notes.Count > GoIndex)
          .Where(_ => Notes[GoIndex].GetComponent<NoteController>().getTiming() <= ((Time.time * 1000 - PlayTime) + During))
          .Subscribe(_ => {
              Notes[GoIndex].GetComponent<NoteController>().go(Distance, During);
              GoIndex++;
          });
    }

    void loadChart()
    {
        Notes = new List<GameObject>();

        string jsonText = Resources.Load<TextAsset>(FilePath).ToString();

        JsonNode json = JsonNode.Parse(jsonText);
        Title = json["title"].Get<string>();
        BPM = int.Parse(json["bpm"].Get<string>());

        foreach (var note in json["notes"])
        {
            string type = note["type"].Get<string>();
            float timing = float.Parse(note["timing"].Get<string>());

            GameObject Note;
            //if (type == "Y")
            //{
            //    Note = Instantiate(Ynotes, YSpawnPoint.position, Quaternion.identity);
            //}
            if (type == "X")
            {
                Note = Instantiate(Xnotes, XSpawnPoint.position, Quaternion.identity);
            }
            else if (type == "B")
            {
                Note = Instantiate(Bnotes, BSpawnPoint.position, Quaternion.identity); // default don
            }
            else
            {
                Note = Instantiate(Anotes, ASpawnPoint.position, Quaternion.identity); // default don
            }

            // setParameter関数を発火
            Note.GetComponent<NoteController>().setParameter(type, timing);

            Notes.Add(Note);
        }
    }

    // ゲーム開始時に追加した変数に値をセット
    void play()
    {
     
        PlayTime = Time.time * 1000;
       
        isPlaying = true;
        if (isPlaying = true && mstop < 1)
        {
            
                //AudioSource.PlayClipAtPoint(explosionSE, transform.position);
                AudioSource.PlayClipAtPoint(explosionSE, new Vector3(-22, 0, -5)); //new Vector3の数値はmain cameraのpositionの数値を参照
                mstop += 1;
                Debug.Log("Game Start!");
            
        }
       

        //Debug.Log("Game Start!");
    }

    public void Update()
    {
        if (mstop == 1)
        {
            step_time += Time.deltaTime;
            //Debug.Log("計測中");
            if (step_time >= 30.0f&&gc<1)　//プレイ開始から30秒経過するとゲームクリアパネルが表示される。
            {
                Debug.Log("ゲームクリア！");
                clearflg = true;
                GameclearCanvas.SetActive(true);
                gc += 1;
            }
        }
    }

}

