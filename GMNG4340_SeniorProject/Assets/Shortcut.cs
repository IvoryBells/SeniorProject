using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shortcut : MonoBehaviour
{
    public GameObject[] skinRenders;
    public GameObject particles;
    public GameObject shortcut;
    public GameObject player;
    public Quaternion shortcutRotation;
    public float lerpTime;

    // Start is called before the first frame update
    void Start()
    {
        shortcut = GameObject.FindGameObjectWithTag("Shortcut");

        skinRenders = GameObject.FindGameObjectsWithTag("Skin Render");
        /*for (int i = 0; i < gameObjects.Length; i++)
        {
            skinRenders[i] = gameObjects[i];
        }*/

        player = GameObject.FindGameObjectWithTag("Player");

        particles.SetActive(false);
        shortcut.GetComponent<ShortcutWaypoints>().enabled = true;
        //meshRender.GetComponent<Rigidbody>().useGravity = true;
    }


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shortcut Start")
        {
            for (int i = 0; i < skinRenders.Length; i++)
            {
                skinRenders[i].GetComponent<SkinnedMeshRenderer>().enabled = false;
            }
            particles.SetActive(true);
            //meshRender.GetComponent<SphereCollider>().enabled = false;
            player.GetComponent<RacecarController>().enabled = false;
            shortcut.GetComponent<ShortcutWaypoints>().enabled = true;
            shortcut.GetComponent<ShortcutWaypoints>().gravity = false;

            player.transform.rotation = Quaternion.Lerp(transform.rotation, shortcutRotation, lerpTime);
        }
        else if (other.gameObject.tag == "Shortcut End")
        {
            for (int i = 0; i < skinRenders.Length; i++)
            {
                skinRenders[i].GetComponent<SkinnedMeshRenderer>().enabled = true;
            }
            particles.SetActive(false);
            player.GetComponent<Rigidbody>().useGravity = true;
            //meshRender.GetComponent<SphereCollider>().enabled = true;
            player.GetComponent<RacecarController>().enabled = true;
            shortcut.GetComponent<ShortcutWaypoints>().gravity = true;
            shortcut.GetComponent<ShortcutWaypoints>().enabled = false;
        }
    }
}
