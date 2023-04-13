using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{

    public void Challenge4()
    {
        SceneManager.LoadScene("Challenge 4");
    }


    public void LoadPrototype4()
    {
        SceneManager.LoadScene("Prototype 4");
    }
    
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Main Menu");
    }
}