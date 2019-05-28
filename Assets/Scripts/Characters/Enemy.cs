using Data;
using UnityEngine;

namespace Characters
{
    public class Enemy : MonoBehaviour
    {
        public int damage;
        public int health;
        public int maxHp;
        public int typeOfDamage;    // 1 - магический. 2 - физический
        public int magicResist;
        public int physicalResist;
        public void CreateEnemy()
        {
            health = 95 + DataInteraction.GetHero(Random.Range(1, 3)).level * 5;
            maxHp = health;
            damage = 15 + DataInteraction.GetHero(Random.Range(1, 3)).level * 5;
            typeOfDamage = Random.Range(1, 2);
            switch (Random.Range(1, 3))
            {
                case 1:
                    magicResist = Random.Range(0, DataInteraction.GetHero(Random.Range(1, 3)).level * 3);
                    break;
                case 2:
                    physicalResist = Random.Range(0, DataInteraction.GetHero(Random.Range(1, 3)).level * 3);
                    break;
                case 3:
                    magicResist = Random.Range(0, DataInteraction.GetHero(Random.Range(1, 3)).level * 3);
                    physicalResist = Random.Range(0, DataInteraction.GetHero(Random.Range(1, 3)).level * 3);
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
