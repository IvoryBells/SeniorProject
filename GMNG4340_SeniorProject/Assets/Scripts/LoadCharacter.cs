using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform spawnPoint;
    //public TMP_Text label;

    public void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        Debug.Log(selectedCharacter);
        GameObject prefab = characterPrefabs[selectedCharacter];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.Euler(new Vector3(0, -90, 0)));
        //label.text = prefab.name;
    }     
}
