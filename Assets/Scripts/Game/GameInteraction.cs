using Characters;
using Data;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    public class GameInteraction : MonoBehaviour
    {
        private readonly System.Random _random = new System.Random();

        public GameObject gameObject;
        public MonsterInteraction monsterInteraction;
        
        public Data.Data data;
        public Hero hero1;
        public Hero hero2;
        public Hero hero3;

        
    
        private void Awake()
        {
            hero1.classOfHero = 1;
            hero2.classOfHero = 2;
            hero3.classOfHero = 3;
        }
    
    
    
        public void SaveData()
        {
            string key1 = "Hero1";
            string key2 = "Hero2";
            string key3 = "Hero3";
         
            data.SaveData(key1, hero1);
            data.SaveData(key2, hero2);
            data.SaveData(key3, hero3);
         
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
                DataInteraction.setHeroDataAfterLoad(JsonUtility.FromJson<Hero>(value), 1);
            }
            if(PlayerPrefs.HasKey(key2))
            {
                string value = PlayerPrefs.GetString(key2);
                DataInteraction.setHeroDataAfterLoad(JsonUtility.FromJson<Hero>(value), 2);
            }
            if(PlayerPrefs.HasKey(key3))
            {
                string value = PlayerPrefs.GetString(key3);
                DataInteraction.setHeroDataAfterLoad(JsonUtility.FromJson<Hero>(value), 3);
            }
        }
    
        public void Continue()
        {
            SceneManager.LoadScene(DataInteraction.lastSaved);
        }


        public void OpenInventory()
        {
            if(!gameObject.activeSelf)
            {
                gameObject.SetActive(true);
            }
        }

    }
}
