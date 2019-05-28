using System;
using Data;
using Game;
using UnityEngine;
using Random = System.Random;

namespace Characters
{
    public class Enemy : MonoBehaviour
    {
        public GameInteraction gameInteraction;
        public Data.Data data;
        public int damage;
        public int health;
        public int maxHp;
        public int typeOfDamage;    // 1 - магический. 2 - физический
        public int magicResist;
        public int physicalResist;
        private Random rnd = new Random((int)DateTime.Now.Ticks);

        private void Update()
        {
            rnd = new Random((int)DateTime.Now.Ticks);
        }

        public void CreateEnemy()
        {
            health = 45 + DataInteraction.GetHero(rnd.Next(1, 3)).level * rnd.Next(5, 20);
            maxHp = health;
            damage = 15 + DataInteraction.GetHero(rnd.Next(1, 3)).level * rnd.Next(1, 6);
            typeOfDamage = rnd.Next(1, 2);
            switch (rnd.Next(1, 3))
            {
                case 1:
                    magicResist = rnd.Next(0, DataInteraction.GetHero(rnd.Next(1, 3)).level * 4);
                    break;
                case 2:
                    physicalResist = rnd.Next(0, DataInteraction.GetHero(rnd.Next(1, 3)).level * 4);
                    break;
                case 3:
                    magicResist = rnd.Next(0, DataInteraction.GetHero(rnd.Next(1, 3)).level * 4);
                    physicalResist = rnd.Next(0, DataInteraction.GetHero(rnd.Next(1, 3)).level * 4);
                    break;
            }
        }

        public bool TakeDamage(int damage, int typeOfDamage)    //возвращает true если монстр погиб
        {
            switch(typeOfDamage)
            {
                case 1:
                    if(damage > magicResist)
                    {
                        health -= (damage - magicResist);
                        if(health < 1)
                        {
                            return true;
                        }
                    }
                    else if(damage < magicResist && health > 0)
                    {
                        return false;
                    }
                    break;
                case 2:
                    if(damage > physicalResist)
                    {
                        health -= (damage - physicalResist);
                        if(health < 1)
                        {
                            return true;
                        }
                    }
                    else if(damage < physicalResist &&
                            health > 0)
                    {
                        return false;
                    }
                    break;
            }
            return false;
        }
    }
}
