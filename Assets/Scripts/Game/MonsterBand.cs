using System;
using System.Collections;
using System.Collections.Generic;
using Characters;
using UnityEngine;

public class MonsterBand : MonoBehaviour
{
    public Enemy monster1;
    public Enemy monster2;
    public Enemy monster3;

    public void Start()
    {
        monster1.CreateEnemy();
        monster2.CreateEnemy();
        monster3.CreateEnemy();
    }
}
