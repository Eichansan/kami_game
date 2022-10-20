using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Judge : MonoBehaviour
{
    //変数の宣言
    int cnt = 0;
    /*int miss = 0;
    [SerializeField] private GameObject[] GameOverObj;*/
    [SerializeField] private GameObject[] MessageObj;//プレイヤーに判定を伝えるゲームオブジェクト
    [SerializeField] NotesManager notesManager;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (notesManager.LaneNum[0] == 0)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0] + notesManager.HFinish - notesManager.interval));
                /*
                本来ノーツをたたく場所と実際にたたいた場所がどれくらいずれているかを求め、
                その絶対値をJudgement関数に送る
                */
            }
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (notesManager.LaneNum[0] == 1)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0] + notesManager.HFinish - notesManager.interval));
            }
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (notesManager.LaneNum[0] == 2)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0] + notesManager.HFinish - notesManager.interval));
            }
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (notesManager.LaneNum[0] == 3)
            {
                Judgement(GetABS(Time.time - notesManager.NotesTime[0] + notesManager.HFinish - notesManager.interval));
            }
        }
        if (Time.time - notesManager.interval > notesManager.NotesTime[0] + 0.2f + notesManager.HFinish)//本来ノーツをたたくべき時間から0.2秒たっても入力がなかった場合
        {
            message(3);
            deleteData();
            Debug.Log("Miss");
            /*misscount();
                if(miss == 5)
                {
                    Instantiate(GameOverObj,new Vector3(notesManager.LaneNum[0]+1.25f,0.76f,0.15f),Quaternion.Euler(45,0,0));
                }*/
        }
    }
    void Judgement(float timeLag)
    {
        if (Card.answer == target.Lock)
        {
            if (timeLag - notesManager.Lag <= 0.10)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.1秒以下だったら
            {
                Debug.Log("Perfect");
                Debug.Log("score:" + count(100));
                message(0);
                deleteData();
            }
            else
            {
                if (timeLag - notesManager.Lag <= 0.15)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.15秒以下だったら
                {
                    Debug.Log("Great");
                    Debug.Log("score:" + count(50));
                    message(1);
                    deleteData();
                }
                else
                {
                    if (timeLag - notesManager.Lag <= 0.20)//本来ノーツをたたくべき時間と実際にノーツをたたいた時間の誤差が0.2秒以下だったら
                    {
                        Debug.Log("Good");
                        Debug.Log("score:" + count(20));
                        message(2);
                        deleteData();
                    }
                }
            }
        }
        else
        {
            message(4);
            deleteData();
            Debug.Log("Uncorrect");
        }
    }
    float GetABS(float num)//引数の絶対値を返す関数
    {
        if (num >= 0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }
    void deleteData()//すでにたたいたノーツを削除する関数
    {
        notesManager.LaneNum.RemoveAt(0);
        notesManager.NoteType.RemoveAt(0);
        notesManager.NotesTime.RemoveAt(0);
    }
    void message(int judge)//判定を表示する
    {
        Instantiate(MessageObj[judge], new Vector3(notesManager.LaneNum[0] + 1.25f, 0.76f, 0.15f), Quaternion.Euler(45, 0, 0));
    }
    int count(int plus)
    {
        cnt = cnt + plus;
        return cnt;
    }
    /*int misscount()
    {
        miss = miss + 1;
        return miss;
    }*/
}