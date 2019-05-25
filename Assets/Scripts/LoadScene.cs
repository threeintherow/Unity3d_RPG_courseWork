using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void SetScene(int level)
    {
        GameInteraction.currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(level);
    }

    public void SetPreviousScene()
    {
        print(GameInteraction.currentScene);
        SceneManager.LoadScene(GameInteraction.currentScene);
    }
}
