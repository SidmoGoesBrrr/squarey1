﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    


public class MainMenu : MonoBehaviour{

    public void PlayGame ()
    {
        SceneManager.LoadScene("Level1");
    }
     public void menufunction ()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Bye!!");
    }
}
