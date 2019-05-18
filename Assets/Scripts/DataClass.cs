using System.Collections;
using System.Collections.Generic;

public class DataClass
{
    public class Characteristics
    {
        private int _mind;
        private int _force;
        private int _agility;
        private int _luck;
        private int _speed;

        public Characteristics(int mind, int force, int agility, int luck, int speed)
        {
            this._mind = mind;
            this._force = force;
            this._agility = agility;
            this._luck = luck;
            this._speed = speed;
        }

        public int GetMind()
        {
            return this._mind;
        }
        public int GetForce()
        {
            return this._force;
        }
        public int GetAgility()
        {
            return this._agility;
        }
        public int GetLuck()
        {
            return this._luck;
        }
        public int GetSpeed()
        {
            return this._speed;
        }

        public void IncreaseMind(int number)
        {
            this._mind += number;
            if(this._mind > 100)
            {
                this._mind = 100;
            }
        }
        public void IncreaseForce(int number)
        {
            this._force += number;
            if(this._force > 100)
            {
                this._force = 100;
            }
        }
        public void IncreaseAgility(int number)
        {
            this._agility += number;
            if(this._agility > 100)
            {
                this._agility = 100;
            }
        }
        public void IncreaseLuck(int number)
        {
            this._luck += number;
            if(this._luck > 100)
            {
                this._luck = 100;
            }
        }
        public void IncreaseSpeed(int number)
        {
            this._speed += number;
            if(this._speed > 100)
            {
                this._speed = 100;
            }
        }
    }
    public class Hero
    {
        private int _classOfHero;    // 1 - маг. 2 - воин. 3 - вор
        private int _health;
        private Characteristics _characteristics;
        private int _damage;
        private int _level;
        private int _typeOfDamage;    // 1 - магический. 2 - физический
        private int _magicResist;
        private int _physicalResist;

        public Hero(int classOfHero, int level = 1)
        {
            this._classOfHero = classOfHero;
            this._level = level;
            this._physicalResist = 0;
            this._magicResist = 0;
            primaryCharacteristics(classOfHero);
        }

        private void primaryCharacteristics(int classOfHero)
        {
            switch(classOfHero)
            {
                case 1:
                    this._characteristics = new Characteristics(78, 55, 60, 60, 40);
                    this._health = 95 + _level * 5;
                    this._damage = 10;
                    this._typeOfDamage = 1;
                    break;
                case 2:
                    this._characteristics = new Characteristics(40, 78, 60, 60, 50);
                    this._health = 95 + _level * 5;
                    this._damage = 12;
                    this._typeOfDamage = 2;
                    break;
                case 3:
                    this._characteristics = new Characteristics(50, 60, 70, 65, 70);
                    this._health = 95 + _level * 5;
                    this._damage = 9;
                    this._typeOfDamage = 2;
                    break;
            }
        }

        private void IncreaseHealth()
        {
            this._health = 95 + _level * 5;
        }

        public int GetDamage()
        {
            return this._damage;
        }

        public int GetHealth()
        {
            return this._health;
        }

        public int GetLevel()
        {
            return this._level;
        }

        public int GetTypeOfDamage()
        {
            return this._typeOfDamage;
        }

        public int GetMagicResist()
        {
            return this._magicResist;
        }

        public int GetPhysicalResist()
        {
            return this._physicalResist;
        }

        public Characteristics GetCharacteristics()
        {
            return this._characteristics;
        }

        public void SetNewDamage(int newDamage)
        {
            this._damage = newDamage;
        }

        public void IncreaseLevel()
        {
            this._level++;
            IncreaseHealth();
        }

        public void IncreaseMagicResist(int number)
        {
            this._magicResist += number;
        }

        public void IncreasePhysicalResist(int number)
        {
            this._physicalResist += number;
        }
    }
}
