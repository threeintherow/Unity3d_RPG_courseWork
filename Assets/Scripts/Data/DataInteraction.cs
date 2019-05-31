using System;
using System.Collections.Generic;
using Characters;
using UnityEngine;

namespace Data
{
    public class DataInteraction : MonoBehaviour
    {
        private static bool _music = true;
   
        public static int lastSaved = 0;

        public static Hero hero1;
        public static Hero hero2;
        public static Hero hero3;

//    public static void FirstCharacterCreation()
//    {
//        hero1 = new DataClass.Hero(1);
//        hero2 = new DataClass.Hero(2);
//        hero3 = new DataClass.Hero(3);
//    }

        public void Awake()
        {
            hero1 = gameObject.AddComponent<Hero>();
            hero1.SetCh(1);
            hero2 = gameObject.AddComponent<Hero>();
            hero2.SetCh(2);
            hero3 = gameObject.AddComponent<Hero>();
            hero3.SetCh(3);
        }


        public static Hero GetHero(int index)
        {
            switch (index)
            {
                case 1:
                    return hero1;
                case 2:
                    return hero2;
                case 3:
                    return hero3;
                default:
                    return null;
            }
        }
        public Enemy CreateEnemy()
        {
            return gameObject.AddComponent<Enemy>();
        }

        public static void TurnOffMusic()
        {
            _music = false;
        }

        public static void TurnOnMusic()
        {
            _music = true;
        }

        public static void setHeroDataAfterLoad(Hero hero, int index)
        {
            switch(index)
            {
                case 1:
                    hero1 = hero;
                    break;
                case 2:
                    hero2 = hero;
                    break;
                case 3:
                    hero3 = hero;
                    break;
            }
        }
    }
}
