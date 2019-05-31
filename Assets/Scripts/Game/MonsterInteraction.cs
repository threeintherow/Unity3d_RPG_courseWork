using System.Collections;
using System.Collections.Generic;
using Characters;
using Game;
using UnityEngine;

public class MonsterInteraction : MonoBehaviour
 {
     public GameInteraction gameInteraction;
     public Enemy enemy1;
     public Enemy enemy2;
     public Enemy enemy3;
     // Start is called before the first frame update
     void Start()
     {
         enemy1.CreateEnemy();
         enemy2.CreateEnemy();
         enemy3.CreateEnemy();
     }
 }
