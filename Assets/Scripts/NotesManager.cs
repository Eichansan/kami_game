using System;
using System.Collections.Generic;
using UnityEngine;

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
    public int noteNum;
    private string songName;
    private int a = 0;

    public List<int> LaneNum = new List<int>();
    public List<int> NoteType = new List<int>();
    public List<float> NotesTime = new List<float>();
    public List<GameObject> NotesObj = new List<GameObject>();

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
        if (Card.sw == 1)
        {
            
            Card card = GetComponent<Card>();
            a = card.voice;
            //Debug.Log("a is " + a);

            if (a == 0)
            {//音(soundA)を鳴らす
                songName = "0";
                OnEnable();
            }
            else if (a == 1)
            {
                songName = "1";
                OnEnable();
            }
            else if (a == 2)
            {
                songName = "2";
                OnEnable();
            }
            else if (a == 3)
            {
                songName = "3";
                OnEnable();
            }
            else if (a == 4)
            {
                songName = "4";
                OnEnable();
            }
            else if (a == 5)
            {
                songName = "5";
                OnEnable();
            }
            else if (a == 6)
            {
                songName = "6";
                OnEnable();
            }
            else if (a == 7)
            {
                songName = "7";
                OnEnable();
            }
            

        }

        if (Card.sw == 4)
        {
            Card card = GetComponent<Card>();
            a = card.voice;
            //Debug.Log("a is " + a);

            if (a == 0)
            {//音(soundA)を鳴らす
                songName = "0";
                OnEnable();
            }
            else if (a == 1)
            {
                songName = "1";
                OnEnable();
            }
            else if (a == 2)
            {
                songName = "2";
                OnEnable();
            }
            else if (a == 3)
            {
                songName = "3";
                OnEnable();
            }
            else if (a == 4)
            {
                songName = "4";
                OnEnable();
            }
            else if (a == 5)
            {
                songName = "5";
                OnEnable();
            }
            else if (a == 6)
            {
                songName = "6";
                OnEnable();
            }
            else if (a == 7)
            {
                songName = "7";
                OnEnable();
            }
        }
    }
}