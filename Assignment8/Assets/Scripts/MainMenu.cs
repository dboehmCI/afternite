﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    public static bool GameIsPaused = false;



    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME!");
        Application.Quit();
    }

    public void goMainMenu()
    {
        SceneManager.LoadScene(0);
    }

 

}
