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
        public MonsterBand monsterBand;
        
        public Data.Data data;
        public Hero hero1;
        public Hero hero2;
        public Hero hero3;

        public bool heroTurn = true;

        private int turnhero;
        private int turnEnemy;
      
        private void Awake()
        {
            turnhero = 1;
            turnEnemy = 1;
            hero1.classOfHero = 1;
            hero2.classOfHero = 2;
            hero3.classOfHero = 3;
        }


        private void Update()
        {
            if(heroTurn)
            {
                
            }
            else
            {
                switch(turnEnemy)
                {
                    case 1:
                        switch(Random.Range(1, 3))
                        {
                            case 1:
                                if(hero1.TakeDamage(monsterBand.monster1.damage, monsterBand.monster1.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                            case 2:
                                if(hero2.TakeDamage(monsterBand.monster1.damage, monsterBand.monster1.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                            case 3:
                                if(hero3.TakeDamage(monsterBand.monster1.damage, monsterBand.monster1.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                        }
                        break;
                    case 2:
                        switch(Random.Range(1, 3))
                        {
                            case 1:
                                if(hero1.TakeDamage(monsterBand.monster2.damage, monsterBand.monster2.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                            case 2:
                                if(hero2.TakeDamage(monsterBand.monster2.damage, monsterBand.monster2.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                            case 3:
                                if(hero3.TakeDamage(monsterBand.monster2.damage, monsterBand.monster2.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                        }
                        break;
                    case 3:
                        switch(Random.Range(1, 3))
                        {
                            case 1:
                                if(hero1.TakeDamage(monsterBand.monster3.damage, monsterBand.monster3.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                            case 2:
                                if(hero2.TakeDamage(monsterBand.monster3.damage, monsterBand.monster3.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                            case 3:
                                if(hero3.TakeDamage(monsterBand.monster3.damage, monsterBand.monster3.typeOfDamage))
                                {
                                    //герой умирает
                                }
                                break;
                        }
                        break;
                }
                heroTurn = true;
                turnEnemy++;
                if(turnEnemy > 3)
                {
                    turnEnemy = 1;
                }
            }
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
