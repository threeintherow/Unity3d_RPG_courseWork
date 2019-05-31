using Data;
using Game;
using UnityEngine;

namespace Characters
{
    public class Hero : MonoBehaviour
    {
        public GameInteraction gameInteraction;
        public Data.Data data;
        
        public int classOfHero;    // 1 - воин. 2 - вор. 3 - маг
        public int health;
        public int healthMax;
        public int damage;
        public int level;
        public int typeOfDamage;    // 1 - магический. 2 - физический
        public int magicResist;
        public int physicalResist;
        public int experience;
        public int experienceMax;
        public int mind;
        public int force;
        public int agility;
        public int luck;
        public int speed;


        public Hero(int type, int level = 1)
        {
            this.classOfHero = type;
            this.level = level;
            this.physicalResist = 0;
            this.magicResist = 0;
            PrimaryCharacteristics(classOfHero);
        }
        public void SetCh(int classOfHero, int level = 1)
        {
            this.classOfHero = classOfHero;
            this.level = level;
            this.physicalResist = 0;
            this.magicResist = 0;
            PrimaryCharacteristics(classOfHero);
        }

        public void SetCh(Hero hero)
        {
            this.luck = hero.luck;
            this.mind = hero.mind;
            this.force = hero.force;
            this.speed = hero.speed;
            this.agility = hero.agility;
            this.damage = hero.damage;
            this.level = hero.level;
            this.classOfHero = hero.classOfHero;
            this.health = hero.health;
            this.typeOfDamage = hero.typeOfDamage;
            this.magicResist = hero.magicResist;
            this.physicalResist = hero.physicalResist;
        }
        public void IncreaseMind(int number)
        {
            mind += number;
            if(mind > 100)
            {
                mind = 100;
            }
        }
        public void IncreaseForce(int number)
        {
            force += number;
            if(force > 100)
            {
                force = 100;
            }
        }
        public void IncreaseAgility(int number)
        {
            agility += number;
            if(agility > 100)
            {
                agility = 100;
            }
        }
        public void IncreaseLuck(int number)
        {
            luck += number;
            if(luck > 100)
            {
                luck = 100;
            }
        }
        public void IncreaseSpeed(int number)
        {
            speed += number;
            if(speed > 100)
            {
                speed = 100;
            }
        }


        private void Characteristics(int mind, int force, int agility, int luck, int speed)
        {
            this.mind = mind;
            this.force = force;
            this.agility = agility;
            this.luck = luck;
            this.speed = speed;
        }
        private void PrimaryCharacteristics(int classOfHero)
        {
            switch(classOfHero)
            {
                case 1:
                    Characteristics(40, 78, 60, 60, 50);
                    this.healthMax = 95 + level * 5;
                    this.health = healthMax;
                    this.experienceMax = 90;
                    this.experience = 0;
                    this.damage = 12;
                    this.typeOfDamage = 2;               
                    break;
                case 2:                
                    Characteristics(50, 60, 70, 65, 70);
                    this.healthMax = 95 + level * 5;
                    this.health = healthMax;
                    this.experienceMax = 90;
                    this.experience = 0;
                    this.damage = 9;
                    this.typeOfDamage = 2;
                    break;
                case 3:
                    Characteristics(78, 55, 60, 60, 40);
                    this.healthMax = 95 + level * 5;
                    this.health = healthMax;
                    this.experienceMax = 90;
                    this.experience = 0;
                    this.damage = 10;
                    this.typeOfDamage = 1;
                    break;
            }
        }

        private void IncreaseHealth()    //увеличение показателя хп при поднятии уровня
        {
            this.healthMax = 95 + level * 5;
        }

        private void IncreaseDamage()    //увеличение показателя урона при поднятии уровня
        {
            this.damage += 3;
        }
    
        public void IncreaseDamage(int value)
        {
            this.damage += value;
        }

        public void ReduceDamage(int value)
        {
            if(damage < value)
            {
                damage = 10 + level * 2;
            }
            else
            {
                damage -= value;
            }
        }

        public void IncreaseLevel()
        {
            this.level++;
            IncreaseHealth();
            IncreaseDamage();
            this.experience = 0;
            this.experienceMax = experienceMax + level * 5;
        }

        public void IncreaseMagicResist(int number)
        {
            this.magicResist += number;
        }

        public void IncreasePhysicalResist(int number)
        {
            this.physicalResist += number;
        }
        public bool TakeDamage(int damage, int typeOfDamage)    //возвращает true если герой погиб
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

        public string GetKey()
        {
            return ("Hero" + classOfHero.ToString());
        }
        // Start is called before the first frame update
        void Start()
        {
            this.SetCh(DataInteraction.GetHero(this.classOfHero));
        }

        public void SaveData()
        {
            string key = "Hero" + classOfHero.ToString();
            data.SaveData(key, this);
        }

        public void LoadData()
        {
            string key = "Hero" + classOfHero.ToString();
            Hero hero = data.LoadData(key);
            this.SetCh(hero);
        }
    }
}
