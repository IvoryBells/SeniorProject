using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //SceneManager.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(0);
    }
}
