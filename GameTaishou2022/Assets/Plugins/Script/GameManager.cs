//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using UniRx;
//using UniRx.Triggers;

//[Serializable]
//public class Humen {
//    public string name;
//    public int maxBlock;
//    public int BPM;
//    public int offset;
//    public Notes[] notes;

//}
//[Serializable]
//public class Notes {
//    public int num;
//    public int block;
//}



//public class GameManager : MonoBehaviour {

//    [SerializeField] string FilePath;

//    [SerializeField] Button Play;
//    [SerializeField] Button SetChart;

//    [SerializeField] GameObject Don;
//    [SerializeField] GameObject Ka;

//    [SerializeField] Transform SpawnPoint;
//    [SerializeField] Transform BeatPoint;

//    int note;
//    float TimeCount = 0.01f;
//    public GameObject notepref;
//    public GameObject exnotepref;
//    void Start() {


//        string inputString = Resources.Load<TextAsset>("test").ToString();

//        Humen inputJson = JsonUtility.FromJson<Humen>(inputString);

//        //string Title;
//        //int BPM;
//        //List<GameObject> Notes;

//        void OnEnable() {
//        Play.onClick
//          .AsObservable()
//          .Subscribe(_ => play());

//        SetChart.onClick
//          .AsObservable()
//          .Subscribe(_ => loadChart());
//    }

//    void loadChart() {
//        //Notes = new List<GameObject>();

//        //string jsonText = Resources.Load<TextAsset>(FilePath).ToString();

//        //JsonNode json = JsonNode.Parse(jsonText);
//        //Title = json["title"].Get<string>();
//        //BPM = int.Parse(json["bpm"].Get<string>());

//        //foreach (var note in json["notes"]) {
//        //    string type = note["type"].Get<string>();
//        //    float timing = float.Parse(note["num"].Get<string>());

//            GameObject Note;
//            if (type == "(notepref") {
//                Note = Instantiate(notepref, SpawnPoint.position, Quaternion.identity);
//            }
//            else if (type == "exnotepre") {
//                Note = Instantiate(exnotepre, SpawnPoint.position, Quaternion.identity);
//            }
//            else {
//                Note = Instantiate(notepref, SpawnPoint.position, Quaternion.identity); // default don
//            }

//            Notes.Add(Note);
//        }
//    }

//    void play() {
//        Debug.Log("Game Start!");
//    }
//}