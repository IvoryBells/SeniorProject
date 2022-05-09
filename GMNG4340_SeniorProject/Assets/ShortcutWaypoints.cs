using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortcutWaypoints : MonoBehaviour
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
        this.GetComponent<ShortcutWaypoints>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gravity == false)
        {
            player.GetComponent<Rigidbody>().useGravity = false;
        }

        if (Vector3.Distance(waypoints[wpCurrent].transform.position, player.transform.position) < wpRadius)
        {
            wpCurrent++;
            if (wpCurrent >= waypoints.Length)
            {
                //player.GetComponent<Rigidbody>().AddForce(new Vector3((float)-70.88275, (float)11.90937, (float)13.56127) * loopSpeed);
                this.GetComponent<ShortcutWaypoints>().enabled = false;
            }
        }
        player.transform.position = Vector3.MoveTowards(player.transform.position, waypoints[wpCurrent].transform.position, Time.deltaTime * loopSpeed);
    }
}

