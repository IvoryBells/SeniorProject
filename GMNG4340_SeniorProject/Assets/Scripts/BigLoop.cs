using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigLoop : MonoBehaviour
{
    public GameObject[] skinRenders;
    public GameObject particles;
    public GameObject waypoint;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        waypoint = GameObject.FindGameObjectWithTag("Big Waypoint");

        skinRenders = GameObject.FindGameObjectsWithTag("Skin Render");
        /*for (int i = 0; i < gameObjects.Length; i++)
        {
            skinRenders[i] = gameObjects[i];
        }*/

        player = GameObject.FindGameObjectWithTag("Player");

        particles.SetActive(false);
        waypoint.GetComponent<Waypoints>().enabled = true;
        //meshRender.GetComponent<Rigidbody>().useGravity = true;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Big Loop")
        {
            for (int i = 0; i < skinRenders.Length; i++)
            {
                skinRenders[i].GetComponent<SkinnedMeshRenderer>().enabled = false;
            }
            particles.SetActive(true);
            //meshRender.GetComponent<SphereCollider>().enabled = false;
            player.GetComponent<RacecarController>().enabled = false;
            waypoint.GetComponent<Waypoints>().enabled = true;
            waypoint.GetComponent<Waypoints>().gravity = false;
        }
        else if (other.gameObject.tag == "Big Loop End")
        {
            for (int i = 0; i < skinRenders.Length; i++)
            {
                skinRenders[i].GetComponent<SkinnedMeshRenderer>().enabled = true;
            }
            particles.SetActive(false);
            player.GetComponent<Rigidbody>().useGravity = true;
            //meshRender.GetComponent<SphereCollider>().enabled = true;
            player.GetComponent<RacecarController>().enabled = true;
            waypoint.GetComponent<Waypoints>().gravity = true;
            waypoint.GetComponent<Waypoints>().enabled = false;
        }
    }
}
