using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject player;
    public GameObject[] waypoints;
    public int loopSpeed;
    public float wpRadius;
    public int wpCurrent = 0;
    public bool gravity = true;

    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        this.GetComponent<Waypoints>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gravity == false)
        {
            player.GetComponent<Rigidbody>().useGravity = false;
        }

        //playerCamera.transform.position = Quaternion.Lerp(playerCamera.transform.rotation, sceneQuat, lerpTime);
        if (Vector3.Distance(waypoints[wpCurrent].transform.position, player.transform.position) < wpRadius)
        {
            wpCurrent++;
            if (wpCurrent >= waypoints.Length)
            {
                player.GetComponent<Rigidbody>().AddForce(player.transform.forward * loopSpeed);
                this.GetComponent<Waypoints>().enabled = false;
            }
        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, waypoints[wpCurrent].transform.position, Time.deltaTime * loopSpeed);
    }

    
}
