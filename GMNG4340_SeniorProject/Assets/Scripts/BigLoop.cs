using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigLoop : MonoBehaviour
{
    public GameObject meshRender;
    public GameObject particles;
    // Start is called before the first frame update
    void Awake()
    {
        particles.SetActive(false);
        meshRender.SetActive(true);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Big Loop")
        {
            meshRender.GetComponent<MeshRenderer>().enabled = false;
            particles.SetActive(true);
        }
        else if (other.gameObject.tag == "Big Loop End")
        {
            meshRender.GetComponent<MeshRenderer>().enabled = true;
            particles.SetActive(false);
        }
    }
}
