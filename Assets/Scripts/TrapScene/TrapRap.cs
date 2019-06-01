using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using Unity.UNetWeaver;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = System.Random;

public class TrapRap : MonoBehaviour
{
    public GameInteraction gameInteraction;
    public GameObject f1, f2, f3, f4, f5, f6, f7, f8, f9;
    private Random rnd = new Random((int)DateTime.Now.Ticks);
    public ManagingScenes ms;

    public void trap()
    {
        if(rnd.Next(101) <= 67)
        {
            gameInteraction.hero1.health -= 5;
            gameInteraction.hero2.health -= 5;
            gameInteraction.hero3.health -= 5;
            rnd = new Random((int)DateTime.Now.Ticks);
            f1.GetComponent<ParticleSystem>().Play();
            f2.GetComponent<ParticleSystem>().Play();
            f3.GetComponent<ParticleSystem>().Play();
            f4.GetComponent<ParticleSystem>().Play();
            f5.GetComponent<ParticleSystem>().Play();
            f6.GetComponent<ParticleSystem>().Play();
            f7.GetComponent<ParticleSystem>().Play();
            f8.GetComponent<ParticleSystem>().Play();
            f9.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            f1.GetComponent<ParticleSystem>().Stop();
            f2.GetComponent<ParticleSystem>().Stop();
            f3.GetComponent<ParticleSystem>().Stop();
            f4.GetComponent<ParticleSystem>().Stop();
            f5.GetComponent<ParticleSystem>().Stop();
            f6.GetComponent<ParticleSystem>().Stop();
            f7.GetComponent<ParticleSystem>().Stop();
            f8.GetComponent<ParticleSystem>().Stop();
            f9.GetComponent<ParticleSystem>().Stop();
            ms.SetScene(rnd.Next(2, 4));
        }
        
    }
    
}
