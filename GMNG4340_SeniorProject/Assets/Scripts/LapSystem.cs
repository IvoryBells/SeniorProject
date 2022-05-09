using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapSystem : MonoBehaviour
{
    public GameObject lapText;
    public int lapNum;
    //public AudioSource lapSound;

    void OnTriggerEnter(Collider other)
    {
        lapNum += 1;
        lapText.GetComponent<Text>().text = "Lap: " + lapNum; 



    }


}
