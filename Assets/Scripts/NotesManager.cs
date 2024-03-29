using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
[Serializable]
public class Data
{
    public string name;
    public int maxBlock;
    public int BPM;
    public int offset;
    public Note[] notes;
}
[Serializable]
public class Note
{
    public int type;
    public int num;
    public int block;
    public int LPB;
}
public class NotesManager : MonoBehaviour
{
    int cnt = 0;
    public int noteNum;
    private string songName;
    private int a;
    public float interval;
    public float HFinish = 0;
    public float Lag = 0;
    public List<int> LaneNum = new List<int>();
    public List<int> NoteType = new List<int>();
    public List<float> NotesTime = new List<float>();
    public List<GameObject> NotesObj = new List<GameObject>();
    int i = 0;
    [SerializeField] private float NotesSpeed;
    [SerializeField] GameObject noteObj;
    void OnEnable()
    {
        noteNum = 0;
        Load(songName);
    }
    private void Load(string SongName)
    {
        string inputString = Resources.Load<TextAsset>(SongName).ToString();
        Data inputJson = JsonUtility.FromJson<Data>(inputString);
        noteNum = inputJson.notes.Length;
        for (int i = 0; i < inputJson.notes.Length; i++)
        {
            float kankaku = 60 / (inputJson.BPM * (float)inputJson.notes[i].LPB);
            float beatSec = kankaku * (float)inputJson.notes[i].LPB;
            float time = (beatSec * inputJson.notes[i].num / (float)inputJson.notes[i].LPB) + inputJson.offset + 0.01f;
            NotesTime.Add(time);
            LaneNum.Add(inputJson.notes[i].block);
            NoteType.Add(inputJson.notes[i].type);
            float z = NotesTime[i] * NotesSpeed;
            NotesObj.Add(Instantiate(noteObj, new Vector3(inputJson.notes[i].block - 1.5f, 0.55f, z), Quaternion.identity));
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            interval = Time.time;
            //Debug.Log("Update a:" + a);
            Notes();
        }
    }
    void Notes()
    {
        Debug.Log("1cnt is" + cnt);
        if (Card.sw == 1)
        {
            Debug.Log("2cnt is" + cnt);
            Debug.Log("swich is" + Card.sw);
            Card card = GetComponent<Card>();
            a = Random.Range(0, 9);
            Debug.Log("a is " + a);
            if (a == 0)
            {
                songName = "H1";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 1)
            {
                songName = "H2";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 2)
            {
                songName = "H3";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 3)
            {
                songName = "H4";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 4)
            {
                songName = "H5";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 5)
            {
                songName = "H6";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 6)
            {
                songName = "H7";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 7)
            {
                songName = "H8";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 8)
            {
                songName = "H9";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            else if (a == 9)
            {
                songName = "H10";
                OnEnable();
                //HFinish = 11f * cnt;
                Lag = 22f * cnt;
            }
            //cnt = cnt + 1;
            Card.sw = 2;
            Debug.Log("3cnt is" + cnt);
        }
    }
}