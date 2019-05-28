using Characters;
using UnityEngine;

namespace Data
{
    public class Data : MonoBehaviour
    {

        /*public void Start()
    {
        string key1 = "Hero1";
        string key2 = "Hero2";
        string key3 = "Hero3";
        
        Hero hero1 = DataInteraction.hero4;
        Hero hero2 = DataInteraction.hero5;
        Hero hero3 = DataInteraction.hero6;
     
        string savedHero1 = JsonUtility.ToJson(hero1);
        string savedHero2 = JsonUtility.ToJson(hero2);
        string savedHero3 = JsonUtility.ToJson(hero3);
     
        PlayerPrefs.SetString(key1, savedHero1);
        PlayerPrefs.SetString(key2, savedHero2);
        PlayerPrefs.SetString(key3, savedHero3);
             
        PlayerPrefs.Save();
        
    }*/
        public void SaveData(string key, Hero hero)
        {
        
            string savedHero = JsonUtility.ToJson(hero);

            PlayerPrefs.SetString(key, savedHero);
        
            PlayerPrefs.Save();

        }

        public Hero LoadData(string key)
        {
            if(PlayerPrefs.HasKey(key))
            {
                string value = PlayerPrefs.GetString(key);
                Hero hero = JsonUtility.FromJson<Hero>(value);
                return hero;
            }
            return null;
        }
    }
}
