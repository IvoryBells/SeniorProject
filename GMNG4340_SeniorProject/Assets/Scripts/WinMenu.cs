using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void LoadMainMenu()    {
        
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void Restart()
    {        
        SceneManager.LoadScene("ChromaCityRework");
    }

    public void LoadRacerSelection()
    {
        SceneManager.LoadScene("CharacterSelection");
    }
}
