using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public void SetScene(int level)
    {
        DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(level);
    }

    public void SetPreviousScene()
    {
        print(DataInteraction.lastSaved);
        SceneManager.LoadScene(DataInteraction.lastSaved);
    }
}
