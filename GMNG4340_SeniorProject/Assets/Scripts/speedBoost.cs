using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedBoost : MonoBehaviour
{
    public Vector3 directionFlight;
    public int speed;
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(directionFlight * speed);
    }
}
