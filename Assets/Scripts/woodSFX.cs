using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodSFX : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if(other.transform.CompareTag("Ball"))
        AudioManager.instance.WoodSFX();  
    }
}
