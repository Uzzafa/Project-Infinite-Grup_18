using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speeder : MonoBehaviour
{
    [SerializeField] float force;

    bool isSpeeding;
    void OnCollisionEnter(Collision other)
    {
        Speed (other.collider);
    }
    void OnTriggerEnter(Collider other)
    {
        Speed (other);
    }

    private void Speed (Collider other) {
        if(isSpeeding == false 
        && other.transform.CompareTag("Ball") 
        && other.transform.TryGetComponent<BallController>(out var ball))
        {
            ball.AddForce(force * this.transform.position, ForceMode.Impulse);
            isSpeeding = true;
            Invoke("ResetSpeed", 0.3f);
        }
    }
    private void ResetSpeed () {
        isSpeeding = false;
    }
}
