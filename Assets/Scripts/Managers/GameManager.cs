using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void TutorialLevel()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
