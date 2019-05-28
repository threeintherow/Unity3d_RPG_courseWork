using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagingScenes : MonoBehaviour
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

    public void ShowStatistics()
    {
        DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
    }

    public void SetNextLevel()
    {
        int nextScene = Random.Range(2, SceneManager.sceneCountInBuildSettings);
        while(nextScene == SceneManager.GetActiveScene().buildIndex)
        {
            nextScene = Random.Range(2, SceneManager.sceneCountInBuildSettings);
        }
        DataInteraction.lastSaved = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nextScene);
        
        //альтернатива
        //SceneManager.LoadScene(Random.Range(2, SceneManager.sceneCount);
    }
}
