using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awnswer : MonoBehaviour
{
    public AudioClip soundA;
    public AudioClip soundB;
    public AudioClip soundC;
    public AudioClip soundD;
    public AudioClip soundE;
    public AudioClip soundF;
    public AudioClip soundG;
    public AudioClip soundH;
    AudioSource audioSource;
    private int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Card.sw == 1)
        {
            audioSource = GetComponent<AudioSource>();
            Card card = GetComponent<Card>();
            a = card.voice;
            //Debug.Log("a is " + a);

            if (a == 0)
            {//âπ(soundA)Çñ¬ÇÁÇ∑
                audioSource.PlayOneShot(soundA);
            }
            else if (a == 1)
            {
                audioSource.PlayOneShot(soundB);
            }
            else if (a == 2)
            {
                audioSource.PlayOneShot(soundC);
            }
            else if (a == 3)
            {
                audioSource.PlayOneShot(soundD);
            }
            else if (a == 4)
            {
                audioSource.PlayOneShot(soundE);
            }
            else if (a == 5)
            {
                audioSource.PlayOneShot(soundF);
            }
            else if (a == 6)
            {
                audioSource.PlayOneShot(soundG);
            }
            else if (a == 7)
            {
                audioSource.PlayOneShot(soundH);
            }
            Card.sw = 3;


        }

        if (Card.sw == 4)
        {
            audioSource = GetComponent<AudioSource>();
            Card card = GetComponent<Card>();
            if (Input.GetKeyDown(KeyCode.V))
            {
                // ç∂
                if (a == 0)
                {//âπ(soundA)Çñ¬ÇÁÇ∑
                    audioSource.PlayOneShot(soundA);
                }
                else if (a == 1)
                {
                    audioSource.PlayOneShot(soundB);
                }
                else if (a == 2)
                {
                    audioSource.PlayOneShot(soundC);
                }
                else if (a == 3)
                {
                    audioSource.PlayOneShot(soundD);
                }
                else if (a == 4)
                {
                    audioSource.PlayOneShot(soundE);
                }
                else if (a == 5)
                {
                    audioSource.PlayOneShot(soundF);
                }
                else if (a == 6)
                {
                    audioSource.PlayOneShot(soundG);
                }
                else if (a == 7)
                {
                    audioSource.PlayOneShot(soundH);
                }
            }
        }
    }
}
