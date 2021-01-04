using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

    


public class MainMenu : MonoBehaviour{

    public void PlayGame ()
    {
        SceneManager.LoadScene("Level1");
    }//loads scene with name level1
     public void menufunction ()
    {
        SceneManager.LoadScene("Main_Menu");
    }//loads the menu scene
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Bye!!");
    }//when built, quits thge game goes to homescreen. but when in unity project, displays bye in console
}
