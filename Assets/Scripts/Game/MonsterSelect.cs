using System.Collections;
using System.Collections.Generic;
using Unity.UNetWeaver;
using UnityEngine;

namespace Game
{
    public class MonsterSelect : MonoBehaviour
    {
        public GameObject an1, an2, an3;
        public GameInteraction gameInteraction;
        public void OnMouseDown()
        {
            if (gameObject.name.Equals("Slime_Green") || gameObject.name.Equals("Rabbit_Cyan"))
            {
                if (an2.GetComponent<ParticleSystem>().isPlaying)
                {
                    an2.GetComponent<ParticleSystem>().Stop();
                }

                if (an3.GetComponent<ParticleSystem>().isPlaying)
                {
                    an3.GetComponent<ParticleSystem>().Stop();
                }
                an1.GetComponent<ParticleSystem>().Play();
                gameInteraction.chosenEnemy = 1;
            }
            else if (gameObject.name.Equals("Bat_Green") || gameObject.name.Equals("Rabbit_Red"))
            {
                if (an1.GetComponent<ParticleSystem>().isPlaying)
                {
                    an1.GetComponent<ParticleSystem>().Stop();
                }

                if (an3.GetComponent<ParticleSystem>().isPlaying)
                {
                    an3.GetComponent<ParticleSystem>().Stop();
                }
                an2.GetComponent<ParticleSystem>().Play();
                gameInteraction.chosenEnemy = 2;
            }
            else if (gameObject.name.Equals("Ghost_Violet") || gameObject.name.Equals("Rabbit_Yellow"))
            {
                if (an1.GetComponent<ParticleSystem>().isPlaying)
                {
                    an1.GetComponent<ParticleSystem>().Stop();
                }

                if (an2.GetComponent<ParticleSystem>().isPlaying)
                {
                    an2.GetComponent<ParticleSystem>().Stop();
                }
                an3.GetComponent<ParticleSystem>().Play();
                gameInteraction.chosenEnemy = 3;
            }
        }
    }
}
