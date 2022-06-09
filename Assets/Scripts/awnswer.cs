using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public AudioClip soundI;
    public AudioClip soundJ;
    AudioSource audioSource;
    private int a = 0;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Card.sw == 2)
        {
            Debug.Log("swich is" + Card.sw);
            audioSource = GetComponent<AudioSource>();
            Card card = GetComponent<Card>();
            a = card.voice;

            Debug.Log("a is " + a);

            if (a == 0)
            {//‰¹(soundA)‚ð–Â‚ç‚·
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
            else if (a == 8)
            {
                audioSource.PlayOneShot(soundI);


            }
            else if (a == 9)
            {
                audioSource.PlayOneShot(soundJ);


            }
            Card.sw = 3;
            StartCoroutine("Wait");



        }

        
        
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(11);
        SceneManager.LoadScene(0);
    }
    
}
