using Characters;
using Data;
using StatsScene;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Game
{
    public class GameInteraction : MonoBehaviour
    {
        private readonly System.Random _random = new System.Random();


        public DataInteraction dataInteraction;

        public GameObject hero1GameObject;
        public GameObject hero2GameObject;
        public GameObject hero3GameObject;

        public GameObject winPanel;
        public GameObject stats;

        public StatsScript statsScript;
        public Text expText;
        public PanelOpener panelOpener;
        public GameObject gameObject;
        public MonsterBand monsterBand;

        public GameObject camera;
        
        public Data.Data data;
        public Hero hero1;
        public Hero hero2;
        public Hero hero3;

        public bool heroTurn = true;
        public bool heroAlreadyAttack;

        private int turnhero;
        private int turnEnemy;
        public int chosenEnemy = 0;
        public int deadEnemy = 0;
        public int deadHero = 0;

        private void Awake()
        {
            turnhero = 1;
            turnEnemy = 1;
            hero1.classOfHero = 1;
            hero2.classOfHero = 2;
            hero3.classOfHero = 3;
            stats.SetActive(false);
        }


        private void Update()
        {
            if(heroTurn == false/* && deadHero < 4*/)
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
                                    deadHero++;
                                }
                                break;
                            case 2:
                                if(hero2.TakeDamage(monsterBand.monster1.damage, monsterBand.monster1.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                            case 3:
                                if(hero3.TakeDamage(monsterBand.monster1.damage, monsterBand.monster1.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                        }
                        monsterBand.monster1.GetComponent<Animator>().SetTrigger("Attack");
                        break;
                    case 2:
                        switch(Random.Range(1, 3))
                        {
                            case 1:
                                if(hero1.TakeDamage(monsterBand.monster2.damage, monsterBand.monster2.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                            case 2:
                                if(hero2.TakeDamage(monsterBand.monster2.damage, monsterBand.monster2.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                            case 3:
                                if(hero3.TakeDamage(monsterBand.monster2.damage, monsterBand.monster2.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                        }
                        monsterBand.monster2.GetComponent<Animator>().SetTrigger("Attack");
                        break;
                    case 3:
                        switch(Random.Range(1, 3))
                        {
                            case 1:
                                if(hero1.TakeDamage(monsterBand.monster3.damage, monsterBand.monster3.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                            case 2:
                                if(hero2.TakeDamage(monsterBand.monster3.damage, monsterBand.monster3.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                            case 3:
                                if(hero3.TakeDamage(monsterBand.monster3.damage, monsterBand.monster3.typeOfDamage))
                                {
                                    //герой умирает
                                    deadHero++;
                                }
                                break;
                        }
                        monsterBand.monster3.GetComponent<Animator>().SetTrigger("Attack");
                        break;
                }
                panelOpener.Upt();
                heroTurn = true;
                turnEnemy++;
                if(turnEnemy > 3)
                {
                    turnEnemy = 1;
                }

                heroAlreadyAttack = false;
            }
        }

        public void Battle()
        {
            if(!heroAlreadyAttack)
            {
                heroAlreadyAttack = true;
                if(chosenEnemy == 0)
                {
                    return;
                }
                else
                {
                    switch(turnhero)
                    {
                        case 1:
                            switch(chosenEnemy)
                            {
                                case 1:
                                    if(!monsterBand.monster1.isDied())
                                    {
                                        if(monsterBand.monster1.TakeDamage(hero1.damage, hero1.typeOfDamage))
                                        {
                                            //монстр умирает 
                                            monsterBand.monster1.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                           
                                            print("смертb 1");
                                        }
                                        else
                                        {
                                            monsterBand.monster1.GetComponent<Animator>().SetTrigger("GetDamage");
                                        }
                                    }
                                    break;
                                case 2:
                                    if(!monsterBand.monster2.isDied())
                                    {
                                        if(monsterBand.monster2.TakeDamage(hero1.damage, hero1.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster2.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                            print("смертb 2");
                                        }
                                        else
                                        {
                                            monsterBand.monster2.GetComponent<Animator>().SetTrigger("GetDamage");
                                        }
                                    }
                                    break;
                                case 3:
                                    if(!monsterBand.monster3.isDied())
                                    {
                                        if(monsterBand.monster3.TakeDamage(hero1.damage, hero1.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster3.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                            print("смертb 3");
                                        }
                                        else
                                        {
                                            monsterBand.monster3.GetComponent<Animator>().SetTrigger("GetDamage");
                                        }
                                    }
                                    break;
                            }
                            hero1.GetComponent<Animator>().SetTrigger("Attack");
                            hero1GameObject.transform.Rotate(0, 27.275f, 0);
                            turnhero++;
                            break;
                        case 2:
                            switch(chosenEnemy)
                            {
                                case 1:
                                    if(!monsterBand.monster1.isDied())
                                    {
                                        if(monsterBand.monster1.TakeDamage(hero2.damage, hero2.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster1.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;                                       
                                        }
                                    }
                                    else
                                    {
                                        monsterBand.monster1.GetComponent<Animator>().SetTrigger("GetDamage");
                                    }
    
                                    break;
                                case 2:
                                    if(!monsterBand.monster2.isDied())
                                    {
                                        if(monsterBand.monster2.TakeDamage(hero2.damage, hero2.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster2.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                        }
                                    }
                                    else
                                    {
                                        monsterBand.monster2.GetComponent<Animator>().SetTrigger("GetDamage");
                                    }
    
                                    break;
                                case 3:
                                    if(!monsterBand.monster3.isDied())
                                    {
                                        if(monsterBand.monster3.TakeDamage(hero2.damage, hero2.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster3.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                        }
                                    }
                                    else
                                    {
                                        monsterBand.monster3.GetComponent<Animator>().SetTrigger("GetDamage");
                                    }
    
                                    break;
                            }
                            hero2.GetComponent<Animator>().SetTrigger("Attack");
                            hero2GameObject.transform.Rotate(0, 27.275f, 0);
                            turnhero++;
                            break;
                        case 3:
                            switch(chosenEnemy)
                            {
                                case 1:
                                    if(!monsterBand.monster1.isDied())
                                    {
                                        if(monsterBand.monster1.TakeDamage(hero3.damage, hero3.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster1.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                        }
                                        else
                                        {
                                            monsterBand.monster1.GetComponent<Animator>().SetTrigger("GetDamage");
                                        }
                                    }
    
                                    break;
                                case 2:
                                    if(!monsterBand.monster2.isDied())
                                    {
                                        if(monsterBand.monster2.TakeDamage(hero3.damage, hero3.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster2.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                        }
                                        else
                                        {
                                            monsterBand.monster2.GetComponent<Animator>().SetTrigger("GetDamage");
                                        }
                                    }
    
                                    break;
                                case 3:
                                    if(!monsterBand.monster3.isDied())
                                    {
                                        if(monsterBand.monster3.TakeDamage(hero3.damage, hero3.typeOfDamage))
                                        {
                                            //монстр умирает
                                            monsterBand.monster3.GetComponent<Animator>().SetTrigger("Die");
                                            deadEnemy++;
                                        }
                                        else
                                        {
                                            monsterBand.monster3.GetComponent<Animator>().SetTrigger("GetDamage");
                                        }
                                    }
    
                                    break;
                            }
                            hero3.GetComponent<Animator>().SetTrigger("Attack");
                            hero3GameObject.transform.Rotate(0, 27.275f, 0);
                            turnhero++;
                            
                            break;
                    }
    
                    if(turnhero > 3)
                    {
                        turnhero = 1;
                    }
    
                    panelOpener.Upt();
                    
                    heroTurn = false;
                    
                    if(deadEnemy >= 3)
                    {
                        //SceneManager.LoadScene(Random.Range(2, SceneManager.sceneCountInBuildSettings));
    
                        winPanel.SetActive(true);
    
                        int expForWin = (monsterBand.monster1.maxHp + monsterBand.monster2.maxHp + monsterBand.monster3.maxHp) / 10;
    
    
                        hero1.experience += expForWin;
                        if (hero1.experience >= hero1.experienceMax)
                        {
                            hero1.experience = hero1.experienceMax - hero1.experience;
                            DataInteraction.GetHero(1).IncreaseLevel();
                        }
    
                        hero2.experience += expForWin;
                        if (hero2.experience >= hero2.experienceMax)
                        {
                            hero2.experience = hero2.experienceMax - hero2.experience;
                            DataInteraction.GetHero(1).IncreaseLevel();
                        }
    
                        hero3.experience += expForWin;
                        if (hero3.experience >= hero3.experienceMax)
                        {
                            hero3.experience = hero3.experienceMax - hero3.experience;
                            DataInteraction.GetHero(1).IncreaseLevel();
                        }
    
                        expText.text = expForWin.ToString();
                    }
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
                camera.transform.position = new Vector3(45, 45, 45);
                gameObject.SetActive(true);
            }
        }

        /*public void OpenStats()
        {
            if(!stats.activeSelf)
            {
                stats.SetActive(true);
            }
        }*/
        public void OpenStats()
        {
            if(!stats.activeSelf)
            {
                camera.transform.position = new Vector3(45, 45, 45);
                StatsEnable();
            }
            else
            {
                camera.transform.position = new Vector3(-8.183913f, 8.72238f, -29.79492f);
                StatsDisable();
            }
        }

        public void StatsDisable()
        {
            stats.SetActive(false);
            
        }
        public void StatsEnable()
        {
            statsScript.EnableStats();
            stats.SetActive(true); 
        }

    }
}
