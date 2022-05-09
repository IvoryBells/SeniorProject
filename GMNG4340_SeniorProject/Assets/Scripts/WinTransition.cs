using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTransition : MonoBehaviour
{
    public GameObject character;
    public GameObject num;

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");
    }



    public void OnTriggerEnter(Collider other)
     {

        if(num.GetComponent<LapSystem>().lapNum == 2)
        {
            CharWin();
        }
        
     }


    void CharWin()
    {
        //Kage Win Screen
        if (character.layer == LayerMask.NameToLayer("Kage"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Kage_Cutscene");
        }

        //Galactica Win Screen
        if (character.layer == LayerMask.NameToLayer("Galactica"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Galactica_Cutscene");
        }

        //Ember Win Screen
        if (character.layer == LayerMask.NameToLayer("Ember"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Ember_Cutscene");
        }

        //Zeru Win Screen
        if (character.layer == LayerMask.NameToLayer("Zeru"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Zeru_Cutscene");
        }
    }
}
