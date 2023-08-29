using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    
    public float rotationSpeed = 10f; // Speed of rotation

    void Update()
    {
        // Rotate the object around its Z-axis
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

}
