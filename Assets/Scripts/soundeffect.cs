using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class soundeffect : MonoBehaviour
{
    public AudioClip soundEffect;
    AudioSource audioSource;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            soundeffect();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            soundeffect();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            soundeffect();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            soundeffect();
        }
        void soundeffect()
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(soundEffect);
        }
    }
}