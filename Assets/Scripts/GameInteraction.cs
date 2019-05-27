using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInteraction : MonoBehaviour
{
    private readonly System.Random _random = new System.Random();

    private DataClass.Monster _monster1 = DataInteraction.CreateNewMonster();
    private DataClass.Monster _monster2 = DataInteraction.CreateNewMonster();
    private DataClass.Monster _monster3 = DataInteraction.CreateNewMonster();

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

    public void SaveData()
    {
        string key1 = "Hero1";
        string key2 = "Hero2";
        string key3 = "Hero3";
        DataClass.Hero hero1 = DataInteraction.GetHero(1);
        DataClass.Hero hero2 = DataInteraction.GetHero(2);
        DataClass.Hero hero3 = DataInteraction.GetHero(3);

        string savedHero1 = JsonUtility.ToJson(hero1);
        string savedHero2 = JsonUtility.ToJson(hero2);
        string savedHero3 = JsonUtility.ToJson(hero3);

        PlayerPrefs.SetString(key1, savedHero1);
        PlayerPrefs.SetString(key2, savedHero2);
        PlayerPrefs.SetString(key3, savedHero3);
        
        PlayerPrefs.Save();

    }

    public void LoadData()
    {
        string key1 = "Hero1";
        string key2 = "Hero2";
        string key3 = "Hero3";

        if(PlayerPrefs.HasKey(key1))
        {
            string value = PlayerPrefs.GetString(key1);
            DataInteraction.setHeroDataAfterLoad(JsonUtility.FromJson<DataClass.Hero>(value), 1);
        }
        if(PlayerPrefs.HasKey(key2))
        {
            string value = PlayerPrefs.GetString(key2);
            DataInteraction.setHeroDataAfterLoad(JsonUtility.FromJson<DataClass.Hero>(value), 2);
        }
        if(PlayerPrefs.HasKey(key3))
        {
            string value = PlayerPrefs.GetString(key3);
            DataInteraction.setHeroDataAfterLoad(JsonUtility.FromJson<DataClass.Hero>(value), 3);
        }
    }
    
    public void Continue()
    {
        SceneManager.LoadScene(DataInteraction.lastSaved);
    }

}
