using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //夜に駆けるは8
    int NotesSpeed = 8;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * Time.deltaTime * NotesSpeed;   
    }
}
