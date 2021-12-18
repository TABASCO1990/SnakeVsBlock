using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour
{
    public GameObject LoseScene;
    public GameObject WinScene;
    public GameObject SceneOnPlay;

    private int currentScene;
    private int allScene;


    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex + 1;
        allScene = SceneManager.sceneCountInBuildSettings;
    }

    public void Restart()
    {
        LoseScene.SetActive(false);
        ReloadLevel();
    }
    
    private void ReloadLevel()
    {
        Time.timeScale = 1;
        OnPlayerDied();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnPlayerDied()
    {
        PlayerControl.lengthTail = 0;
        SceneOnPlay.SetActive(false);
        LoseScene.SetActive(true);
    }

    public void NextScene()
    {
        if (currentScene + 1 > allScene)
        {
            SceneManager.LoadScene(0);
            PlayerControl.lengthTail = 0;
            Time.timeScale = 1;
        }

        else
        {
            NextLvl();
            currentScene++;
        }
    }
    private void NextLvl()
    {
        Time.timeScale = 1;
        WinScene.SetActive(false);
        PlayerControl.lengthTail = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        SceneOnPlay.SetActive(true);
    }
    public void OnPlayerFinish()
    {
        Time.timeScale = 0;
        SceneOnPlay.SetActive(false);
        WinScene.SetActive(true);
    }

    public void RestartOnPlay()
    {
        PlayerControl.lengthTail = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
