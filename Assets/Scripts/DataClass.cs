﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            _mind = mind;
            _force = force;
            _agility = agility;
            _luck = luck;
            _speed = speed;
        }

        public int GetMind()
        {
            return _mind;
        }
        public int GetForce()
        {
            return _force;
        }
        public int GetAgility()
        {
            return _agility;
        }
        public int GetLuck()
        {
            return _luck;
        }
        public int GetSpeed()
        {
            return _speed;
        }

        public void IncreaseMind(int number)
        {
            _mind += number;
            if(_mind > 100)
            {
                _mind = 100;
            }
        }
        public void IncreaseForce(int number)
        {
            _force += number;
            if(_force > 100)
            {
                _force = 100;
            }
        }
        public void IncreaseAgility(int number)
        {
            _agility += number;
            if(_agility > 100)
            {
                _agility = 100;
            }
        }
        public void IncreaseLuck(int number)
        {
            _luck += number;
            if(_luck > 100)
            {
                _luck = 100;
            }
        }
        public void IncreaseSpeed(int number)
        {
            _speed += number;
            if(_speed > 100)
            {
                _speed = 100;
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

    public class Monster
    {
        private int _damage;
        private int _health;
        private int _typeOfDamage;    // 1 - магический. 2 - физический
        private int _magicResist;
        private int _physicalResist;
        public Monster(Hero hero)
        {
            _health = 95 + hero.GetLevel() * 5;
            _damage = 15 + hero.GetLevel() * 5;
            _typeOfDamage = Random.Range(1, 2);
            switch (Random.Range(1, 3))
            {
                case 1:
                    _magicResist = Random.Range(0, hero.GetLevel() * 7);
                    break;
                case 2:
                    _physicalResist = Random.Range(0, hero.GetLevel() * 7);
                    break;
                case 3:
                    _magicResist = Random.Range(0, hero.GetLevel() * 7);
                    _physicalResist = Random.Range(0, hero.GetLevel() * 7);
                    break;
            }
        }

    }
}
