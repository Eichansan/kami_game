using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{  
    List<int> numbers = new  List<int>();
    public TextMeshProUGUI firstText;
    public TextMeshProUGUI secondText;
    public TextMeshProUGUI thirdText;
    private int count = 3;
    private int start = 0;
    private int end = 7;
    private int I = 0;
    private int select;
    public static int answer;
    public static int sw;
    public int voice;
    private int[] save = new int[4];
    private string[] card = new string[3];
    private string letter;


    // Start is called before the first frame update


    void Start() {
        sw = 0;
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }
        for (int count = 0; count <= 2; count++)
        {
            int@index = Random.Range(0, numbers.Count);
            int ransu = numbers[index];
            //Debug.Log(ransu);
            save[count] = ransu;
            numbers.RemoveAt(index);
        }
        numbers.RemoveAll(numbers.Contains);

        for (int I = 0; I <= 2; I++)
        {
            if (save[I] == 0)
            {
                card[I] = "a";
            }
            else if (save[I] == 1)
            {
                card[I] = "b";
            }
            else if (save[I] == 2)
            {
                card[I] = "c";
            }
            else if (save[I] == 3)
            {
                card[I] = "d";
            }
            else if (save[I] == 4)
            {
                card[I] = "e";
            }
            else if (save[I] == 5)
            {
                card[I] = "f";
            }
            else if (save[I] == 6)
            {
                card[I] = "g";
            }
            else {
                card[I] = "h";
            }     
        }

        firstText.text = card[0];
        secondText.text = card[1];
        thirdText.text = card[2];
        int select = Random.Range(1, 3);
        //Debug.Log("select is "+ select);
        if (select == 1)
        {
            answer = 1;
            voice = save[0];
            letter = card[0];

        }else if(select == 2)
        {
            answer = 2;
            voice = save[1];
            letter = card[1];
        } else if(select == 3)
        {
            answer =3;
            voice = save[2];
            letter = card[2];
        }
        //Debug.Log("awnswer is "+answer);
        //Debug.Log("voice is " + voice);
        Debug.Log("letter is " + letter);
        sw = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(sw == 5)
        {
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
            for (int count = 0; count <= 2; count++)
            {
                int index = Random.Range(0, numbers.Count);
                int ransu = numbers[index];
                //Debug.Log(ransu);
                save[count] = ransu;
                numbers.RemoveAt(index);
            }
            numbers.RemoveAll(numbers.Contains);

            for (int I = 0; I <= 2; I++)
            {
                if (save[I] == 0)
                {
                    card[I] = "a";
                }
                else if (save[I] == 1)
                {
                    card[I] = "b";
                }
                else if (save[I] == 2)
                {
                    card[I] = "c";
                }
                else if (save[I] == 3)
                {
                    card[I] = "d";
                }
                else if (save[I] == 4)
                {
                    card[I] = "e";
                }
                else if (save[I] == 5)
                {
                    card[I] = "f";
                }
                else if (save[I] == 6)
                {
                    card[I] = "g";
                }
                else
                {
                    card[I] = "h";
                }
            }

            firstText.text = card[0];
            secondText.text = card[1];
            thirdText.text = card[2];
            int select = Random.Range(1, 3);
            //Debug.Log("select is " + select);
            if (select == 1)
            {
                answer = 1;
                voice = save[0];
                letter = card[0];

            }
            else if (select == 2)
            {
                answer = 2;
                voice = save[1];
                letter = card[1];
            }
            else if (select == 3)
            {
                answer = 3;
                voice = save[2];
                letter = card[2];
            }
            //Debug.Log("awnswer is " + answer);
            //Debug.Log("voice is " + voice);
            Debug.Log("letter is " + letter);
            sw = 1;
        }
    }
}
