using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] public bool isCanDraw = false;

    public void Start()
    {
        isCanDraw = false;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void TutorialLevel()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("TitleScreen");
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
