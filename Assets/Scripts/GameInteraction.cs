using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInteraction : MonoBehaviour
{
    private readonly System.Random _random = new System.Random();

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

    public void ShowStatistics()
    {
        DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
    }

    public void SetNextLevel()
    {
        int nextScene = _random.Next(2, SceneManager.sceneCountInBuildSettings);
        while(nextScene == SceneManager.GetActiveScene().buildIndex)
        {
            nextScene = _random.Next(2, SceneManager.sceneCountInBuildSettings);
        }
        DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nextScene);
        
        //альтернатива
        //SceneManager.LoadScene(Random.Range(2, SceneManager.sceneCount);
    }

    public void Continue()
    {
        SceneManager.LoadScene(DataInteraction.lastSaved);
    }
}
