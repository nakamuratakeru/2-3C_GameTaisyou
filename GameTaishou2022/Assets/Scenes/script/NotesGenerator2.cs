using UnityEngine;
using System;

public class NotesGenerator2 : MonoBehaviour {

    [Serializable]
    public class InputJson {
        public Notes[] notes;
        //public Notes[] notes2;
        //public Notes[] notes3;
        public int BPM;


    }

    [Serializable]
    public class Notes {
        public int num;
        public int block;
        public int LPB;

    }

    [SerializeField]
    private GameObject notesPre;
    [SerializeField]
    private GameObject notesPre2;
    [SerializeField]
    private GameObject notesPre3;
    [SerializeField]
    private GameObject audioPre;
    //[SerializeField]
    //Transform notes;
    //[SerializeField] 
    //Transform note2;
    //[SerializeField]
    //Transform note3;
    [SerializeField]
    private AudioSource gameAudio;
    //AudioSource audio = GetComponent<AudioSource>();

    public static bool isAudioPlay = false;



    private float moveSpan = 0.01f;
    private float nowTime;// 音楽の再生されている時間
    private int beatNum;// 今の拍数
    private int beatCount;// json配列用(拍数)のカウント
    private bool isBeat;// ビートを打っているか(生成のタイミング)


    private int[] scoreNum;//ノーツの番号を順に入れる
    private int[] scoreBlock;//ノーツの種類を順に入れる
    private int BPM;
    private int LPB;

    //private int a = new Vector2(1.234f, 5.678f);

    //void Start() {
    //    gameAudio = GetComponent<AudioSource>();
    //}





    ////音再生開始
    //void AudioPlay() {
    //    gameAudio.enabled = isAudioPlay;
    //       //a.Play();
    //    }

    void Awake() {
        MusicReading();
        InvokeRepeating("NotesIns", 0f, moveSpan);
    }


    /// 譜面の読み込み
    /// </summary>
    /// <summary>
    /// 譜面上の時間とゲームの時間のカウントと制御
    /// </summary>
    void GetScoreTime() {
        //今の音楽の時間の取得
        nowTime += moveSpan; //(1)

        //ノーツが無くなったら処理終了
        if (beatCount > scoreNum.Length) return;

        //楽譜上でどこかの取得
        beatNum = (int)(nowTime * BPM / 60 * LPB); //(2)
    }


    /// <summary>
    /// ノーツを生成する
    /// </summary>
    /// <summary>

    void NotesIns() {
        GetScoreTime();

        //json上でのカウントと楽譜上でのカウントの一致
        if (beatCount < scoreNum.Length) {
            isBeat = (scoreNum[beatCount] == beatNum); //(3)
        }


        //生成のタイミングなら
        if (isBeat) {
            //ノーツ0の生成
            if (scoreBlock[beatCount] == 0) {
                Instantiate(audioPre, new Vector2(7.68f, -3.46f), Quaternion.identity);
            }



            //ノーツ1の生成
            if (scoreBlock[beatCount] == 1) {
                Instantiate(notesPre, new Vector2(7.68f, -3.46f), Quaternion.identity);
            }
            else if (scoreBlock[beatCount] == 2) {
                Instantiate(notesPre2, new Vector2(7.68f, -2.35f), Quaternion.identity);
            }
            else if (scoreBlock[beatCount] == 3) {
                Instantiate(notesPre3, new Vector2(7.68f, -0.77f), Quaternion.identity);
            }

            beatCount++; //(5)
            isBeat = false;

        }
    }

    void MusicReading() {

        string inputString = Resources.Load<TextAsset>("Rapid_cyber").ToString();
        InputJson inputJson = JsonUtility.FromJson<InputJson>(inputString);

        scoreNum = new int[inputJson.notes.Length];
        scoreBlock = new int[inputJson.notes.Length];
        BPM = inputJson.BPM;
        LPB = inputJson.notes[0].LPB;

        for (int i = 0; i < inputJson.notes.Length; i++) {
            //ノーツがある場所を入れる
            scoreNum[i] = inputJson.notes[i].num;
            //ノーツの種類を入れる(scoreBlock[i]はscoreNum[i]の種類)
            scoreBlock[i] = inputJson.notes[i].block;
        }

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("AudioPlay")) {
            isAudioPlay = true;
            Debug.Log("H");
            if (isAudioPlay == true) {
                gameAudio.Play();
            }
        }
    }
}
