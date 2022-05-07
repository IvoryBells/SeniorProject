using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    public int loopSpeed;
    public float wpRadius;
    public int wpCurrent = 0;
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().useGravity = false;

        if (Vector3.Distance(waypoints[wpCurrent].transform.position, transform.position) < wpRadius)
        {
            wpCurrent++;
            if (wpCurrent >= waypoints.Length)
            {
                this.GetComponent<Rigidbody>().AddForce(this.transform.forward * loopSpeed);
                this.GetComponent<Waypoints>().enabled = false;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[wpCurrent].transform.position, Time.deltaTime * loopSpeed);
    }
}
