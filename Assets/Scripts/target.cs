using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public static int Lock = 1;
    int b = 0;
    int score = 0;
    int type = 0;
    int cursor = 151;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Card.sw == 3)
        {
            b = Card.answer;
            
            Card.sw = 4;
        }
        if (Card.sw == 4)
        {
            b = Card.answer;
            if (type == 0)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    type = 1;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    cursor = cursor - 1;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    cursor = cursor + 1;
                }
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (Lock == b)
                    {
                        score = score + 1;
                        //Debug.Log("score is " + score);
                        
                    }
                    else
                    {
                        Card.sw = 5;
                    }
                }
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (Lock == b)
                    {
                        //score = score + 1;
                        //Debug.Log("score is " + score);
                        
                    }
                    else
                    {
                        
                    }
                }
                if (cursor % 3 == 0)
                {
                    this.transform.localPosition = new Vector3(490, 330, 0);
                    if (Lock != 2)
                    {
                        Lock = 2;
                        //Debug.Log("Lock is " + Lock);
                    }
                }
                else if (cursor % 3 == 1)
                {

                    this.transform.localPosition = new Vector3(0, 330, 0);
                    if (Lock != 1)
                    {
                        Lock = 1;
                        //Debug.Log("Lock is " + Lock);
                    }
                }
                else if (cursor % 3 == 2)
                {

                    this.transform.localPosition = new Vector3(-490, 330, 0);
                    if (Lock != 3)
                    {
                        Lock = 3;
                        //Debug.Log("Lock is " + Lock);
                    }
                }
            }
            else if (type == 1)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    type = 0;
                }
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    this.transform.localPosition = new Vector3(490, 330, 0);
                    if (Lock != 2)
                    {
                        Lock = 2;
                        //Debug.Log("Lock is " + Lock);
                    }
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    this.transform.localPosition = new Vector3(0, 330, 0);
                    if (Lock != 1)
                    {
                        Lock = 1;
                        //Debug.Log("Lock is " + Lock);
                    }
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    this.transform.localPosition = new Vector3(0, 330, 0);
                    if (Lock != 1)
                    {
                        Lock = 1;
                        //Debug.Log("Lock is " + Lock);
                    }
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    this.transform.localPosition = new Vector3(-490, 330, 0);
                    if (Lock != 3)
                    {
                        Lock = 3;
                        //Debug.Log("Lock is " + Lock);
                    }
                }

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    if (Lock == b)
                    {
                        //score = score + 1;
                        //Debug.Log("score is " + score);
                        
                    }
                    else
                    {
                        
                    }
                }
            }
        }
    }
}
