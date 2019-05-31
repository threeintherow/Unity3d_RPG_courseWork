using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class MonsterSelect : MonoBehaviour
    {
        public GameObject an1, an2, an3;
        public void OnMouseDown()
        {
            if (gameObject.name.Equals("Slime_Green"))
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
            }
            else if (gameObject.name.Equals("Bat_Green"))
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
            }
            else if (gameObject.name.Equals("Ghost_Violet"))
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
            }
        }
    }
}
